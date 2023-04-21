using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globais;

namespace SistemaOdonto
{
    public partial class FrmLogin : Form
    {
        FrmPrincipal frmPrincipal;
        DataTable dt = new DataTable();        

        public FrmLogin(FrmPrincipal frm)
        {
            InitializeComponent();
            frmPrincipal = frm; 
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string senha = txt_Senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou Senha inválidos!");
                txt_UserName.Focus();
                return;
            }


            string sql = "SELECT * FROM usuarios WHERE username='" + username + "' AND senha_user='" + senha + "'";
            dt = DataConnection.consulta(sql);



            if (dt.Rows.Count == 1)
            {
                frmPrincipal.lb_Acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                frmPrincipal.lb_NomeUsuario.Text = dt.Rows[0].Field<string>("nome_user");
                frmPrincipal.pb_ledLogado.Image = Properties.Resources.Circle_Green;

                Globais.Global.nivel = int.Parse(dt.Rows[0].Field<int>("nivel_user").ToString());
                Globais.Global.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
