using Globais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class FrmNovoUser : Form
    {
        public FrmNovoUser()
        {
            InitializeComponent();
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            txt_NomeUsuario.Clear();
            txt_Username.Clear();
            txt_Senha.Clear();
            cb_Status.Text = "";
            nup_Nivel.Value = 1;
            txt_NomeUsuario.Focus();
        }


        private void btnSalvarUser_Click(object sender, EventArgs e)
        {
            string nome = txt_NomeUsuario.Text;
            string user_name = txt_Username.Text;
            string password = txt_Senha.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por gentileza, preencha todos os Campos");
                return;
            }            

            Usuario usuario = new Usuario();
            usuario.nome = txt_NomeUsuario.Text;
            usuario.username = txt_Username.Text;
            usuario.password = txt_Senha.Text;
            usuario.status = cb_Status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(nup_Nivel.Value, 0));

            DataConnection.NovoUsuario(usuario);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
