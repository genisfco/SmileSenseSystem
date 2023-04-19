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

        public FrmOdontograma()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, 3);
            _bitmap = new Bitmap(pbImgOdontograma.Width, pbImgOdontograma.Height);
            pbImgOdontograma.Image = _bitmap;
            Stack<Bitmap> undoStack = new Stack<Bitmap>();
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

            _pen.Color = Color.Green;

        }


        //ESCOLHA DAS CORES CONFORME FERRAMENTAS PEN (PRETO, AZUL, VERMELHO)
        private void pbPenBlack_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.FixedSingle;
            pbPenBlue.BorderStyle = BorderStyle.Fixed3D;
            pbPenRed.BorderStyle = BorderStyle.Fixed3D;
            pbCircle.BorderStyle = BorderStyle.Fixed3D;

            _pen.Color = color1;
        }

        private void pbPenBlue_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.Fixed3D;
            pbPenBlue.BorderStyle = BorderStyle.FixedSingle;
            pbPenRed.BorderStyle = BorderStyle.Fixed3D;
            pbCircle.BorderStyle = BorderStyle.Fixed3D;


            _pen.Color = color2;
        }

        private void pbPenRed_Click(object sender, EventArgs e)
        {
            pbPenBlack.BorderStyle = BorderStyle.Fixed3D;
            pbPenBlue.BorderStyle = BorderStyle.Fixed3D;
            pbPenRed.BorderStyle = BorderStyle.FixedSingle;
            pbCircle.BorderStyle = BorderStyle.Fixed3D;


            _pen.Color = color3;
        }
        ///////////////////////////////////////////////////////////////
        
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(pbCircle.BorderStyle == BorderStyle.FixedSingle)
            {
                int numUndos = 1; // Defina o número de traços a serem desfeitos
                while (_undoStack.Count > 0 && numUndos > 0)
                {
                    _bitmap = _undoStack.Pop();
                    numUndos--;
                }
            }
            else if (pbPenBlack.BorderStyle == BorderStyle.FixedSingle || pbPenBlue.BorderStyle == BorderStyle.FixedSingle || pbPenRed.BorderStyle == BorderStyle.FixedSingle)
            {
                int numUndos = 10; // Defina o número de traços a serem desfeitos
                while (_undoStack.Count > 0 && numUndos > 0)
                {
                    _bitmap = _undoStack.Pop();
                    numUndos--;
                }

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

        //}
    }
}
