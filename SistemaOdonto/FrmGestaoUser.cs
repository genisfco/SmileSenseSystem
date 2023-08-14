using Entidades;
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
using System.Xml.Linq;
using WcfService;

namespace SistemaOdonto
{
    public partial class FrmGestaoUser : Form
    {
        LoggerService serviceLog = new LoggerService();

        public FrmGestaoUser()
        {
            InitializeComponent();
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            FrmNovoUser telaNovoUser = new FrmNovoUser();
            telaNovoUser.ShowDialog();
            dgv_Usuarios.DataSource = RepositUser.ObterUsuariosIdNome();
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

            RepositUser.AtualizarDadosUsuario(u);
            dgv_Usuarios[1, linha].Value = txt_NomeUsuario.Text;
            MessageBox.Show("Dados atualizados com sucesso!");

            string tipoLogger = "Atualização";
            serviceLog.Cadastrar(objLogGerado(tipoLogger));
        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            string str_mensagem = string.Format("Nome: {0}\r\n\r\n" +
                                               "Usuário: {1}\r\n\r\n" +
                                               "Tem certeza que deseja excluir o Usuário selecionado?" +
               "", txt_NomeUsuario.Text, txt_Username.Text);

            DialogResult confirmacao = MessageBox.Show(str_mensagem, "Confirmação de Exclusão de Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            else if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    RepositUser.ExcluirDadosUsuario(txt_ID.Text);
                    dgv_Usuarios.Rows.Remove(dgv_Usuarios.CurrentRow);
                    MessageBox.Show("Usuário excluído com sucesso!");

                    string tipoLogger = "Deleção";
                    serviceLog.Cadastrar(objLogGerado(tipoLogger));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Desculpe, não foi possível fazer a exclusão: ", ex.Message);
                }
            }            
        }

        public Logger objLogGerado(string tipoLogger)
        {
            Logger objLog = new Logger();
            objLog.IDUser = Globais.Global.id;
            objLog.Data_Logger = DateTime.Now;
            objLog.Tipo_Logger = tipoLogger;
            objLog.Tabela_Logger = "Usuário";
            objLog.ID_Tabela = Convert.ToInt32(txt_ID.Text);

            return objLog;
        }

        private void FrmGestaoUser_Load(object sender, EventArgs e)
        {
            dgv_Usuarios.DataSource = RepositUser.ObterUsuariosIdNome();
            dgv_Usuarios.Columns[0].Width = 80;
            dgv_Usuarios.Columns[1].Width = 235;
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                dt = RepositUser.ObterDadosUsuarios(vid);

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
