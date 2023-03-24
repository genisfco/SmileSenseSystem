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
        }

        private void IniciarFormulario(Dentista objP)
        {
            this.obj = objP;
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtCRO.Text = this.obj.CRO;
            masktxtRGEspecialista.Text = this.obj.RGDent;
            masktxtCPFEspecialista.Text = this.obj.CPFDent;
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
                    string rgdentista = masktxtRGEspecialista.Text;
                    string cpfdentista = masktxtCPFEspecialista.Text;

                    rgdentista = rgdentista.Replace(",", "").Replace("-", "");
                    cpfdentista = cpfdentista.Replace(",", "").Replace("-", "");

                    status = "editado";
                    this.obj.Nome = txtNome.Text;
                    this.obj.CRO = txtCRO.Text;
                    this.obj.RGDent = rgdentista;
                    this.obj.CPFDent = cpfdentista;
                    this.obj.Especialidade1 = comboxEspecialidade1.Text;
                    this.obj.Especialidade2 = comboxEspecialidade2.Text;
                    this.obj.Email = txtEmail.Text;
                    obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    service.Editar(this.obj);

                    MessageBox.Show("Dados do Dentista Atualizados!");
                    this.Close();
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
            if (ValidarExclusao())
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("Excluído com sucesso!");
                status = "apagado";
                this.Close();
            }
        }

        public bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("ATENÇÃO: Tem certeza que deseja excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }        
    }
}
