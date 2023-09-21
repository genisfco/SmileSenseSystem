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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaOdonto
{
    public partial class FrmEditarAnamnese : Form
    {

        Anamnese obj = new Anamnese();
        AnamneseService serviceAnm = new AnamneseService();
        LoggerService loggerService = new LoggerService();


        public FrmEditarAnamnese(Anamnese obj)
        {
            InitializeComponent();
            lblCodIDPacte.Visible = false;
            lblCodIDAnm.Visible = false;
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(Anamnese objA)
        {
            // BUSCANDO OS DADOS DA TABELA
            this.obj = objA;

            // Mapeando os valores diretamente para os controles
            chboxDiabetesSIM.Checked = (obj.Diabetes == "S");
            chboxDiabetesNAO.Checked = (obj.Diabetes == "N");

            chboxHipertensaoSIM.Checked = (obj.Hipertensao == "S");
            chboxHipertensaoNAO.Checked = (obj.Hipertensao == "N");

            chboxCardiopatiaSIM.Checked = (obj.Cardiopatia == "S");
            chboxCardiopatiaNAO.Checked = (obj.Cardiopatia == "N");

            chboxUsoMedicamentosSIM.Checked = (obj.Uso_Continuo == "S");
            chboxUsoMedicamentosNAO.Checked = (obj.Uso_Continuo == "N");

            chboxAlergiaMedicamentosaSIM.Checked = (obj.Alergia_Medicamento == "S");
            chboxAlergiaMedicamentosaNAO.Checked = (obj.Alergia_Medicamento == "N");

            chboxProblHemorragSIM.Checked = (obj.Problemas_Hemorragicos == "S");
            chboxProblHemorragNAO.Checked = (obj.Problemas_Hemorragicos == "N");

            chboxComplOdontoSIM.Checked = (obj.Complicacoes_Odonto == "S");
            chboxComplOdontoNAO.Checked = (obj.Complicacoes_Odonto == "N");

            chboxDoencaCongSIM.Checked = (obj.Doenca_Cong == "S");
            chboxDoencaCongNAO.Checked = (obj.Doenca_Cong == "N");

            // Preenchendo os campos de texto
            txtUsoQualMedicamento.Text = obj.Medicamento_Continuo;
            txtAlergiaQualMedicamento.Text = obj.Alergia_Qual_Medicamento;
            txtMotivoProblemas.Text = obj.Motivo_Problemas;
            txtComplicacoes.Text = obj.Porque_Complicacoes;
            txtDoenca.Text = obj.Qual_Doenca;
        }

        private bool ValidarForm()
        {
            bool FormValido = true;

            if ((chboxDiabetesSIM.Checked && chboxDiabetesNAO.Checked) ||
                (chboxHipertensaoSIM.Checked && chboxHipertensaoNAO.Checked) ||
                (chboxCardiopatiaSIM.Checked && chboxCardiopatiaNAO.Checked) ||
                (chboxUsoMedicamentosSIM.Checked && chboxUsoMedicamentosNAO.Checked) ||
                (chboxAlergiaMedicamentosaSIM.Checked && chboxAlergiaMedicamentosaNAO.Checked) ||
                (chboxProblHemorragSIM.Checked && chboxProblHemorragNAO.Checked) ||
                (chboxComplOdontoSIM.Checked && chboxComplOdontoNAO.Checked) ||
                (chboxDoencaCongSIM.Checked && chboxDoencaCongNAO.Checked))
            {
                FormValido = false;
            }

            return FormValido;
        }

        private string ObterValorCheckBox(CheckBox checkBoxSim, CheckBox checkBoxNao)
        {
            if (checkBoxSim.Checked)
            {
                return "S";
            }
            else if (checkBoxNao.Checked)
            {
                return "N";
            }
            return "X";
        }

        private void AtualizarObjeto()
        {
            this.obj.Diabetes = ObterValorCheckBox(chboxDiabetesSIM, chboxDiabetesNAO);
            this.obj.Hipertensao = ObterValorCheckBox(chboxHipertensaoSIM, chboxHipertensaoNAO);
            this.obj.Cardiopatia = ObterValorCheckBox(chboxCardiopatiaSIM, chboxCardiopatiaNAO);
            this.obj.Uso_Continuo = ObterValorCheckBox(chboxUsoMedicamentosSIM, chboxUsoMedicamentosNAO);
            this.obj.Medicamento_Continuo = txtUsoQualMedicamento.Text;
            this.obj.Alergia_Medicamento = ObterValorCheckBox(chboxAlergiaMedicamentosaSIM, chboxAlergiaMedicamentosaNAO);
            this.obj.Alergia_Qual_Medicamento = txtAlergiaQualMedicamento.Text;
            this.obj.Problemas_Hemorragicos = ObterValorCheckBox(chboxProblHemorragSIM, chboxProblHemorragNAO);
            this.obj.Motivo_Problemas = txtMotivoProblemas.Text;
            this.obj.Complicacoes_Odonto = ObterValorCheckBox(chboxComplOdontoSIM, chboxComplOdontoNAO);
            this.obj.Porque_Complicacoes = txtComplicacoes.Text;
            this.obj.Doenca_Cong = ObterValorCheckBox(chboxDoencaCongSIM, chboxDoencaCongNAO);
            this.obj.Qual_Doenca = txtDoenca.Text;
        }

        private void btnAtualizarAnm_Click(object sender, EventArgs e)
        {
            //VERIFICANDO SE O FORM ESTÁ VALIDO
            if (!ValidarForm())
            {
                MessageBox.Show("Ficha Anamnese não preenchida corretamente. Verifique campos duplicados!", "Erro no preenchimento!");
            }
            else
            {
                try
                {
                    AtualizarObjeto();

                    serviceAnm.Editar(this.obj);
                    loggerService.Cadastrar(objLogGerado());
                    MessageBox.Show("Anamnese do Paciente Atualizada com Sucesso!", "Dados atualizados!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar " + ex.Message);
                }
            }
        }

        public Logger objLogGerado()
        {
            Logger objLog = new Logger();
            objLog.IDUser = Globais.Global.id;
            objLog.Data_Logger = DateTime.Now;
            objLog.Tipo_Logger = "Atualização";
            objLog.Tabela_Logger = "Anamnese";
            objLog.ID_Tabela = Convert.ToInt32(lblCodIDAnm.Text);

            return objLog;
        }

        private void btnFecharAnamnese_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
