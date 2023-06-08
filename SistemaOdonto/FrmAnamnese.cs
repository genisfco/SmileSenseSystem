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

        public FrmAnamnese()
        {
            InitializeComponent();
            lblCodigo.Visible = false;
        } 
        

        private bool ValidarForm()
        {
            /// FAZ A VALIDAÇÃO DO FORMULÁRIO ANAMNESE, PARA VERIFICAR SE FOI PREENCHIDO CORRETAMENTE.
            bool FormValido;

            if (chboxDiabetesSIM.Checked == true && chboxDiabetesNAO.Checked == true)
                FormValido = false;
            else if (chboxHipertensaoSIM.Checked == true && chboxHipertensaoNAO.Checked == true)
                FormValido = false;
            else if (chboxCardiopatiaSIM.Checked == true && chboxCardiopatiaNAO.Checked == true)
                FormValido = false;
            else if (chboxUsoMedicamentosSIM.Checked == true && chboxUsoMedicamentosNAO.Checked == true)
                FormValido = false;
            else if (chboxAlergiaMedicamentosaSIM.Checked == true && chboxAlergiaMedicamentosaNAO.Checked == true)
                FormValido = false;
            else if (chboxProblHemorragSIM.Checked == true && chboxProblHemorragNAO.Checked == true)
                FormValido = false;
            else if (chboxComplOdontoSIM.Checked == true && chboxComplOdontoNAO.Checked == true)
                FormValido = false;
            else if (chboxDoencaCongSIM.Checked == true && chboxDoencaCongNAO.Checked == true)
                FormValido = false;
            else
                FormValido = true;
            return FormValido;
        }
        

        public Anamnese ObjGerado()
        {
                string diabetes = "X";
                string hipertensao = "X";
                string cardiopatia = "X";
                string uso_continuo = "X";
                string alergia_medic = "X";
                string probl_hemorrag = "X";
                string compl_odonto = "X";
                string doenca_cong = "X";

                if (chboxDiabetesSIM.Checked == true && chboxDiabetesNAO.Checked == false)
                {
                    diabetes = "S";
                }
                else if (chboxDiabetesSIM.Checked == false && chboxDiabetesNAO.Checked == true)
                {
                    diabetes = "N";
                }

                if (chboxHipertensaoSIM.Checked == true && chboxHipertensaoNAO.Checked == false)
                {
                    hipertensao = "S";
                }
                else if (chboxHipertensaoSIM.Checked == false && chboxHipertensaoNAO.Checked == true)
                {
                    hipertensao = "N";
                }

                if (chboxCardiopatiaSIM.Checked == true && chboxCardiopatiaNAO.Checked == false)
                {
                    cardiopatia = "S";
                }
                else if (chboxCardiopatiaSIM.Checked == false && chboxCardiopatiaNAO.Checked == true)
                {
                    cardiopatia = "N";
                }

                if (chboxUsoMedicamentosSIM.Checked == true && chboxUsoMedicamentosNAO.Checked == false)
                {
                    uso_continuo = "S";
                }
                else if (chboxUsoMedicamentosSIM.Checked == false && chboxUsoMedicamentosNAO.Checked == true)
                {
                    uso_continuo = "N";
                }

                if (chboxAlergiaMedicamentosaSIM.Checked == true && chboxAlergiaMedicamentosaNAO.Checked == false)
                {
                    alergia_medic = "S";
                }
                else if (chboxAlergiaMedicamentosaSIM.Checked == false && chboxAlergiaMedicamentosaNAO.Checked == true)
                {
                    alergia_medic = "N";
                }

                if (chboxProblHemorragSIM.Checked == true && chboxProblHemorragNAO.Checked == false)
                {
                    probl_hemorrag = "S";
                }
                else if (chboxProblHemorragSIM.Checked == false && chboxProblHemorragNAO.Checked == true)
                {
                    probl_hemorrag = "N";
                }

                if (chboxComplOdontoSIM.Checked == true && chboxComplOdontoNAO.Checked == false)
                {
                    compl_odonto = "S";
                }
                else if (chboxComplOdontoSIM.Checked == false && chboxComplOdontoNAO.Checked == true)
                {
                    compl_odonto = "N";
                }

                if (chboxDoencaCongSIM.Checked == true && chboxDoencaCongNAO.Checked == false)
                {
                    doenca_cong = "S";
                }
                else if (chboxDoencaCongSIM.Checked == false && chboxDoencaCongNAO.Checked == true)
                {
                    doenca_cong = "N";
                }

                //GERANDO O OBJETO PARA CADASTRAR NO BANCO.
                Anamnese objAnm = new Anamnese();
                objAnm.IdPaciente = Convert.ToInt32(lblCodigo.Text);
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

        private void btnSalvarAnamnese_Click(object sender, EventArgs e)
        {
            //VERIFICANDO SE O FORM ESTÁ VALIDO
            if (ValidarForm() == false)
            {
                MessageBox.Show("Ficha Anamnese não preenchida corretamente. Verifique campos duplicados!");
            }
            else
            {
                try
                {
                    serviceAnm.Cadastrar(ObjGerado());
                    MessageBox.Show("Anamnese do Paciente Cadastrada com Sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar " + ex.Message);
                }
            }            
        }

        private void btnFecharAnamnese_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
