using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using cript;
using Globais;
using Controllers;

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
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string diretorioInstalacao = AppDomain.CurrentDomain.BaseDirectory;
            string smileconfigFolderPath = Path.Combine(diretorioInstalacao, "SmileSenseConfig");

            // Verifica se a pasta SmileSenseConfig já existe
            if (!Directory.Exists(smileconfigFolderPath))
            {
                //criando a pasta SmileSenseConfig
                Directory.CreateDirectory(smileconfigFolderPath);
            }

            string configFilePath = Path.Combine(smileconfigFolderPath, "config.pws");

            if (!File.Exists(configFilePath))
            {
                MessageBox.Show("Arquivo de configuração do banco não encontrado.\r\nClique em OK para configurar a conexão.", "Atenção!");
                Form frmConfig = new FormConfig();
                frmConfig.ShowDialog();
                this.Close();
            }
            else
            {
                string[] configLines = File.ReadAllLines(configFilePath);

                ClassCript clCript = new ClassCript();

                if (configLines.Length == 4)
                {
                    string server = clCript.Descriptografa(configLines[0]);
                    string user = clCript.Descriptografa(configLines[1]);
                    string password = clCript.Descriptografa(configLines[2]);
                    string database = clCript.Descriptografa(configLines[3]);

                    string connectionString = $"Server={server};Database={database};User ID={user};Password={password};";

                    // Determina as strings de conexão
                    DataConnection.ConnectionString = connectionString;
                    Controllers.Context.SistemaContext.ConnectionString = connectionString;
                }               

                else if (configLines.Length == 2)
                {
                    string server = clCript.Descriptografa(configLines[0]);
                    string database = clCript.Descriptografa(configLines[1]);

                    string connectionString = $"Server={server};Database={database};Integrated Security=True;";

                    // Use a connectionString no lugar das strings de conexão existentes
                    DataConnection.ConnectionString = connectionString;
                    Controllers.Context.SistemaContext.ConnectionString = connectionString;
                }

                else
                {
                    MessageBox.Show("O arquivo de configuração está incompleto. Configure novamente!", "Atenção!");
                    Form frmConfig = new FormConfig();
                    frmConfig.ShowDialog();
                    this.Close();
                }
            }
        }


        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string senha = txt_Senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou Senha inválidos!", "Erro ao Logar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();
                return;
            }
                            
             string sql = "SELECT * FROM Usuarios WHERE username='" + username + "' AND senha_user='" + senha + "'";
            dt = DataConnection.consulta(sql);


            if (dt.Rows.Count == 1)
            {
                string status = dt.Rows[0].Field<string>("status_user");

                if (status == "B" || status == "D")
                {                

                    MessageBox.Show("Desculpe, não será possível Logar!\r\n" +
                        "Usuário com acesso bloqueado ao sistema!", "Acesso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                else if (nivelUser == 3)
                {
                    frmPrincipal.menuDentista.Enabled = true;
                    frmPrincipal.menuDadosDentistas.Enabled = true;
                    frmPrincipal.usuáriosToolStripMenuItem.Visible = true;

                    frmPrincipal.MenuAjuda.Visible = true;
                }

                Global.nivel = int.Parse(dt.Rows[0].Field<int>("nivel_user").ToString());
                Global.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
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
