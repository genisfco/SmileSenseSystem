using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            //
            try
            {
                string destinatario = "maicondexon@gmail.com";
                string assunto = "Assunto do email";
                string corpo = "Corpo do email";

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
