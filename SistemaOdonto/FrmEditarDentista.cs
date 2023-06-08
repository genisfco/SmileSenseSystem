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

        public FrmEditarDentista(Dentista obj)
        {
            InitializeComponent();
            lblCodigo.Visible = false;
            IniciarFormulario(obj);

            if (Globais.Global.nivel == 1 || Globais.Global.nivel == 2)
            {
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }
        }

        private void IniciarFormulario(Dentista objP)
        {
            this.obj = objP;
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
                    MessageBox.Show("Este Registro acabou de ser excluido por outro usuário");
                }
                else
                {

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
                    obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;

                    try
                    {
                        service.Editar(this.obj);
                        status = "editado";
                        MessageBox.Show("Dados Atualizados com Sucesso!");
                        this.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Não foi possível atualizar: ", ex.Message);    
                    }
                    
                }
            }

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
                    service.Deletar(this.obj.Id);
                    MessageBox.Show("Dentista Excluído com sucesso!");
                    status = "apagado";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível fazer a exclusão: ", ex.Message);
                }
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
