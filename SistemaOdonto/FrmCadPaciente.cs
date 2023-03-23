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
    public partial class FrmCadPaciente : Form
    {

        PacienteService service = new PacienteService();

        public FrmCadPaciente()
        {
            InitializeComponent();
            cbSexo.Text = "Masculino";
        }


        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome!";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o campo Telefone";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email";
            }

            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso")
                {         

                    service.Cadastrar(objGerado());
                    MessageBox.Show("Cadastro Efetuado com Sucesso");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }
       
        public Paciente objGerado()
        {
            //TRATAMENTO DADOS RG E CPF PACIENTE
            string rgpaciente = masktxtRGPaciente.Text;
            string cpfpaciente = masktxtCPFPaciente.Text;

            rgpaciente = rgpaciente.Replace(",", "").Replace("-", "");
            cpfpaciente = cpfpaciente.Replace(",", "").Replace("-", "");


            /// CONCATENAÇÃO DOS DADOS DE ENDEREÇO PARA SALVAR NO BANCO
            StringBuilder endereco = new StringBuilder();
            endereco.Append(txtEndereco.Text);
            endereco.Append(", ");
            endereco.Append(txtNum.Text);
            endereco.Append(" - ");
            endereco.Append(txtBairro.Text);
            endereco.Append(", ");
            endereco.Append(txtCidade.Text);
            endereco.Append(" - ");
            endereco.Append(txtUF.Text);
            string enderecoCompleto = endereco.ToString();

            Paciente obj = new Paciente();
            obj.Nome = txtNome.Text;
            obj.RG = rgpaciente;
            obj.CPF = cpfpaciente;
            obj.Nascimento = Convert.ToDateTime(dtDataNasc.Value);
            obj.Sexo = cbSexo.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.CEP = txtCEP.Text;
            obj.Endereco = enderecoCompleto;

            return obj;            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmDadosPaciente frm = new FrmDadosPaciente();
            frm.ShowDialog();
        }

        private void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(txtCEP.Text.Trim());
                    txtUF.Text = endereco.uf;
                    txtCidade.Text = endereco.cidade;
                    txtBairro.Text = endereco.bairro;
                    txtEndereco.Text = endereco.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        
    }
}
