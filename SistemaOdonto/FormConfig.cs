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
            checkBoxAutentWind.Checked = true;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            string local = textBoxLocal.Text.ToString();
            string banco = textBoxBanco.Text.ToString();
            string usuario = textBoxUsuario.Text.ToString();
            string senha = textBoxSenha.Text.ToString();

            string configDados = "";

            if (local.Replace(" ", "").Equals(""))
            {
                MessageBox.Show("Digite o local (servidor do banco)!");
                textBoxLocal.Select();
                return;
            }
            if (banco.Replace(" ", "").Equals(""))
            {
                MessageBox.Show("Digite o nome (database) do Banco!");
                textBoxBanco.Select();
                return;
            }

            //Acessar a pasta para gravar o arquivo
            string diretorioInstalacao = AppDomain.CurrentDomain.BaseDirectory;
            string smileconfigFolderPath = Path.Combine(diretorioInstalacao, "SmileSenseConfig");

            string filePath = Path.Combine(smileconfigFolderPath, "config.pws");

            ClassCript clCript = new ClassCript();

            if (!checkBoxAutentWind.Checked)
            {
                if (usuario.Replace(" ", "").Equals(""))
                {
                    MessageBox.Show("Digite o nome do Usuario!");
                    textBoxUsuario.Select();
                    return;
                }
                if (senha.Replace(" ", "").Equals(""))
                {
                    MessageBox.Show("Digite a senha!");
                    textBoxSenha.Select();
                    return;
                }
                configDados = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", clCript.Criptografa(local), clCript.Criptografa(usuario), clCript.Criptografa(senha), clCript.Criptografa(banco));                
            }

            else if (checkBoxAutentWind.Checked)
            {               
                configDados = string.Format("{0}\r\n{1}", clCript.Criptografa(local), clCript.Criptografa(banco));
            }

            StreamWriter streamWriter = new StreamWriter(filePath, false);

            streamWriter.WriteLine(configDados);
            streamWriter.Close();

            MessageBox.Show("Dados configurados com sucesso!\r\nAbra novamente o sistema SmileSense ", "Banco configurado!");
            Application.Exit();
        }

        private void checkBoxAutentWind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutentWind.Checked)
            {
                textBoxUsuario.Enabled = false;
                labelUser.Enabled = false;
                textBoxSenha.Enabled = false;
                labelPass.Enabled = false;
            }
            else if (!checkBoxAutentWind.Checked)
            {
                textBoxUsuario.Enabled = true;
                labelUser.Enabled = true;
                textBoxSenha.Enabled = true;
                labelPass.Enabled = true;
            }
        }
    }
}
