using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Windows.Forms;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaOdonto
{
    public partial class frmSuporte : Form
    {
        public frmSuporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string destinatario = "suporte@smilesense.com";
                string assunto = textBox5.Text;
                string campo1 = textBox1.Text;
                string campo2 = textBox2.Text;
                string campo3 = textBox3.Text;
                string campo4 = textBox4.Text;
                                                
                string corpo = $"Nome: {campo1}{Environment.NewLine}{Environment.NewLine}" +
                               $"Telefone: {campo2}{Environment.NewLine}{Environment.NewLine}" +
                               $"Endereço: {campo3}{Environment.NewLine}{Environment.NewLine}" +
                               $"Mensagem: {campo4}{Environment.NewLine}{Environment.NewLine}";


                string url = $"mailto:{destinatario}?subject={Uri.EscapeDataString(assunto)}&body={Uri.EscapeDataString(corpo)}";

                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o cliente de email: " + ex.Message);
            }
                                   
        }
    }
}
