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
    public partial class FrmGestaoUser : Form
    {
        public FrmGestaoUser()
        {
            InitializeComponent();
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            FrmNovoUser telaNovoUser = new FrmNovoUser();
            telaNovoUser.ShowDialog();
            dgv_Usuarios.DataSource = DataConnection.ObterUsuariosIdNome();
        }

        private void btnSalvarAlterUser_Click(object sender, EventArgs e)
        {
            string nome = txt_NomeUsuario.Text;
            string user_name = txt_Username.Text;
            string password = txt_Senha.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por gentileza, preencha todos os Campos");
                return;
            }

            int linha = dgv_Usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();

            u.id = Convert.ToInt32(txt_ID.Text);
            u.nome = txt_NomeUsuario.Text;
            u.username = txt_Username.Text;
            u.password = txt_Senha.Text;
            u.status = cb_Status.Text;
            u.nivel = Convert.ToInt32(Math.Round(nup_Nivel.Value));

            DataConnection.AtualizarDadosUsuario(u);
            dgv_Usuarios[1, linha].Value = txt_NomeUsuario.Text;

            MessageBox.Show("Dados atualizados com sucesso!");
        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente Excluir o Usuário?", "Exclusão de Usuário", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DataConnection.ExcluirDadosUsuario(txt_ID.Text);
                dgv_Usuarios.Rows.Remove(dgv_Usuarios.CurrentRow);
            }
        }

        private void FrmGestaoUser_Load(object sender, EventArgs e)
        {
            dgv_Usuarios.DataSource = DataConnection.ObterUsuariosIdNome();
            dgv_Usuarios.Columns[0].Width = 80;
            dgv_Usuarios.Columns[1].Width = 200;
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                dt = DataConnection.ObterDadosUsuarios(vid);

                txt_ID.Text = dt.Rows[0].Field<int>("id_user").ToString();
                txt_NomeUsuario.Text = dt.Rows[0].Field<string>("nome_user").ToString();
                txt_Username.Text = dt.Rows[0].Field<string>("username").ToString();
                txt_Senha.Text = dt.Rows[0].Field<string>("senha_user").ToString();
                cb_Status.Text = dt.Rows[0].Field<string>("status_user").ToString();
                nup_Nivel.Value = dt.Rows[0].Field<int>("nivel_user");

            }
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
