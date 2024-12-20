﻿using Entidades;
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
        LoggerService serviceLog = new LoggerService();

        public FrmEditarPaciente(Paciente obj)
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
            cbSexo.TextChanged += ControleAlterado;
            cbDia.TextChanged += ControleAlterado;
            cbMes.TextChanged += ControleAlterado;
            cbAno.TextChanged += ControleAlterado;            
            txtEmail.TextChanged += ControleAlterado;
            txtTelefone.TextChanged += ControleAlterado;
            txtCelular.TextChanged += ControleAlterado;
            txtCEP.TextChanged += ControleAlterado;
            txtEndereco.TextChanged += ControleAlterado;
            txtNum.TextChanged += ControleAlterado;
            txtBairro.TextChanged += ControleAlterado;
            txtCidade.TextChanged += ControleAlterado;
            txtUF.TextChanged += ControleAlterado;
        }

        private void ControleAlterado(object sender, EventArgs e)
        {
            // Habilitar o botão de Edição quando um controle for alterado
            btnEditar.Enabled = true;
        }
    

        private void IniciarFormulario(Paciente objP)
        {
            this.obj = objP;

            // Verificar se o objeto é nulo
            if (this.obj != null)
            {
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
            else
            {
                MessageBox.Show("Não foi possível localizar os dados do Paciente!");
            }            
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
                    MessageBox.Show("Este Registro foi excluído por outro usuário", "Atenção!");
                }
                else
                {
                    //GUARDANDO OS DADOS ANTIGOS
                    string nomeAnt = this.obj.Nome;
                    string sexoAnt = this.obj.Sexo;
                    DateTime nascimentoAnt = this.obj.Nascimento;
                    string emailAnt = this.obj.Email;
                    string cepAnt = this.obj.CEP;
                    Int64 foneAnt = this.obj.Telefone;
                    Int64 celAnt = this.obj.Celular;
                    string endAnt = this.obj.Endereco;
                    
                    //GUARDANDO OS NOVOS DADOS
                    string dataNascimento = $"{cbAno.Text}-{cbMes.SelectedIndex + 1:00}-{cbDia.Text:00}";
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

                    // COMPARANDO os novos valores com os valores antigos
                    string observacao = "Dados atualizados: ";

                    if (this.obj.Nome != nomeAnt)
                    {
                        observacao += "Nome; ";
                    }
                    if (this.obj.Sexo != sexoAnt)
                    {
                        observacao += "Sexo; ";
                    }
                    if (this.obj.Nascimento != nascimentoAnt)
                    {
                        observacao += "Data Nascimento; ";
                    }
                    if (this.obj.Email != emailAnt)
                    {
                        observacao += "Email; ";
                    }
                    if (this.obj.CEP != cepAnt)
                    {
                        observacao += "CEP; ";
                    }
                    if (this.obj.Telefone != foneAnt)
                    {
                        observacao += "Telefone; ";
                    }
                    if (this.obj.Celular != celAnt)
                    {
                        observacao += "Celular; ";
                    }
                    if (this.obj.Endereco != endAnt)
                    {
                        observacao += "Endereço; ";
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
            objLog.Tabela_Logger = "Paciente";
            objLog.ID_Tabela = Convert.ToInt32(lblCodigo.Text) ;
            objLog.Observacao = observacao;

            return objLog;
        }

        private void masktxtRGPaciente_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => masktxtRGPaciente.Select(0, 0)));
        }

        private void masktxtCPFPaciente_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => masktxtCPFPaciente.Select(0, 0)));
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Select(0, 0);
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => txtCEP.Select(0, 0)));
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

        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            txtEndereco.Select(0, 0);
        }

        private void txtNum_Enter(object sender, EventArgs e)
        {
            txtNum.Select(0, 0);
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            txtBairro.Select(0, 0);
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            txtCidade.Select(0, 0);
        }

        private void txtUF_Enter(object sender, EventArgs e)
        {
            txtUF.Select(0, 0);
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
            //else if (txtTelefone.Text == string.Empty)
            //{
            //    return "Preencha o campo Telefone";
            //}
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

            // Exibe uma mensagem de confirmação antes de excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Paciente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    tsNenhuma.Text = "";                    

                    service.Deletar(this.obj.Id);

                    string tipoLogger = "Deleção";
                    string observacao = this.obj.Nome;
                    serviceLog.Cadastrar(objLogGerado(tipoLogger, observacao));

                    MessageBox.Show("Paciente Excluído com sucesso!", "Ação Realizada!");
                    status = "apagado";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível fazer a exclusão: ", ex.Message);
                }
            }
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

                frmEdtAnm.lblCodIDPacte.Text = lblCodigo.Text;
                frmEdtAnm.lblCodIDAnm.Text = anamnese.IdAnamnese.ToString();
                frmEdtAnm.txtNome.Text = txtNome.Text;
                frmEdtAnm.maskCPFPaciente.Text = masktxtCPFPaciente.Text;
                frmEdtAnm.ShowDialog();
            }
            else if(anamnese == null)
            {
                MessageBox.Show("O Paciente não possui Ficha Anamnese. Preencha e Salve a Ficha!", "Atenção!");

                FrmAnamnese frmAnm = new FrmAnamnese();

                frmAnm.lblCodigoIDPacte.Text = lblCodigo.Text;
                frmAnm.txtNome.Text = txtNome.Text;
                frmAnm.maskCPFPaciente.Text = masktxtCPFPaciente.Text;
                frmAnm.ShowDialog();
            }
        }

        private void btnAbrirOdontograma_Click(object sender, EventArgs e)
        {
            //    Obter o ID do paciente 
            int idPaciente = int.Parse(lblCodigo.Text);

            //Buscar odontograma pelo IdPaciente
            OdontogramaService serviceO = new OdontogramaService();
            Odontograma odontograma = serviceO.BuscarOdtPorIdPaciente(idPaciente);


            //    Verificar se a Odontograma foi encontrado
            if (odontograma != null)
            {

                //Obter o ID Odontograma
                int idOdontograma = odontograma.IdOdontograma;

                ProcedimentoService serviceP = new ProcedimentoService();
                Procedimento procedimento = serviceP.BuscarProcdporIdOdt(idOdontograma);

                FrmEditarOdtProcedimentos frmEdtOdtProcd = new FrmEditarOdtProcedimentos(odontograma, procedimento);
                frmEdtOdtProcd.lblCodigo.Text = lblCodigo.Text;
                frmEdtOdtProcd.txtNome.Text = txtNome.Text;
                frmEdtOdtProcd.masktxtCPFPaciente.Text = masktxtCPFPaciente.Text;
                frmEdtOdtProcd.ShowDialog();

            }
            else if (odontograma == null)
            {
                MessageBox.Show("O Paciente não possui Odontograma cadastrado. Preencha e Salve a Ficha!", "Atenção!");

                FrmOdtProcedimentos frmOdtProcd = new FrmOdtProcedimentos();
                frmOdtProcd.lblCodigo.Text = lblCodigo.Text;
                frmOdtProcd.txtNome.Text = txtNome.Text;
                frmOdtProcd.masktxtCPFPaciente.Text = masktxtCPFPaciente.Text;
                frmOdtProcd.ShowDialog();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                // Converte o caractere para maiúscula antes de permitir que ele seja inserido.
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
