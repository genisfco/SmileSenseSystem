using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdonto
{
    public partial class FrmEditarDentista : Form
    {
        public string status;
        Dentista obj = new Dentista();
        DentistaService service = new DentistaService();
        LoggerService serviceLog = new LoggerService();

        public FrmEditarDentista(Dentista obj)
        {
            InitializeComponent();
            lblCodigo.Visible = false;
            btnEditar.Enabled = false;
            IniciarFormulario(obj);

            if (Globais.Global.nivel == 1 || Globais.Global.nivel == 2)
            {
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }

            // Evento de alteração dos campos
            txtNome.TextChanged += ControleAlterado;
            txtCRO.TextChanged += ControleAlterado;
            comboxEspecialidade1.TextChanged += ControleAlterado;
            comboxEspecialidade2.TextChanged += ControleAlterado;
            txtEmail.TextChanged += ControleAlterado;
            txtTelefone.TextChanged += ControleAlterado;
            txtCelular.TextChanged += ControleAlterado;
        }

        private void ControleAlterado(object sender, EventArgs e)
        {
            // Habilitar o botão de Edição quando um controle for alterado
            btnEditar.Enabled = true;
        }

        private void IniciarFormulario(Dentista objD)
        {
            this.obj = objD;
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtCRO.Text = this.obj.CRO;
            maskRGDentist.Text = this.obj.RGDent;
            maskCPFDentist.Text = this.obj.CPFDent;
            comboxEspecialidade1.Text = this.obj.Especialidade1;
            comboxEspecialidade2.Text = this.obj.Especialidade2;
            txtEmail.Text = this.obj.Email;
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtCelular.Text = this.obj.Celular.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if(ts.Text == "Dados obrigatórios preenchidos!")
            {
                if(lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "apagado";
                    MessageBox.Show("Este Registro acabou de ser excluido por outro usuário", "Atenção!");
                }
                else
                {
                    //GUARDANDO OS DADOS ANTIGOS
                    string nomeAnt = this.obj.Nome;
                    string CROAnt = this.obj.CRO;
                    string espec1Ant = this.obj.Especialidade1;
                    string espec2Ant = this.obj.Especialidade2;
                    string emailAnt = this.obj.Email;
                    Int64 foneAnt = this.obj.Telefone;
                    Int64 celAnt = this.obj.Celular;                                   

                    //TRATAMENTO DADOS RG E CPF Dentista
                    string rgdentista = maskRGDentist.Text;
                    string cpfdentista = maskCPFDentist.Text;
                    rgdentista = rgdentista.Replace(",", "").Replace("-", "");
                    cpfdentista = cpfdentista.Replace(",", "").Replace("-", "");
                    
                    this.obj.Nome = txtNome.Text;
                    this.obj.CRO = txtCRO.Text;
                    this.obj.RGDent = rgdentista;
                    this.obj.CPFDent = cpfdentista;
                    this.obj.Especialidade1 = comboxEspecialidade1.Text;
                    this.obj.Especialidade2 = comboxEspecialidade2.Text;
                    this.obj.Email = txtEmail.Text;
                    this.obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0000000000;
                    this.obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 00000000000;

                    // COMPARANDO os novos valores com os valores antigos
                    string observacao = "";

                    if (this.obj.Nome != nomeAnt)
                    {
                        observacao += "Nome; ";
                    }
                    if (this.obj.CRO != CROAnt)
                    {                        
                        observacao += "CRO; ";
                    }
                    if (this.obj.Especialidade1 != espec1Ant)
                    {
                        observacao += "Especialidade 1; ";
                    }
                    if (this.obj.Especialidade2 != espec2Ant)
                    {
                        observacao += "Especialidade 2; ";
                    }
                    if (this.obj.Email != emailAnt)
                    {
                        observacao += "Email; ";
                    }
                    if (this.obj.Telefone != foneAnt)
                    {
                        observacao += "Telefone; ";
                    }
                    if (this.obj.Celular != celAnt)
                    {
                        observacao += "Celular; ";
                    }

                    try
                    {
                        service.Editar(this.obj);

                        string tipoLogger = "Atualização";
                        serviceLog.Cadastrar(objLogGerado(tipoLogger, observacao));
                        status = "editado";
                        MessageBox.Show("Dados Atualizados com Sucesso!", "Ação Realizada!");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar: ", ex.Message);    
                    }                    
                }
            }
        }

        public Logger objLogGerado(string tipoLogger, string observacao)
        {
            Logger objLog = new Logger();
            objLog.IDUser = Globais.Global.id;
            objLog.Data_Logger = DateTime.Now;
            objLog.Tipo_Logger = tipoLogger;
            objLog.Tabela_Logger = "Dentista";
            objLog.ID_Tabela = Convert.ToInt32(lblCodigo.Text);
            objLog.Observacao = observacao;

            return objLog;
        }


        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                txtNome.Focus();
                return "Preencha o campo Nome!";
            }
            else if (txtCelular.Text == string.Empty)
            {
                txtCelular.Focus(); 
                return "Preencha o campo Celular";
            }
            /*else if (txtTelefone.Text == string.Empty)
            {
                txtTelefone.Focus();
                return "Preencha o campo Telefone";
            }
            else if (txtEmail.Text == string.Empty)
            {
                txtEmail.Focus();
                return "Preencha o campo Email";
            }*/
            else if (comboxEspecialidade1.Text == "")
            {
                comboxEspecialidade1.Focus();
                return "Informe a Especialidade";
            }
            
            else
            {
                ts.ForeColor = Color.Black;
                return "Dados obrigatórios preenchidos!";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";

            // Exibe uma mensagem de confirmação antes de excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Dentista?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                try
                {                    
                    string tipoLogger = "Deleção";
                    string observacao = this.obj.Nome;
                    serviceLog.Cadastrar(objLogGerado(tipoLogger, observacao));

                    service.Deletar(this.obj.Id);
                    MessageBox.Show("Dentista Excluído com sucesso!", "Ação Realizada!");
                    status = "apagado";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível fazer a exclusão: ", ex.Message);
                }
            }
            
            else if (resultado == DialogResult.No)
            {
                return;
            }
            
        }        

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Select(0, 0);
        }

        private void txtCRO_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => txtCRO.Select(0, 0)));
        }

        private void maskRGDentist_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => maskRGDentist.Select(0, 0)));
        }

        private void maskCPFDentist_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => maskCPFDentist.Select(0, 0)));
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Select(0, 0);
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => txtTelefone.Select(0, 0)));
        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => txtCelular.Select(0, 0)));

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }        
    }
}
