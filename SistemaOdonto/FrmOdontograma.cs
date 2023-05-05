using Entidades;
using SistemaOdonto.WSCorreios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SistemaOdonto
{
    public partial class FrmOdontograma : Form
    {
        DentistaService serviceD = new DentistaService();

        OdontogramaService serviceOdt = new OdontogramaService();
        ProcedimentoService serviceProcd = new ProcedimentoService();

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

        // dicionário para mapear as checkboxes aos retângulos
        private Dictionary<System.Windows.Forms.CheckBox, Rectangle> retangulosCheckbox = new Dictionary<System.Windows.Forms.CheckBox, Rectangle>();

        //dicionário para mapear as checkboxes
        private Dictionary<string, System.Windows.Forms.CheckBox> elementoCheckboxMap = new Dictionary<string, System.Windows.Forms.CheckBox>();



        public FrmOdontograma()
        {
            InitializeComponent();
            ListarDentistas();
            _pen = new Pen(Color.Black, 2);
            _bitmap = new Bitmap(pbImgOdontograma.Width, pbImgOdontograma.Height);
            pbImgOdontograma.Image = _bitmap;
            Stack<Bitmap> undoStack = new Stack<Bitmap>();

            btnUndoCircle.Visible = false;
            btnUndo.Visible = false;
            btnColor.Enabled = false;

            elementoCheckboxMap["11"] = checkBox11;
            elementoCheckboxMap["12"] = checkBox12;
            elementoCheckboxMap["13"] = checkBox13;
            elementoCheckboxMap["14"] = checkBox14;
            elementoCheckboxMap["15"] = checkBox15;
            elementoCheckboxMap["16"] = checkBox16;
            elementoCheckboxMap["17"] = checkBox17;
            elementoCheckboxMap["18"] = checkBox18;
            elementoCheckboxMap["21"] = checkBox21;
            elementoCheckboxMap["22"] = checkBox22;
            elementoCheckboxMap["23"] = checkBox23;
            elementoCheckboxMap["24"] = checkBox24;
            elementoCheckboxMap["25"] = checkBox25;
            elementoCheckboxMap["26"] = checkBox26;
            elementoCheckboxMap["27"] = checkBox27;
            elementoCheckboxMap["28"] = checkBox28;
            elementoCheckboxMap["31"] = checkBox31;
            elementoCheckboxMap["32"] = checkBox32;
            elementoCheckboxMap["33"] = checkBox33;
            elementoCheckboxMap["34"] = checkBox34;
            elementoCheckboxMap["35"] = checkBox35;
            elementoCheckboxMap["36"] = checkBox36;
            elementoCheckboxMap["37"] = checkBox37;
            elementoCheckboxMap["38"] = checkBox38;
            elementoCheckboxMap["41"] = checkBox41;
            elementoCheckboxMap["42"] = checkBox42;
            elementoCheckboxMap["43"] = checkBox43;
            elementoCheckboxMap["44"] = checkBox44;
            elementoCheckboxMap["45"] = checkBox45;
            elementoCheckboxMap["46"] = checkBox46;
            elementoCheckboxMap["47"] = checkBox47;
            elementoCheckboxMap["48"] = checkBox48;            
        }

        private void FrmOdontograma_Load(object sender, EventArgs e)
        {
            // Exibir caixa de diálogo com instruções
            MessageBox.Show("Bem-vindo ao Odontograma!" +
                "\n\nInstruções de como preencher corretamente os Procedimentos:" +
                "\n\n1. Selecione o checkbox do Elemento desejado no canto superior direito." +
                "\n\n2. No quadro de Procedimentos Selecione o Dentista." +
                "\n\n3. Selecione a Face do Elemento, a Especialidade e selecione ou digite o Procedimento." +
                "\n\n4. Clique no botão + para adicionar o Procedimento na lista." +
                "\n\n5. Repita o processo para cada Elemento." +
                "\n\n6. Na imagem de Odontograma do quadro esquerdo faça as anotações necessárias." +
                "\n\n7. Para salvar as informações: Clique em Salvar Odontograma." +
                "", "Instruções para Preenchimento dos Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ListarDentistas()
        {
            try
            {
                var lista = serviceD.Listar();
                var listaD = new Dictionary<int, string>();
                listaD.Add(0, "Selecione um Dentista");
                foreach (var item in lista)
                {
                    listaD.Add(item.Id, item.Nome);
                }
                cboxDentista.DataSource = new BindingSource(listaD, null);
                cboxDentista.DisplayMember = "value";
                cboxDentista.ValueMember = "key";
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }
        }



        // Função para gerar a imagem combinada
        byte[] GerarImagem(PictureBox pictureBox)
        {
            // Cria uma nova imagem Bitmap com o tamanho da pictureBox
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Desenha a pictureBox na imagem Bitmap
            pictureBox.DrawToBitmap(bitmap, pictureBox.ClientRectangle);

            // Converte a imagem Bitmap em um array de bytes
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Jpeg); // Escolha o formato de imagem adequado

                return ms.ToArray();
            }
        }

        private void pbImgOdontograma_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbCircle.BorderStyle == BorderStyle.FixedSingle)
            {
                _undoStack.Push(new Bitmap(_bitmap)); // empilha a imagem atual
                Graphics g = Graphics.FromImage(_bitmap);
                int diameter = 8; // definir o diâmetro do círculo
                int x = e.X - diameter / 2;
                int y = e.Y - diameter / 2;
                g.DrawEllipse(_pen, x, y, diameter, diameter);
                pbImgOdontograma.Invalidate();
            }
        }


        private void pbImgOdontograma_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
        }

        private void pbImgOdontograma_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;           
        }


        private void pbImgOdontograma_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing && pbCircle.BorderStyle == BorderStyle.FixedSingle)
            {
                _undoStack.Push(new Bitmap(_bitmap)); // empilha a imagem atual
                Graphics g = Graphics.FromImage(_bitmap);
                g.DrawEllipse(_pen, _startPoint.X, _startPoint.Y, e.X - _startPoint.X, e.Y - _startPoint.Y);                

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

        private void pbImgOdontograma_Paint(object sender, PaintEventArgs e)
        {
            foreach (var kvp in retangulosCheckbox)
            {
                System.Windows.Forms.CheckBox checkbox = kvp.Key;
                Rectangle retangulo = kvp.Value;

                if (checkbox.Checked)
                {
                    using (Pen pen = new Pen(Color.Black, 1))
                    {
                        e.Graphics.DrawRectangle(pen, retangulo);
                    }
                }
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
                catch (System.Exception)
                {
                    MessageBox.Show("Não foi possível salvar a imagem");

                    throw;
                }
        }

        

        private void btnFecharFichaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxElementos_SelectedIndexChanged(object sender, EventArgs e)
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
                    cboxFaces.Items.Add("Não informado");
                    break;
            }
        }

        private void cboxEspecialidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void cboxEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa a cboxProcedimentos
            cboxProcedimento.Items.Clear();

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
                    cboxProcedimento.Items.Add("Marsupialização de Cistos Odontológicos ");
                    cboxProcedimento.Items.Add("Odonto-Secção");
                    cboxProcedimento.Items.Add("Placa de Contenção Cirúrgica");
                    cboxProcedimento.Items.Add("Punção Aspirativa na Região Buco-maxilo-facial");            
                    cboxProcedimento.Items.Add("Redução Cruenta de Fratura Alvéolo Dentária");
                    cboxProcedimento.Items.Add("Redução Incruenta de Fratura Alvéolo-Dentária ");
                    cboxProcedimento.Items.Add("Remoção de Dentes Inclusos / Impactados");
                    cboxProcedimento.Items.Add("Remoção de Dentes Semi-inclusos / impactados");
                    cboxProcedimento.Items.Add("Remoção de Odontoma - Tumores Intra Ósseos");
                    cboxProcedimento.Items.Add("Retirada de corpo estranho oroantral ou aronasal da região buco-maxilo facial");
                    cboxProcedimento.Items.Add("Sepultamento Radicula");
                    cboxProcedimento.Items.Add("Tracionamento Cirúrgico com Finalidade Ortodôntica");
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico das Fístulas Buco-nasal");
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico das Fístulas Buco-sinusal");
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico de Bridas Constritivas da Região Buco-maxilo-facial");
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico de Hiperplasias de Tecidos Moles na Região Buco-maxilo-facial");
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico de Hiperplasias de Tecidos Ósseos / Cartilaginosos na Região Buco - maxilo - facial");            
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico de Tumores Benignos de Tecidos Ósseos / Cartilaginosos na Região Buco - maxilo - facial");            
                    cboxProcedimento.Items.Add("ratamento Cirúrgico dos Tumores Benignos de Tecidos Moles na Região Bucomaxilo-facia");
                    cboxProcedimento.Items.Add("Tratamento Cirúrgico para Tumores Odontogênicos Benignos - sem reconstrução");
                    cboxProcedimento.Items.Add("Tratamento conservador de luxação da articulação temporo mandibular (ATM)");
                    cboxProcedimento.Items.Add("Ulectomia");
                    cboxProcedimento.Items.Add("Ulotomia");
                    break;

                case "CONDICIONAMENTO":
                    cboxProcedimento.Items.Add("Condicionamento em Odontologia (máximo 03 sessões por ano");
                    cboxProcedimento.Items.Add("Condicionamento em Odontologia para pacientes com necessidades especiais");
                    cboxProcedimento.Items.Add("Estabilização de Paciente por Meio de Contenção Física e/ou Mecânica");
                    cboxProcedimento.Items.Add("Estabilização de Paciente por Meio de Contenção Física e/ou Mecânica em pacientes com necessidades especiais em odontologia");
                    break;

                case "DENTÍSTICA":
                    cboxProcedimento.Items.Add("Adequação do meio bucal");
                    cboxProcedimento.Items.Add("Clareamento de Dente Desvitalizado");
                    cboxProcedimento.Items.Add("Clareamento Dentário Caseiro - por arcada");
                    cboxProcedimento.Items.Add("Clareamento Dentário em Consultório - por arcada");
                    cboxProcedimento.Items.Add("Controle de cárie incipiente");
                    cboxProcedimento.Items.Add("Faceta Direta em Resina Fotopolimerizável ");
                    cboxProcedimento.Items.Add("Núcleo de Preenchimento");
                    cboxProcedimento.Items.Add("Placa de Acetato para Clareamento Caseiro");
                    cboxProcedimento.Items.Add("Restauração Atraumática em Dente Decíduo");
                    cboxProcedimento.Items.Add("Restauração Atraumática em Dente Permanente");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 1 face");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 2 faces");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 3 faces ");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 4 faces");
                    cboxProcedimento.Items.Add("Restauração de Amálgama - 4 faces");
                    cboxProcedimento.Items.Add("Restauração de Amálgama - 1 face");
                    cboxProcedimento.Items.Add("Restauração de Amálgama - 2 faces");
                    cboxProcedimento.Items.Add("Restauração de Amálgama - 3 faces");
                    cboxProcedimento.Items.Add("Restauração em Resina Fotopolimerizável 1 face");
                    cboxProcedimento.Items.Add("Restauração em Resina Fotopolimerizável 2 faces");
                    cboxProcedimento.Items.Add("Restauração em Resina Fotopolimerizável 3 faces");
                    cboxProcedimento.Items.Add("Restauração em Resina Fotopolimerizável 4 faces / ângulo");
                    cboxProcedimento.Items.Add("Restauração Temporária/Tratamento Expectante");
                    break;

                case "DIAGNÓSTICO":
                    cboxProcedimento.Items.Add("Consulta Odontológica");
                    cboxProcedimento.Items.Add("Consulta Odontológica de Urgência (tratamento de odontalgia aguda)");
                    cboxProcedimento.Items.Add("Consulta Odontológica de Urgência 24 horas ");
                    cboxProcedimento.Items.Add("Consulta Odontológica Inicial ");
                    cboxProcedimento.Items.Add("Consulta Odontológica para Avaliação Técnica de Auditoria ");
                    break;

                case "ENDODONTIA":
                    cboxProcedimento.Items.Add("Capeamento Pulpar Direto ");
                    cboxProcedimento.Items.Add("Curativo de Demora em Endodontia - incluído nos procedimentos de Tratamentos Endodônticos");            
                    cboxProcedimento.Items.Add("Pulpectomia ");
                    cboxProcedimento.Items.Add("Pulpotomia ");
                    cboxProcedimento.Items.Add("Pulpotomia em dente decíduo");
                    cboxProcedimento.Items.Add("Remoção de Corpo Estranho Intra-Canal ");
                    cboxProcedimento.Items.Add("Remoção de Material Obturador Intracanal para Retratamento Endodôntico - incluído nos procedimentos de retratamento");            
                    cboxProcedimento.Items.Add("Remoção de Núcleo Intra-Radicular ");
                    cboxProcedimento.Items.Add("Remoção deTrabalho Protético ");
                    cboxProcedimento.Items.Add("Retratamento Endodôntico Birradicular");
                    cboxProcedimento.Items.Add("Retratamento Endodôntico Multirradicular");
                    cboxProcedimento.Items.Add("Retratamento Endodôntico Unirradicular");
                    cboxProcedimento.Items.Add("Tratamento de Perfuração Endodôntica");
                    cboxProcedimento.Items.Add("Tratamento Endodôntico Birradicular");
                    cboxProcedimento.Items.Add("Tratamento Endodôntico de Dente com Rizogênese Incompleta");
                    cboxProcedimento.Items.Add("Tratamento Endodôntico em Dente Decíduo");
                    cboxProcedimento.Items.Add("Tratamento Endodôntico Multirradicular");
                    cboxProcedimento.Items.Add("Tratamento Endodôntico Unirradicular");

                    break;

                case "IMPLANTODONTIA":
                    cboxProcedimento.Items.Add("Cirurgia Odontológica com Aplicação de Aloenxertos");
                    cboxProcedimento.Items.Add("Coroa Provisória sobre Implante ");
                    cboxProcedimento.Items.Add("Coroa Total Acrilica Prensada ");
                    cboxProcedimento.Items.Add("Coroa Total Livre de Metal (metalfree) sobre Iimplante - Cerâmica ");
                    cboxProcedimento.Items.Add("Coroa Total Metalo Cerâmica sobre Implante");
                    cboxProcedimento.Items.Add("Coroa Total Metalo Plástica sobre Implante - Resina Acrílica");
                    cboxProcedimento.Items.Add("Coroa Total Metalo Plástica sobre Implante - Resina Acrílica");
                    cboxProcedimento.Items.Add("Enxerto com osso autógeno do mento ");
                    cboxProcedimento.Items.Add("Guia Cirúrgico para Implante - por arcada ");
                    cboxProcedimento.Items.Add("Implante Ortodôntico - por unidade + peça");
                    cboxProcedimento.Items.Add("Implante Ósseo Integrado - por unidade + peça ");
                    cboxProcedimento.Items.Add("Intermediário Sobre Implante");
                    cboxProcedimento.Items.Add("Levantamento de Seio Maxilar (2 Dentes) ");
                    cboxProcedimento.Items.Add("Overdenture (Dois Implantes) ");
                    cboxProcedimento.Items.Add("Overdenture (Quatro Implantes)");
                    cboxProcedimento.Items.Add("Prótese Protocolo ( Quatro Implantes) ");
                    cboxProcedimento.Items.Add("Prótese Protocolo (Cinco Implantes) ");

                    break;

                case "ODONTOPEDIATRIA":
                    cboxProcedimento.Items.Add("Aplicação de Cariostático - arcada superior + inferior");
                    cboxProcedimento.Items.Add("Aplicação de selante - técnica invasiva ");
                    cboxProcedimento.Items.Add("Aplicação de Selante de Fóssulas e Fissuras - por elemento ");
                    cboxProcedimento.Items.Add("Aplicação Tópica de Verniz Fluoretado");
                    cboxProcedimento.Items.Add("Condicionamento em Odontologia (máximo 03 sessões por ano) ");
                    cboxProcedimento.Items.Add("Condicionamento em Odontologia para pacientes com necessidades especiais");
                    cboxProcedimento.Items.Add("Coroa de Acetato em Dente Decíduo");
                    cboxProcedimento.Items.Add("Coroa de Acetato em Dente Permanente");
                    cboxProcedimento.Items.Add("Coroa de Aço em Dente Decíduo ");
                    cboxProcedimento.Items.Add("Coroa de Aço em Dente Permanente ");
                    cboxProcedimento.Items.Add("Coroa de Policarbonato em Dente Decíduo");
                    cboxProcedimento.Items.Add("Coroa de Policarbonato em Dente Permanente");
                    cboxProcedimento.Items.Add("Exodontia Simples de Decíduo");
                    cboxProcedimento.Items.Add("Mantenedor de espaço fixo ");
                    cboxProcedimento.Items.Add("Mantenedor de espaço removível ");
                    cboxProcedimento.Items.Add("Plano Inclinado");
                    cboxProcedimento.Items.Add("Pulpotomia em dente decíduo");
                    cboxProcedimento.Items.Add("Remineralização Dentária ");
                    cboxProcedimento.Items.Add("Restauração Atraumática em Dente Decíduo ");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 4 faces");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 1 face");
                    cboxProcedimento.Items.Add("Restauração em Ionômero de Vidro - 2 faces ");
                    break;

                case "ORTODONTIA":
                    cboxProcedimento.Items.Add("Aparelho Extra Bucal ");
                    cboxProcedimento.Items.Add("Aparelho Ortodôntico Fixo Metálico - por aparelho");
                    cboxProcedimento.Items.Add("Aparelho Ortodôntico Fixo metálico Parcial - por aparelho ");
                    cboxProcedimento.Items.Add("Arco Lingual");
                    cboxProcedimento.Items.Add("Bionator de Balters");
                    cboxProcedimento.Items.Add("Contenção Fixa - por Arcada");
                    cboxProcedimento.Items.Add("Disjuntor Palatino - Hirax ");
                    cboxProcedimento.Items.Add("Disjuntor Palatino - Macnamara");
                    cboxProcedimento.Items.Add("Grade Palatina Fixa");
                    cboxProcedimento.Items.Add("Grade Palatina Removível");
                    cboxProcedimento.Items.Add("Mantenedor de espaço fixo");
                    cboxProcedimento.Items.Add("Mantenedor de espaço removível");
                    cboxProcedimento.Items.Add("Manutenção de Aparelho Ortodôntico - Aparelho Fixo - controle mensal");
                    cboxProcedimento.Items.Add("Manutenção de Aparelho Ortodôntico - Aparelho Removível - controle mensal ");
                    cboxProcedimento.Items.Add("Mascara Facial - Delaire e Tração Reversa ");
                    cboxProcedimento.Items.Add("Mentoneira");
                    cboxProcedimento.Items.Add("Placa de Haley ");
                    cboxProcedimento.Items.Add("Placa de Haley - com torno expansor");
                    cboxProcedimento.Items.Add("Placa de Mordida Ortodôntica ");
                    cboxProcedimento.Items.Add("Placa Labio-ativa");
                    cboxProcedimento.Items.Add("Plano Inclinado ");
                    cboxProcedimento.Items.Add("Quadri-Hélice ");
                    cboxProcedimento.Items.Add("Aparelho de Klammt");
                    cboxProcedimento.Items.Add("Aparelho de Thurow ");
                    cboxProcedimento.Items.Add("Aparelho removível com alças bionator invertida ou de Escheler");
                    cboxProcedimento.Items.Add("APM - Aparelho de Protração Mandibular ");
                    cboxProcedimento.Items.Add("Barra transpalatina removível ");
                    cboxProcedimento.Items.Add("Blocos geminados de Clark – twinblock ");
                    cboxProcedimento.Items.Add("Botão de Nance ");
                    cboxProcedimento.Items.Add("Barra transpalatina fixa");
                    cboxProcedimento.Items.Add("Distalizador com mola nitinol ");
                    cboxProcedimento.Items.Add("Distalizador de Hilgers ");
                    cboxProcedimento.Items.Add("Distalizador Distal Jet");
                    cboxProcedimento.Items.Add("Distalizador Pendulo/Pendex");
                    cboxProcedimento.Items.Add("Distalizador tipo Jones Jig ");
                    cboxProcedimento.Items.Add("Gianelly ");
                    cboxProcedimento.Items.Add("Manutenção de aparelho ortodôntico - aparelho ortopédico");
                    cboxProcedimento.Items.Add("Modelador elástico de Bimler");
                    cboxProcedimento.Items.Add("Monobloco ");
                    cboxProcedimento.Items.Add("Pistas diretas de Planas - superior e inferior");
                    cboxProcedimento.Items.Add("Pistas indiretas de Planas ");
                    cboxProcedimento.Items.Add("Placa de distalização de molares");
                    cboxProcedimento.Items.Add("Placa de verticalização de caninos ");
                    cboxProcedimento.Items.Add("Placa dupla de Sanders ");
                    cboxProcedimento.Items.Add("Placa encapsulada de Maurício");
                    cboxProcedimento.Items.Add("Plano anterior fixo ");
                    cboxProcedimento.Items.Add("Regulador de função de Frankel");
                    cboxProcedimento.Items.Add("Simões Network ");
                    cboxProcedimento.Items.Add("Splinter ");
                    cboxProcedimento.Items.Add("Herbst encapsulado");
                    break;

                case "PERIODONTIA":
                    cboxProcedimento.Items.Add("Ajuste Oclusal por Acréscimo - incluído nos procedimentos de restauração e prótese");
                    cboxProcedimento.Items.Add("Ajuste Oclusal por desgaste seletivo - incluído nos procedimentos de restauração e prótese");            
                    cboxProcedimento.Items.Add("Amputação Radicular com Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Amputação Radicular sem Obturação Retrógrada");
                    cboxProcedimento.Items.Add("Aumento de Coroa Clínica ");
                    cboxProcedimento.Items.Add("Cirurgia Odontológica a Retalho ");
                    cboxProcedimento.Items.Add("Cirurgia Periodontal a Retalho - por segmento");
                    cboxProcedimento.Items.Add("Cunha Proximal ");
                    cboxProcedimento.Items.Add("Dessensibilização Dentária - incluído no procedimento aplicação de verniz fluoretado");
                    cboxProcedimento.Items.Add("Enxerto c/ Osso Liofilizado");
                    cboxProcedimento.Items.Add("Enxerto Conjuntivo Subepitelial - por elemento");
                    cboxProcedimento.Items.Add("Enxerto Gengival Livre - por segmento");
                    cboxProcedimento.Items.Add("Enxerto Pediculado - por segmento");
                    cboxProcedimento.Items.Add("Gengivectomia - por segmento");
                    cboxProcedimento.Items.Add("Gengivoplastia - por segmento");
                    cboxProcedimento.Items.Add("Manutenção Periodontal ");
                    cboxProcedimento.Items.Add("Odontosecção ");
                    cboxProcedimento.Items.Add("Ortese miorelaxante (Placa Oclusal Estabilizadora");
                    cboxProcedimento.Items.Add("Placa Oclusal Resiliente = placa miorelaxante ");
                    cboxProcedimento.Items.Add("Raspagem Sub-gengival e Alisamento Radicular (incluído Curetagem de BolsaPeriodontal) - por SEXTANTE");
                    cboxProcedimento.Items.Add("Raspagem Supra-gengival (incluído Polimento Coronário) – por SEXTANTE");
                    cboxProcedimento.Items.Add("Remoção dos Fatores de Retenção do Biofilme Dental (Placa Bacteriana) - incluído nos procedimentos de profilaxia, restaurações e próteses");            
                    cboxProcedimento.Items.Add("Sepultamento Radicular");
                    cboxProcedimento.Items.Add("Tratamento de Fluorose - microabrasão");
                    cboxProcedimento.Items.Add("Tratamento de Gengivite Necrosante Aguda (GUNA ) (por sessão) ");
                    cboxProcedimento.Items.Add("Tunelização");
                    break;

                case "PROTESE":
                    cboxProcedimento.Items.Add("Conserto de prótese parcial removível (em consultório e em laboratório) ");
                    cboxProcedimento.Items.Add("Conserto de prótese parcial removível (exclusivamente em consultório) ");
                    cboxProcedimento.Items.Add("Conserto de prótese total (em consultório e em laboratório) ");
                    cboxProcedimento.Items.Add("Conserto de prótese total (exclusivamente em consultório)");
                    cboxProcedimento.Items.Add("Coroa de Acetato em Dente Decíduo");
                    cboxProcedimento.Items.Add("Coroa de Acetato em Dente Permanente ");
                    cboxProcedimento.Items.Add("Coroa de Aço em Dente Decíduo");
                    cboxProcedimento.Items.Add("Coroa de Aço em Dente Permanente");
                    cboxProcedimento.Items.Add("Coroa de Policarbonato em Dente Decíduo");
                    cboxProcedimento.Items.Add("Coroa de Policarbonato em Dente Permanente");
                    cboxProcedimento.Items.Add("Coroa Provisória com Pino");
                    cboxProcedimento.Items.Add("Coroa Provisória sem Pino");
                    cboxProcedimento.Items.Add("Coroa Total Acrílica Prensada");
                    cboxProcedimento.Items.Add("Coroa Total em Cerâmica Pura ");
                    cboxProcedimento.Items.Add("Coroa Total em Cerômero – inclui a peça protética");
                    cboxProcedimento.Items.Add("Coroa Total Metálica - inclui a peça protética ");
                    cboxProcedimento.Items.Add("Coroa Total Metalo Cerâmica ");
                    cboxProcedimento.Items.Add("Coroa Total Metalo-Plástica - Resina Acrílica ");
                    cboxProcedimento.Items.Add("Faceta em Cerâmica Pura");
                    cboxProcedimento.Items.Add("Faceta em Cerômero");
                    cboxProcedimento.Items.Add("Guia Cirúrgico para Prótese Imediata ");
                    cboxProcedimento.Items.Add("Núcleo de Preenchimento");
                    cboxProcedimento.Items.Add("Núcleo Metálico Fundido - inclui a peça protética ");
                    cboxProcedimento.Items.Add("Onlay de Resina Indireta");
                    cboxProcedimento.Items.Add("Pino Pré Fabricado");
                    cboxProcedimento.Items.Add("Planejamento de Prótese");
                    cboxProcedimento.Items.Add("Preparo para Núcleo Intrarradicular - incluído no procedimento núcleo metálico fundido - 85400220");            
                    cboxProcedimento.Items.Add("Prótese Fixa Adesiva Direta (provisória");
                    cboxProcedimento.Items.Add("Prótese Fixa Adesiva em Cerômero Livre de Metal (metal free");
                    cboxProcedimento.Items.Add("Prótese Fixa Adesiva Indireta em Metálo Cerâmica - 3 elementos");
                    cboxProcedimento.Items.Add("Prótese Fixa Adesiva Indireta em Metalo-Plástica - 3 elementos");
                    cboxProcedimento.Items.Add("Prótese Parcial Fixa em Metálo Cerâmica - por elemento ");
                    cboxProcedimento.Items.Add("Prótese Parcial Fixa em Metálo Plástica - por elemento ");
                    cboxProcedimento.Items.Add("Prótese Parcial Removível com Grampos Bilateral ");
                    cboxProcedimento.Items.Add("Prótese Parcial Removível com Encaixes de Precisão ou Semi Precisão");
                    cboxProcedimento.Items.Add("Prótese Parcial Removível Provisória em Acrílico com ou sem Grampos ");
                    cboxProcedimento.Items.Add("Prótese Total - Superior ou Inferior");
                    cboxProcedimento.Items.Add("Prótese Total Imediata - Superior ou Inferior");
                    cboxProcedimento.Items.Add("Prótese Total Incolor - Superior ou Inferior");
                    cboxProcedimento.Items.Add("Provisório para Faceta - incluído no procedimento de Restauração com Faceta");
                    cboxProcedimento.Items.Add("Provisório para Inlay/Onlay - incluído nos procedimentos de Restauração Inlay / Onlay");
                    cboxProcedimento.Items.Add("Provisório para Restauração Metálica Fundida (RMF) - incluído no procedimento de RMF");            
                    cboxProcedimento.Items.Add("Reembasamento de Coroa Provisória");
                    cboxProcedimento.Items.Add("Reembasamento de Prótese Total ou Parcial - Imediato (em Consultório)");
                    cboxProcedimento.Items.Add("Reembasamento de Prótese Total ou Parcial - Mediato (em Laboratório)");
                    cboxProcedimento.Items.Add("Remoção de Núcleo Intra-Radicular ");
                    cboxProcedimento.Items.Add("Remoção deTrabalho Protético");
                    cboxProcedimento.Items.Add("Restauração em Resina (indireta) - Inlay");
                    cboxProcedimento.Items.Add("Restauração em Cerâmica Pura - Inlay");
                    cboxProcedimento.Items.Add("Restauração em Cerâmica Pura - Onlay");
                    cboxProcedimento.Items.Add("Restauração em Cerômero - Inlay");
                    cboxProcedimento.Items.Add("Restauração em Cerômero - Onlay ");
                    cboxProcedimento.Items.Add("Restauração Metálica Fundida - inclui a peça protética");
                    break;

                case "RADIOLOGIA":
                    cboxProcedimento.Items.Add("Fotografia - Unidade");
                    cboxProcedimento.Items.Add("Levantamento Radiográfico (Exame Radiodôntico) - valor por radiografia - máximo de 14 RX");            
                    cboxProcedimento.Items.Add("Modelos Ortodônticos - Par");
                    cboxProcedimento.Items.Add("Modelos Ortodônticos Digital");
                    cboxProcedimento.Items.Add("Radiografia da mão e punho - carpal");
                    cboxProcedimento.Items.Add("Radiografia da ATM ");
                    cboxProcedimento.Items.Add("Radiografia Interproximal - Bite-Wing");
                    cboxProcedimento.Items.Add("Radiografia Oclusal ");
                    cboxProcedimento.Items.Add("Radiografia Panorâmica de Mandíbula / Maxila (ortopantomografia) ");
                    cboxProcedimento.Items.Add("Radiografia Panorâmica de Mandíbula/Maxila (ortopantomografia) com Traçado Cefalométrico");            
                    cboxProcedimento.Items.Add("Radiografia Periapical");
                    cboxProcedimento.Items.Add("Radiografia antero-posteiror");
                    cboxProcedimento.Items.Add("Radiografia Postero-anterior");
                    cboxProcedimento.Items.Add("Técnica de Localização Radiográfica");
                    cboxProcedimento.Items.Add("Telerradiografia com Traçado Computadorizado ");
                    cboxProcedimento.Items.Add("Telerradiografia");
                    cboxProcedimento.Items.Add("Tomografia computadorizada por feixe cônico - cone beam – por arcada");
                    cboxProcedimento.Items.Add("Tomografia computadorizada por feixe cônico - cone beam – 2 Arcos");
                    cboxProcedimento.Items.Add("Tomografia computadorizada por feixe cônico - cone beam – Hemi Arco");
                    cboxProcedimento.Items.Add("Tomografia computadorizada por feixe cônico - cone beam – Por Dente ");
                    cboxProcedimento.Items.Add("Tomografia computadorizada por feixe cônico - cone beam – Pesquisa de Fratura / Endodontia / Lesão / Dente Incluso – Por Arcada");            
                    cboxProcedimento.Items.Add("Tomografia convencional - linear ou multi-direcional ");
                    cboxProcedimento.Items.Add("Traçado Cefalométrico");
                    cboxProcedimento.Items.Add("Slide");
                    break;

                case "TESTES E EXAMES":
                    cboxProcedimento.Items.Add("Diagnóstico Anatomopatológico em Citologia Esfoliativa na região Buco-maxilo-facial");
                    cboxProcedimento.Items.Add("Diagnóstico Anatomopatológico em Material de Biópsia na Região Buco-maxilo-facial");
                    cboxProcedimento.Items.Add("Diagnóstico Anatomopatológico em Peça Cirurgica na Região Buco-maxilo-facial");
                    cboxProcedimento.Items.Add("Diagnóstico Anatomopatológico em Punção na Região Buco-maxilo-facial ");
                    cboxProcedimento.Items.Add("Diagnóstico e Planejamento para tratamento odontológico");
                    cboxProcedimento.Items.Add("Diagnóstico e tratamento de estomatite herpética");
                    cboxProcedimento.Items.Add("Diagnóstico e tratamento de estomatite por candidose");
                    cboxProcedimento.Items.Add("Diagnóstico e tratamento de halitose ");
                    cboxProcedimento.Items.Add("Diagnóstico e tratamento de trismo");
                    cboxProcedimento.Items.Add("Diagnóstico e tratamento de xerostomia");
                    cboxProcedimento.Items.Add("Diagnóstico por meio de procedimentos laboratoriais");
                    cboxProcedimento.Items.Add("Teste de Fluxo Salivar");
                    cboxProcedimento.Items.Add("Teste de PH da Saliva");
                    cboxProcedimento.Items.Add("Teste de capacidade tampão da saliva ");
                    break;

                case "URGÊNCIA/EMERGÊNCIA":
                    cboxProcedimento.Items.Add("Consulta Odontológica de Urgência (tratamento de odontalgia aguda) ");
                    cboxProcedimento.Items.Add("Consulta Odontológica de Urgência 24 horas ");
                    cboxProcedimento.Items.Add("Colagem de Fragmentos Dentários");
                    cboxProcedimento.Items.Add("Controle de Hemorragia com Aplicação de Agente Hemostático em região Bucomaxilo-facial");
                    cboxProcedimento.Items.Add("Controle de Hemorragia sem Aplicação de Agente Hemostático em região Bucomaxilo-facial");
                    cboxProcedimento.Items.Add("Imobilização Dentária em Dentes Decíduos");
                    cboxProcedimento.Items.Add("Imobilização Dentária em Dentes Permanentes");
                    cboxProcedimento.Items.Add("Incisão e Drenagem Extra Oral de Abscesso, Hematoma e/ou Flegmão da Região");
                    cboxProcedimento.Items.Add("Incisão e Drenagem Extra Oral de Abscesso, Hematoma e/ou Flegmão da Região Buco - Maxilo - Facial");            
                    cboxProcedimento.Items.Add("Incisão e Drenagem Intra Oral de Abscesso, Hematoma e/ou Flegmão da Região Buco - Maxilo - Facial");            
                    cboxProcedimento.Items.Add("Recimentação de Trabalhos Protéticos");
                    cboxProcedimento.Items.Add("Redução Simples de Luxação de Articulação Têmporo-Mandibular (ATM)");
                    cboxProcedimento.Items.Add("Reimplante Dentário com Contenção ");
                    cboxProcedimento.Items.Add("Remoção de Dreno Extra-Oral");
                    cboxProcedimento.Items.Add("Remoção de Dreno Intra-Oral ");
                    cboxProcedimento.Items.Add("Sutura de Ferida em região Buco-Maxilo-Facial");
                    cboxProcedimento.Items.Add("Tratamento de Abscesso Periodontal agudo ");
                    cboxProcedimento.Items.Add("Tratamento de Alveolite");
                    cboxProcedimento.Items.Add("Tratamento de Odontalgia Aguda");
                    cboxProcedimento.Items.Add("Tratamento de Pericoronarite");
                    break;

                default:
                    // Adiciona um valor padrão na cboxProcedimento
                    cboxProcedimento.Items.Add("Procedimento não informado");
                    break;
            }
        }

        private void btnAdicionarProcedimento_Click(object sender, EventArgs e)
        {
            // Obtém os valores selecionados ou textos digitados nos ComboBoxes
            string dentista = cboxDentista.Text.Trim();
            string elemento = cboxElementos.SelectedItem?.ToString() ?? "---";
            string face = cboxFaces.SelectedItem?.ToString() ?? "Não informado";
            string especialidade = cboxEspecialidade.Text.Trim();
            string procedimento = cboxProcedimento.Text.Trim();
            DateTime data = DateTime.Now;

            // Verifica se a especialidade e o procedimento foram selecionados ou digitados
            if (dentista == "Selecione um Dentista")
            {
                MessageBox.Show("Dentista não informado: Selecione o Cirugião Dentista");
                return; // Sai do evento do botão para interromper a execução
            }

            else if (string.IsNullOrEmpty(especialidade) && !string.IsNullOrEmpty(procedimento))
            {
                especialidade = "NÃO INFORMADO";
            }

            else if (!string.IsNullOrEmpty(especialidade) && string.IsNullOrEmpty(procedimento))
            {
                MessageBox.Show("Necessário informar o Procedimento. Selecione ou Digite.", "Erro no Preechimento de Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (especialidade == "NENHUM(a)" && string.IsNullOrEmpty(procedimento))
            {
                MessageBox.Show("Necessário informar o Procedimento. Selecione ou Digite.", "Erro no Preechimento de Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }            

            else if (string.IsNullOrEmpty(especialidade) || string.IsNullOrEmpty(procedimento))
            {
                MessageBox.Show("Selecione a Especialidade e o Procedimento.", "Erro no Preechimento de Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Sai do evento do botão para interromper a execução
            }            

            // Adiciona os valores como uma nova linha no DataGridView
            dataGridProcedimentos.Rows.Add(elemento, face, dentista, procedimento, data);
        }
       

        /// FUNÇÃO PARA CRIAR OS RETANGULOS DE SELEÇÃO NA IMAGEM ODONTOGRAMA
        private void CriarRetangulo(object sender, EventArgs e, int x, int y, int width, int height, string elemento)
        {
            var checkbox = (System.Windows.Forms.CheckBox)sender;

            if (checkbox.Checked)
            {
                Rectangle retangulo = new Rectangle(x, y, width, height);
                retangulosCheckbox[checkbox] = retangulo;
                cboxElementos.Text = elemento;
            }
            else
            {
                retangulosCheckbox.Remove(checkbox);
                cboxElementos.Text = "---";
            }
            pbImgOdontograma.Invalidate();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 12, 15, 33, 180, "18");
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 12, 204, 33, 180, "48");
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 47, 15, 32, 180, "17");
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 47, 204, 32, 180, "47");
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 81, 15, 32, 180, "16");
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 81, 204, 32, 180, "46");
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 115, 15, 32, 180, "15");
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 115, 204, 32, 180, "45");
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 149, 15, 32, 180, "14");
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 149, 204, 32, 180, "44");
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 183, 15, 32, 180, "13");
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 183, 204, 32, 180, "43");
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 217, 15, 31, 180, "12");
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 217, 204, 31, 180, "42");
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 250, 15, 32, 180, "11");
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 250, 204, 32, 180, "41");
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 285, 15, 32, 180, "21");
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 285, 204, 32, 180, "31");
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 319, 15, 31, 180, "22");
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 319, 204, 31, 180, "32");
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 352, 15, 32, 180, "23");
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 352, 204, 32, 180, "33");
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 386, 15, 32, 180, "24");
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 386, 204, 32, 180, "34");
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 420, 15, 32, 180, "25");
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 420, 204, 32, 180, "35");
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 454, 15, 32, 180, "26");
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 454, 204, 32, 180, "36");
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 488, 15, 32, 180, "27");
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 488, 204, 32, 180, "37");
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 522, 15, 33, 180, "28");
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            CriarRetangulo(sender, e, 522, 204, 33, 180, "38");
        }


        private void dataGridProcedimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Exibe a caixa de diálogo de confirmação
                DialogResult result = MessageBox.Show("Você está excluindo um Procedimento, após a exclusão verifique" +
                    " se as seleções e informações dos outros Elementos e Procedimentos estão corretas." +
                    "\n\nTem certeza que deseja excluir este Procedimento?", "ATENÇÃO: Exclusão de Procedimento!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dataGridProcedimentos.SelectedRows.Count >= 1)
                    {
                        var rowToRemove = dataGridProcedimentos.SelectedRows[0];

                        string elemento = rowToRemove.Cells["Elemento"].Value.ToString();

                        if (elementoCheckboxMap.ContainsKey(elemento))
                        {
                            var checkbox = elementoCheckboxMap[elemento];
                            checkbox.Checked = false;
                        }                        
                    }

                }
                else
                {
                    e.SuppressKeyPress = true; // Cancela o evento KeyDown
                    SendKeys.Send("{ESC}"); // Simula um pressionamento da tecla Escape
                }                
            }           
        }

        private void btnSalvarFichaClinica_Click(object sender, EventArgs e)
        {

            try
            {
                serviceOdt.Cadastrar(ObjOdontogramaGerado());
                MessageBox.Show("Odontograma salvo com sucesso!");
                this.Close();




            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }        


        public Odontograma ObjOdontogramaGerado()
        {
            //PEGANDO A IMAGEM GERADA NA FUNÇÃO
            byte[] imagemBytes = GerarImagem(pbImgOdontograma);
            
            Odontograma objOdt = new Odontograma();
            objOdt.IdPaciente = Convert.ToInt32(lblCodigo.Text);
            objOdt.Imagem = imagemBytes;      

            return objOdt;
        }       

        //public Procedimento ObjProcedimentoGerado()
        //{
        //    //Busca do id do Dentista pelo nome selecionado na combobox
        //    string nomeDentista = cboxDentista.SelectedItem.ToString();
        //    Dentista dentistaEncontrado = serviceD.BuscarPorNome(nomeDentista);
        //    int idDentista = dentistaEncontrado.Id;


        //    //GERANDO O OBJETO PROCEDIMENTO PARA CADASTRAR NO BANCO.
        //    Procedimento objProcd = new Procedimento();
        //    objProcd.IdDentista = idDentista;
        //    //objProcd.IdOdontograma =         

        //    return objProcd;
        //}

        



        ////////////////////////////////////////

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
        //}



    }

}
