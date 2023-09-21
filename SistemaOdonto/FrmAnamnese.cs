using Entidades;
using SistemaOdonto.WSCorreios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WcfService;
using Exception = System.Exception;


namespace SistemaOdonto
{
    public partial class FrmAnamnese : Form
    {
        AnamneseService serviceAnm = new AnamneseService();
        LoggerService serviceLog = new LoggerService();

        public FrmAnamnese()
        {
            InitializeComponent();
            lblCodigoIDPacte.Visible = false;
        }

        private bool ValidarForm()
        {
            /// FAZ A VALIDAÇÃO DO FORMULÁRIO ANAMNESE, PARA VERIFICAR SE FOI PREENCHIDO CORRETAMENTE.
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
            return "X"; // Valor padrão caso nenhum esteja marcado
        }

        private Anamnese GerarAnamnese()
        {
            string diabetes = ObterValorCheckBox(chboxDiabetesSIM, chboxDiabetesNAO);
            string hipertensao = ObterValorCheckBox(chboxHipertensaoSIM, chboxHipertensaoNAO);
            string cardiopatia = ObterValorCheckBox(chboxCardiopatiaSIM, chboxCardiopatiaNAO);
            string uso_continuo = ObterValorCheckBox(chboxUsoMedicamentosSIM, chboxUsoMedicamentosNAO);
            string alergia_medic = ObterValorCheckBox(chboxAlergiaMedicamentosaSIM, chboxAlergiaMedicamentosaNAO);
            string probl_hemorrag = ObterValorCheckBox(chboxProblHemorragSIM, chboxProblHemorragNAO);
            string compl_odonto = ObterValorCheckBox(chboxComplOdontoSIM, chboxComplOdontoNAO);
            string doenca_cong = ObterValorCheckBox(chboxDoencaCongSIM, chboxDoencaCongNAO);

            //GERANDO O OBJETO PARA CADASTRAR NO BANCO.
            Anamnese objAnm = new Anamnese();
            objAnm.IdPaciente = Convert.ToInt32(lblCodigoIDPacte.Text);
            objAnm.Diabetes = diabetes;
            objAnm.Hipertensao = hipertensao;
            objAnm.Cardiopatia = cardiopatia;
            objAnm.Uso_Continuo = uso_continuo;
            objAnm.Medicamento_Continuo = txtUsoQualMedicamento.Text;
            objAnm.Alergia_Medicamento = alergia_medic;
            objAnm.Alergia_Qual_Medicamento = txtAlergiaQualMedicamento.Text;
            objAnm.Problemas_Hemorragicos = probl_hemorrag;
            objAnm.Motivo_Problemas = txtMotivoProblemas.Text;
            objAnm.Complicacoes_Odonto = compl_odonto;
            objAnm.Porque_Complicacoes = txtComplicacoes.Text;
            objAnm.Doenca_Cong = doenca_cong;
            objAnm.Qual_Doenca = txtDoenca.Text;

            return objAnm;
        }

        private async void btnSalvarAnamnese_Click(object sender, EventArgs e)
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
                    Anamnese objAnamnese = GerarAnamnese();

                    int anamneseID = await serviceAnm.Cadastrar(objAnamnese);
                    MessageBox.Show("Anamnese do Paciente Cadastrada com Sucesso!", "Cadastro realizado!");

                    string observacao = txtNome.Text;
                    serviceLog.Cadastrar(objLogGerado(anamneseID, observacao));
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar " + ex.Message);
                }
            }
        }

        public Logger objLogGerado(int anamnID, string observacao)
        {
            Logger objLog = new Logger();
            objLog.IDUser = Globais.Global.id;
            objLog.Data_Logger = DateTime.Now;
            objLog.Tipo_Logger = "Cadastro";
            objLog.Tabela_Logger = "Anamnese";
            objLog.ID_Tabela = anamnID;
            objLog.Observacao = observacao;

            return objLog;
        }

        private void btnFecharAnamnese_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
