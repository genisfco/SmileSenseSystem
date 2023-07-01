using cript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (textBoxLocal.Text.Replace(" ", "").Equals(""))
            {
                MessageBox.Show("Digite o local (servidor do banco)!");
                textBoxLocal.Select();
                return;
            }
            if (textBoxBanco.Text.Replace(" ", "").Equals(""))
            {
                MessageBox.Show("Digite o nome (database) do Banco!");
                textBoxBanco.Select(); 
                return;
            }

            string diretorioInstalacao = AppDomain.CurrentDomain.BaseDirectory;
            string smileconfigFolderPath = Path.Combine(diretorioInstalacao, "SmileSenseConfig");

            string filePath = Path.Combine(smileconfigFolderPath, "config.pws");

            ClassCript clCript = new ClassCript();

            //string mDado = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", clCript.Criptografa(textBoxLocal.Text), clCript.Criptografa(textBoxUsuario.Text), clCript.Criptografa(textBoxSenha.Text), clCript.Criptografa(textBoxBanco.Text));
            string mDado = string.Format("{0}\r\n{1}", clCript.Criptografa(textBoxLocal.Text), clCript.Criptografa(textBoxBanco.Text));

            StreamWriter streamWriter = new StreamWriter(filePath, false);

            streamWriter.WriteLine(mDado);
            streamWriter.Close();

            MessageBox.Show("Abra a aplicação novamente");
            Application.Exit();

        }
    }
}
