using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaOdonto
{


    public partial class FrmOdontograma : Form
    {

        //OPÇÃO DE CORES PARA DESENHO
        private Color color1 = Color.Black;
        private Color color2 = Color.Blue;
        private Color color3 = Color.Red;

        private Pen _pen;
        private bool _isDrawing = false;
        private Point _startPoint;
        private Bitmap _bitmap;

        //PILHA DE IMAGENS
        private Stack<Bitmap> _undoStack = new Stack<Bitmap>();


        //LISTA DE CHECKBOXES DOS DENTES
        private List<System.Windows.Forms.CheckBox> _checkboxes = new List<System.Windows.Forms.CheckBox>();

        //LISTA DE ÁREAS DA IMAGEM
        private List<Rectangle> _areas = new List<Rectangle>();



        public FrmOdontograma()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, 3);
            _bitmap = new Bitmap(pbImgOdontograma.Width, pbImgOdontograma.Height);
            pbImgOdontograma.Image = _bitmap;
            Stack<Bitmap> undoStack = new Stack<Bitmap>();

            btnUndoCircle.Visible = false;
            btnUndo.Visible = false;
            btnColor.Enabled = false;
        }


        private void pbImgOdontograma_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
        }

        private void pbImgOdontograma_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;

            // Verifique se o círculo desenhado está dentro de uma área
            bool isInsideArea = false;
            foreach (var area in _areas)
            {
                if (area.Contains(e.Location))
                {
                    isInsideArea = true;
                    break;
                }
            }

            // Se estiver dentro de uma área, marque a checkbox correspondente
            if (isInsideArea)
            {
                foreach (var checkBox in _checkboxes)
                {
                    if (checkBox.Tag != null && checkBox.Tag.ToString() == "dente" + e.X + "," + e.Y)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }



            _isDrawing = false;

            // Determine qual dente foi selecionado
            foreach (var checkBox in _checkboxes)
            {
                if (checkBox.Tag != null && checkBox.Tag.ToString() == "dente" + e.X + "," + e.Y)
                {
                    checkBox.Checked = true;
                    break;
                }
            }
        }


        private void pbImgOdontograma_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing && pbCircle.BorderStyle == BorderStyle.FixedSingle)
            {
                _undoStack.Push(new Bitmap(_bitmap)); // empilha a imagem atual
                Graphics g = Graphics.FromImage(_bitmap);
                g.DrawEllipse(_pen, _startPoint.X, _startPoint.Y, e.X - _startPoint.X, e.Y - _startPoint.Y);

                // Associe as coordenadas do círculo desenhado a um dente específico
                foreach (var checkBox in _checkboxes)
                {
                    if (checkBox.Tag != null && checkBox.Tag.ToString() == "dente" + _startPoint.X + "," + _startPoint.Y)
                    {
                        checkBox.Tag = "dente" + e.X + "," + e.Y;
                        break;
                    }
                }

                pbImgOdontograma.Invalidate();
            }

            if (_isDrawing && ((pbPenBlack.BorderStyle == BorderStyle.FixedSingle || pbPenBlue.BorderStyle == BorderStyle.FixedSingle || pbPenRed.BorderStyle == BorderStyle.FixedSingle) || pbCircle.BorderStyle == BorderStyle.FixedSingle))
            {
                _undoStack.Push(new Bitmap(_bitmap)); // empilha a imagem atual
                Graphics g = Graphics.FromImage(_bitmap);
                g.DrawLine(_pen, _startPoint, e.Location);
                _startPoint = e.Location;
                pbImgOdontograma.Invalidate();
            }
        }

        //ESCOLHER OUTRAS CORES
        private void btnColor_Click(object sender, EventArgs e)
        {
            btnUndoCircle.Visible = false;
            btnUndo.Visible = true;

            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _pen.Color = colorDialog.Color;
                btnColor.BackColor = colorDialog.Color;
            }
        }
        /////////////////////////////////////

        private void pbCircle_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.Fixed3D;
            pbPenBlue.BorderStyle = BorderStyle.Fixed3D;
            pbPenRed.BorderStyle = BorderStyle.Fixed3D;
            pbCircle.BorderStyle = BorderStyle.FixedSingle;
            btnUndoCircle.Visible = true;
            btnUndo.Visible = false;
            btnColor.Enabled = false;

            _pen.Color = Color.Green;
        }


        //ESCOLHA DAS CORES CONFORME FERRAMENTAS PEN (PRETO, AZUL, VERMELHO)
        private void pbPenBlack_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.FixedSingle;
            pbPenBlue.BorderStyle = BorderStyle.Fixed3D;
            pbPenRed.BorderStyle = BorderStyle.Fixed3D;
            pbCircle.BorderStyle = BorderStyle.Fixed3D;
            btnUndo.Visible = true;
            btnUndoCircle.Visible = false;
            btnColor.Enabled = true;

            _pen.Color = color1;
        }

        private void pbPenBlue_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.Fixed3D;
            pbPenBlue.BorderStyle = BorderStyle.FixedSingle;
            pbPenRed.BorderStyle = BorderStyle.Fixed3D;
            pbCircle.BorderStyle = BorderStyle.Fixed3D;
            btnUndo.Visible = true;
            btnUndoCircle.Visible = false;
            btnColor.Enabled = true;

            _pen.Color = color2;
        }

        private void pbPenRed_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.Fixed3D;
            pbPenBlue.BorderStyle = BorderStyle.Fixed3D;
            pbPenRed.BorderStyle = BorderStyle.FixedSingle;
            pbCircle.BorderStyle = BorderStyle.Fixed3D;
            btnUndo.Visible = true;
            btnUndoCircle.Visible = false;
            btnColor.Enabled = true;

            _pen.Color = color3;
        }
        ///////////////////////////////////////////////////////////////

        private void btnUndoCircle_Click(object sender, EventArgs e)
        {
            int numUndos = 1; // Defina o número de traços a serem desfeitos
            while (_undoStack.Count > 0 && numUndos > 0)
            {
                _bitmap = _undoStack.Pop();
                numUndos--;
            }
            pbImgOdontograma.Image = _bitmap;
            pbImgOdontograma.Invalidate();
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {
            int numUndos = 10; // Defina o número de traços a serem desfeitos
            while (_undoStack.Count > 0 && numUndos > 0)
            {
                _bitmap = _undoStack.Pop();
                numUndos--;
            }
            pbImgOdontograma.Image = _bitmap;
            pbImgOdontograma.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pbImgOdontograma.Width, pbImgOdontograma.Height);
            pbImgOdontograma.Image = _bitmap;
        }


        private void btnSalvarImagem_Click(object sender, EventArgs e)
        {
            // cria uma nova imagem Bitmap com o tamanho da pictureBox
            Bitmap bitmap = new Bitmap(pbImgOdontograma.Width, pbImgOdontograma.Height);

            // desenha a pictureBox na imagem Bitmap
            pbImgOdontograma.DrawToBitmap(bitmap, pbImgOdontograma.ClientRectangle);

            // salva a imagem Bitmap no banco de dados como um blob
            using (MemoryStream ms = new MemoryStream())


                try
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                    // salvar os dados da imagemBytes no banco de dados como um blob


                    // Conexão com o banco de dados
                    string connectionString = "Server=ACERASPIRE-5\\SQLEXPRESS; Database=Odonto; Integrated Security=True;";
                    SqlConnection connection = new SqlConnection(connectionString);

                    // Comando SQL para inserir a imagem no banco de dados
                    string sql = "INSERT INTO ODONTOGRAMA (imagem) VALUES (@imagem)";

                    // Parâmetro da imagem como byte[]
                    byte[] imageBytes = ms.ToArray();

                    // Cria um comando SQL com o parâmetro da imagem
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@imagem", imageBytes);

                    // Abre a conexão com o banco de dados e executa o comando
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível salvar a imagem");

                    throw;
                }
        }

        private void pbImgOdontograma_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbCircle.BorderStyle == BorderStyle.FixedSingle)
            {
                _undoStack.Push(new Bitmap(_bitmap)); // empilha a imagem atual
                Graphics g = Graphics.FromImage(_bitmap);
                int diameter = 7; // definir o diâmetro do círculo
                int x = e.X - diameter / 2;
                int y = e.Y - diameter / 2;
                g.DrawEllipse(_pen, x, y, diameter, diameter);
                pbImgOdontograma.Invalidate();
            }
        }

        private void FrmOdontograma_Load(object sender, EventArgs e)
        {
            _areas.Add(new Rectangle(100, 100, 500, 500));  // Exemplo de área retangular
            _areas.Add(new Rectangle(200, 200, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(300, 300, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(400, 400, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(500, 500, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(600, 600, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(700, 700, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(800, 800, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(900, 900, 300, 300));  // Outro exemplo de área retangular
            _areas.Add(new Rectangle(1000, 1000, 300, 300));  // Outro exemplo de área retangular
                                                          // Adicione mais áreas conforme necessário



            _checkboxes.Add(checkBox18); //
            _checkboxes.Add(checkBox17); //
            _checkboxes.Add(checkBox16); //
            _checkboxes.Add(checkBox15); //SUPERIORES DIR.
            _checkboxes.Add(checkBox14); //
            _checkboxes.Add(checkBox13); //
            _checkboxes.Add(checkBox12); //
            _checkboxes.Add(checkBox11); //

            _checkboxes.Add(checkBox21); //
            _checkboxes.Add(checkBox22); //
            _checkboxes.Add(checkBox23); //
            _checkboxes.Add(checkBox24); //SUPERIORES ESQ.
            _checkboxes.Add(checkBox25); //
            _checkboxes.Add(checkBox26); //
            _checkboxes.Add(checkBox27); //
            _checkboxes.Add(checkBox28); //

            _checkboxes.Add(checkBox48); //
            _checkboxes.Add(checkBox47); //
            _checkboxes.Add(checkBox46); //
            _checkboxes.Add(checkBox45); //INFERIORES ESQ.
            _checkboxes.Add(checkBox44); //
            _checkboxes.Add(checkBox43); // 
            _checkboxes.Add(checkBox42); //
            _checkboxes.Add(checkBox41); //

            _checkboxes.Add(checkBox31); //
            _checkboxes.Add(checkBox32); //
            _checkboxes.Add(checkBox33); //
            _checkboxes.Add(checkBox34); //INFERIORES DIR.
            _checkboxes.Add(checkBox35); //
            _checkboxes.Add(checkBox36); // 
            _checkboxes.Add(checkBox37); //
            _checkboxes.Add(checkBox38); //

            
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (System.Windows.Forms.CheckBox checkBox in _checkboxes)
            {
                if (checkBox.Checked)
                {
                    count++;
                }
            }



            int index = _checkboxes.FindIndex(cb => cb.Checked);
            for (int i = 0; i < count; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(565, 235 + i * 30);
                textBox.Size = new Size(22, 20);
                textBox.Text = _checkboxes[index + i].Name.Replace("checkBox", "");
                this.Controls.Add(textBox);
            }

        }

        private void btnFecharFichaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxElementos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Limpa a cboxFaces
            cboxFaces.Items.Clear();

            // Verifica o valor selecionado na cboxElementos
            switch (cboxElementos.SelectedItem.ToString())
            {
                case "11":
                case "12":
                case "13":
                case "21":
                case "22":
                case "23":
                    cboxFaces.Items.Add("Mesial");
                    cboxFaces.Items.Add("Distal");
                    cboxFaces.Items.Add("Vestibular");
                    cboxFaces.Items.Add("Palatina");
                    break;

                case "31":
                case "32":
                case "33":
                case "41":
                case "42":
                case "43":
                    cboxFaces.Items.Add("Mesial");
                    cboxFaces.Items.Add("Distal");
                    cboxFaces.Items.Add("Vestibular");
                    cboxFaces.Items.Add("Lingual");
                    break;

                case "14":
                case "15":
                case "16":
                case "17":
                case "18":
                case "24":
                case "25":
                case "26":
                case "27":
                case "28":
                    cboxFaces.Items.Add("Mesial");
                    cboxFaces.Items.Add("Distal");
                    cboxFaces.Items.Add("Vestibular");
                    cboxFaces.Items.Add("Palatina");
                    cboxFaces.Items.Add("Oclusal");
                    break;

                case "34":
                case "35":
                case "36":
                case "37":
                case "38":
                case "44":
                case "45":
                case "46":
                case "47":
                case "48":
                    cboxFaces.Items.Add("Mesial");
                    cboxFaces.Items.Add("Distal");
                    cboxFaces.Items.Add("Vestibular");
                    cboxFaces.Items.Add("Lingual");
                    cboxFaces.Items.Add("Oclusal");
                    break;

                default:
                    // Adiciona um valor padrão na cboxFaces
                    cboxFaces.Items.Add("Selecione o Elemento");
                    break;
            }

        }

       

        private void cboxEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxEspecialidade.SelectedItem.ToString())
            {
                case "CIRURGIA":
                    cboxProcedimento.Items.Add("Acompanhamento de tratamento/procedimento cirúrgico em odontologia");
                    cboxProcedimento.Items.Add("Alveoloplastia - por segmento");
                    cboxProcedimento.Items.Add("Amputação Radicular com Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Amputação Radicular sem Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Apicetomia Birradiculares com Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Apicetomia Birradiculares sem Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Apicetomia Multirradiculares com Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Apicetomia Multirradiculares sem Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Apicetomia Unirradiculares com Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Apicetomia Unirradiculares sem Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Aprofundamento/Aumento de Vestíbulo (Sulcoplastia) – por arcada");
                    cboxProcedimento.Items.Add("Biópsia de Boca");
                    cboxProcedimento.Items.Add("Biópsia de Glândula Salivar");
                    cboxProcedimento.Items.Add("Biópsia de Lábio");
                    cboxProcedimento.Items.Add("Biópsia de Língua");
                    cboxProcedimento.Items.Add("Biópsia de Mandíbula");
                    cboxProcedimento.Items.Add("Biópsia de Maxila");
                    cboxProcedimento.Items.Add("Bridectomia - por arcada");
                    cboxProcedimento.Items.Add("Bridotomia - por arcada");
                    cboxProcedimento.Items.Add("Cirurgia Odontológica a Retalho");
                    cboxProcedimento.Items.Add("Cirurgia para exostose maxilar");
                    cboxProcedimento.Items.Add("Cirurgia para Tôrus Mandibular – Bilateral");
                    cboxProcedimento.Items.Add("Cirurgia para Tôrus Mandibular - Unilateral");
                    cboxProcedimento.Items.Add("Cirurgia para Tôrus Palatinio");
                    cboxProcedimento.Items.Add("Controle Pós-operatório em Odontologia");
                    cboxProcedimento.Items.Add("Curetagem Apical");
                    cboxProcedimento.Items.Add("Diagnóstico por Meio de Enceramento");
                    cboxProcedimento.Items.Add("Exérese de Lipoma na região buco-maxilo facial");
                    cboxProcedimento.Items.Add("Exérese de Tumor Benigno, Cisto ou Fístula");
                    cboxProcedimento.Items.Add("Exérese ou Excisão de Cálculo Salivar");
                    cboxProcedimento.Items.Add("Exérese ou Excisão de Cistos Odontológicos");
                    cboxProcedimento.Items.Add("Exérese ou Excisão de Mucocele");
                    cboxProcedimento.Items.Add("Exérese ou Excisão de Rânula");
                    cboxProcedimento.Items.Add("Exodontia a Retalho");
                    cboxProcedimento.Items.Add("Exodontia de Permanente por Indicação Ortodôntica/protética");
                    cboxProcedimento.Items.Add("Exodontia de Raiz Residual");
                    cboxProcedimento.Items.Add("Exodontia de incluso/impactado supra numerário");
                    cboxProcedimento.Items.Add("Exodontia de semi-incluso/impactado supra numerário");
                    cboxProcedimento.Items.Add("Exodontia Simples de Decíduo");
                    cboxProcedimento.Items.Add("Exodontia Simples de Permanente");
                    cboxProcedimento.Items.Add("Frenulectomia Lingual");
                    cboxProcedimento.Items.Add("Frenulectonia Labial");
                    cboxProcedimento.Items.Add("Frenulotomia Labial");
                    cboxProcedimento.Items.Add("Frenulotomia Lingual");
                    break;

                default:
                    // Adiciona um valor padrão na cboxFaces
                    cboxProcedimento.Items.Add("Selecione a Especialidade");
                    break;
            }

        }

        private void cboxEspecialidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        






        ////////////////////////////////////////////////////////////

        ////CONSULTA DA IMAGEM NO BANCO
        //private void btnConsultarImagem_Click(object sender, EventArgs e)
        //{
        //    // Conexão com o banco de dados
        //    string connectionString = "Server=ACERASPIRE-5\\SQLEXPRESS; Database=Odonto; Integrated Security=True;";
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    // Comando SQL para selecionar a imagem do banco de dados
        //    string sql = "SELECT imagem FROM ODONTOGRAMA WHERE ID_ODONTOGRAMA = @ID";

        //    // ID da imagem a ser recuperada
        //    int imageID = 1;

        //    // Cria um comando SQL com o parâmetro do ID da imagem
        //    SqlCommand command = new SqlCommand(sql, connection);
        //    command.Parameters.AddWithValue("@ID", imageID);

        //    // Abre a conexão com o banco de dados e executa o comando
        //    connection.Open();

        //    // Lê os dados da imagem do banco de dados como um array de bytes
        //    byte[] imageBytes = (byte[])command.ExecuteScalar();

        //    // Fecha a conexão com o banco de dados
        //    connection.Close();

        //    // Cria um objeto MemoryStream a partir dos bytes da imagem
        //    using (MemoryStream ms = new MemoryStream(imageBytes))
        //    {
        //        // Cria um objeto Bitmap a partir do MemoryStream
        //        Bitmap bitmap = new Bitmap(ms);

        //        // Exibe o Bitmap na PictureBox
        //        pbImgOdontograma.Image = bitmap;
        //    }

    }   //}
                
}
