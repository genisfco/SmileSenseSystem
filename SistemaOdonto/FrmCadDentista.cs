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
    public partial class FrmCadDentista : Form
    {

        DentistaService service = new DentistaService();


        public FrmCadDentista()
        {
            InitializeComponent();
        }

        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if(txtNome.Text == string.Empty)
            {
                txtNome.Focus();
                return "Preencha o campo Nome!";
            }
            else if (txtCRO.Text == string.Empty)
            {
                txtCRO.Focus();
                return "Preencha o campo CRO";
            }
            else if (maskRGDent.Text.Length != 12)
            {
                maskRGDent.Focus();
                return "Preencha o RG completo";
            }
            else if (maskCPFDent.Text.Length != 14)
            {
                maskCPFDent.Focus();
                return "Preencha o campo CPF";
            }
            else if (comboxEspecialidade1.SelectedIndex == -1)
            {
                comboxEspecialidade1.Focus();
                return "Escolha uma Especialidade";
            }
            else if(txtCelular.Text == string.Empty)
            {
                txtCelular.Focus();
                return "Preencha o campo Celular";
            }
            /*else if (txtTelefone.Text == string.Empty)
            {
                txtTelefone.Focus();
                return "Preencha o campo Telefone";
            }                                               CAMPOS NÃO OBRIGATÓRIOS
            else if (txtEmail.Text == string.Empty)
            {
                txtEmail.Focus();
                return "Preencha o campo Email";
            }  */          
            else
            {
                ts.ForeColor = Color.Black;
                return "Dados preenchidos";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";            
            
            ts.Text = ValidarCad();
            if(ts.Text == "Dados preenchidos")
            {
                
                if (ClassValidation.ValidationDocs.validarCpf(maskCPFDent.Text) == false)
                {                        
                    MessageBox.Show("CPF inválido!");
                    maskCPFDent.Focus();
                }
                else if (ClassValidation.ValidationDocs.validarRg(maskRGDent.Text) == false)
                {                        
                    MessageBox.Show("RG inválido!");
                    maskRGDent.Focus();
                }
                else
                {
                    try
                    {
                        service.Cadastrar(objGerado());
                        MessageBox.Show("Novo Dentista Cadastrado com Sucesso!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao Salvar " + ex.Message);
                    }

                }
                    
            }           
            
        }


        public Dentista objGerado()
        {
            //TRATAMENTO DADOS RG E CPF Dentista
            string rgdentista = maskRGDent.Text;
            string cpfdentista = maskCPFDent.Text;

            rgdentista = rgdentista.Replace(",", "").Replace("-", "");
            cpfdentista = cpfdentista.Replace(",", "").Replace("-", "");


            Dentista obj = new Dentista();
            obj.Nome = txtNome.Text;
            obj.CRO = txtCRO.Text;
            obj.RGDent = rgdentista;
            obj.CPFDent = cpfdentista;
            obj.Especialidade1 = comboxEspecialidade1.Text;
            obj.Especialidade2 = comboxEspecialidade2.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;

            return obj;
        }              

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        public void LimparForm()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCRO.Text = string.Empty;
            maskCPFDent.Text = string.Empty;
            maskRGDent.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            comboxEspecialidade1.Text = string.Empty;
            comboxEspecialidade2 .Text = string.Empty;
        }

        private void txtCRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
