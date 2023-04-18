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
    public partial class FrmEditarPaciente : Form
    {

        public string status;
        Paciente obj = new Paciente();
        PacienteService service = new PacienteService();


        public FrmEditarPaciente(Paciente obj)
        {
            InitializeComponent();
            lblCodigo.Visible = false;
            IniciarFormulario(obj);

        }

        private void IniciarFormulario(Paciente objP)
        {
            this.obj = objP;
            
            //DISTRIBUINDO OS DADOS NO FORMS
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            cbSexo.Text = this.obj.Sexo;

            //DISTRIBUIR A DATA DE NASCIMENTO
            cbDia.Text = this.obj.Nascimento.ToString("dd");
            cbMes.Text = this.obj.Nascimento.ToString("MM");
            cbAno.Text = this.obj.Nascimento.Year.ToString();

            masktxtRGPaciente.Text = this.obj.RG;
            masktxtCPFPaciente.Text = this.obj.CPF;
            txtEmail.Text = this.obj.Email;
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtCelular.Text = this.obj.Celular.ToString();

            txtCEP.Text = this.obj.CEP;

            // LEITURA DO ENDEREÇO E DIVISÃO DA STRING PARA TEXTBOX CORRESPONDENTE
            string enderecoCompleto = objP.Endereco;
            string[] enderecoPartes = enderecoCompleto.Split(new char[] { ',', '-' });
            txtEndereco.Text = enderecoPartes[0].Trim();
            txtNum.Text = enderecoPartes[1].Trim();
            txtBairro.Text = enderecoPartes[2].Trim();
            txtCidade.Text = enderecoPartes[3].Trim();
            txtUF.Text = enderecoPartes[4].Trim();            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if (ts.Text == "Sucesso")
            {
                if (lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "apagado";
                    MessageBox.Show("Este Registro acabou de ser excluido por outro usuário");
                }
                else
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


                    status = "editado";
                    this.obj.Nome = txtNome.Text;
                    this.obj.Sexo = cbSexo.Text;
                    this.obj.RG = rgpaciente;
                    this.obj.CPF = cpfpaciente;
                    this.obj.Nascimento = Convert.ToDateTime(dataNascimento);
                    this.obj.Email = txtEmail.Text;
                    obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    this.obj.CEP = txtCEP.Text;
                    this.obj.Endereco = enderecoCompleto;

                    service.Editar(this.obj);
                    this.Close();
                }
            }

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (ValidarExclusao())
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("Excluido com sucesso!");
                status = "apagado";
                this.Close();
            }
        }


        public bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("Deseja excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
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

        private void btnAbrirAnamnese_Click(object sender, EventArgs e)
        {
            //    Obter o ID do paciente 
            int idPaciente = int.Parse(lblCodigo.Text);

            //    Criar uma instância do serviço de anamnese
            AnamneseService serviceA = new AnamneseService();

            //    Buscar a anamnese do paciente pelo ID do paciente
            Anamnese anamnese = serviceA.Buscar(idPaciente);

            //    Verificar se a anamnese foi encontrada
            if (anamnese != null)
            {
                FrmEditarAnamnese frmEdtAnm = new FrmEditarAnamnese(anamnese);

                frmEdtAnm.lblCodigo.Text = lblCodigo.Text;
                frmEdtAnm.lblCodAnm.Text = anamnese.IdAnamnese.ToString();
                frmEdtAnm.txtNome.Text = txtNome.Text;
                frmEdtAnm.maskCPFPaciente.Text = masktxtCPFPaciente.Text;
                frmEdtAnm.ShowDialog();
            }
            else if(anamnese == null)
            {
                MessageBox.Show("O Paciente não possui Ficha Anamnese. Preencha e Salve a Ficha!");

                FrmAnamnese frmAnm = new FrmAnamnese();

                frmAnm.lblCodigo.Text = lblCodigo.Text;
                frmAnm.txtNome.Text = txtNome.Text;
                frmAnm.maskCPFPaciente.Text = masktxtCPFPaciente.Text;
                frmAnm.ShowDialog();
            }

        }

        private void btnAbrirOdontograma_Click(object sender, EventArgs e)
        {
            FrmOdontograma frm = new FrmOdontograma();
            frm.ShowDialog();
        }

        
    }
}
