﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Globais;

namespace SistemaOdonto
{
    public partial class FrmLogin : Form
    {
        FrmPrincipal frmPrincipal;

        DataTable dt = new DataTable();        

        public FrmLogin(FrmPrincipal frmP)
        {
            InitializeComponent();
            frmPrincipal = frmP;
            //frmEdtPaciente = frmEdP;
            //frmEdtDentista = frmEdD;
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

            string sql = "SELECT * FROM Usuarios WHERE username='" + username + "' AND senha_user='" + senha + "'";
            dt = DataConnection.consulta(sql);


            if (dt.Rows.Count == 1)
            {
                frmPrincipal.lb_Acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                frmPrincipal.lb_NomeUsuario.Text = dt.Rows[0].Field<string>("nome_user");
                frmPrincipal.pb_ledLogado.Image = Properties.Resources.Circle_Green;
                frmPrincipal.pnlBarraLogin.BackColor = Color.FromArgb(192, 255, 192);
                
                
                int nivelUser = dt.Rows[0].Field<int>("nivel_user");
                
                if (nivelUser == 1)
                {
                    //sem acesso aos cadastros de dados (dentistas)
                    frmPrincipal.menuDentista.Enabled = false;

                    //não poderá consultar dados de dentistas
                    frmPrincipal.menuDadosDentistas.Enabled = false;

                    //sem acesso aos usuários
                    frmPrincipal.usuáriosToolStripMenuItem.Visible = false;

                    //sem acesso ao Suporte
                    frmPrincipal.MenuAjuda.Visible = false;                    
                }
                else if (nivelUser == 2)
                {                    
                    //sem acesso aos usuários
                    frmPrincipal.usuáriosToolStripMenuItem.Visible = false;                    
                }

                Global.nivel = int.Parse(dt.Rows[0].Field<int>("nivel_user").ToString());
                Global.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Global.logado = false;
            Global.nivel = 0;

            DialogResult resultado = MessageBox.Show("Deseja sair da aplicação?", "Confirmação de saída",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Lógica para sair da aplicação
                Application.Exit();
            }
        }        
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Senha.PasswordChar = '\0';
            }
            else
            {
               txt_Senha.PasswordChar = '*';
            }
        }
    }
}
