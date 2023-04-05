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

        PacienteService serviceP = new PacienteService();

        public FrmCadPaciente()
        {
            InitializeComponent();
        }


        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome!";
            }
            else if (cbSexo.SelectedIndex == -1)
            {
                cbSexo.Focus();
                return "Selecione o Sexo";
            }            
            else if (masktxtRGPaciente.Text == string.Empty)
            {
                masktxtRGPaciente.Focus();
                return "Preencha o RG completo";
            }
            else if (masktxtCPFPaciente.Text.Length != 14)
            {
                masktxtCPFPaciente.Focus() ;
                return "Preencha o CPF completo";
            }
            else if (txtCelular.Text == string.Empty)
            {
                txtCelular.Focus();
                return "Preencha o campo Celular";
            }
            /*else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o campo Telefone";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email";
            }*/

            else
            {
                ts.ForeColor = Color.Black;
                return "Dados preenchidos!";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";

            ts.Text = ValidarCad();
            if (ts.Text == "Dados preenchidos!")
            {

                if (ClassValidation.ValidationDocs.validarCpf(masktxtCPFPaciente.Text) == false)
                {
                    MessageBox.Show("CPF inválido!");
                    masktxtCPFPaciente.Focus();
                }
                else if (ClassValidation.ValidationDocs.validarRg(masktxtRGPaciente.Text) == false)
                {
                    MessageBox.Show("RG inválido!");
                    masktxtRGPaciente.Focus();
                }
                else
                {
                    try
                    {
                        serviceP.Cadastrar(objGerado());
                        MessageBox.Show("Novo Paciente Cadastrado com Sucesso!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao Salvar " + ex.Message);
                    }

                }

            }
        }
       
        public Paciente objGerado()
        {
            //TRATAMENTO DATA DE NASCIMENTO
            string dataNascimento = $"{cbAno.Text}-{cbMes.SelectedIndex + 1:00}-{cbDia.Text:00}";


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
            //obj.Nascimento = Convert.ToDateTime(dtDataNasc.Value);
            obj.Nascimento = Convert.ToDateTime(dataNascimento);             
            obj.Sexo = cbSexo.Text;
            obj.Email = txtEmail.Text;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
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
