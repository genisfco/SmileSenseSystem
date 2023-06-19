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


        public FrmEditarAnamnese(Anamnese obj)
        {
            InitializeComponent();
            lblCodigo.Visible = false;
            lblCodAnm.Visible = false;
            IniciarFormulario(obj);

        }

        private void IniciarFormulario(Anamnese objA)
        {
            //BUSCANDO OS DADOS DA TABELA
            this.obj = objA;

            string diabetes = this.obj.Diabetes.ToString();
            string hipertensao = this.obj.Hipertensao.ToString();
            string cardiopatia = this.obj.Cardiopatia.ToString();
            string uso_cont = this.obj.Uso_Continuo.ToString();
            string medic_cont = this.obj.Medicamento_Continuo.ToString();
            string alerg_medic = this.obj.Alergia_Medicamento.ToString();
            string alergqual_medic = this.obj.Alergia_Qual_Medicamento.ToString();
            string probl_hemor = this.obj.Problemas_Hemorragicos.ToString();
            string motivo_probl = this.obj.Motivo_Problemas.ToString();
            string compl_odont = this.obj.Complicacoes_Odonto.ToString();
            string porq_compl = this.obj.Porque_Complicacoes.ToString();
            string doen_cong = this.obj.Doenca_Cong.ToString();
            string qual_doen = this.obj.Qual_Doenca.ToString();
            
            //ANALISANDO OS DADOS PARA PREENCHER O FORMS
            if (diabetes == "S")
            {
                chboxDiabetesSIM.Checked = true;
            }
            else if (diabetes == "N")
            {
                chboxDiabetesNAO.Checked = true;
            }

            if (hipertensao == "S")
            {
                chboxHipertensaoSIM.Checked = true;
            }
            else if (hipertensao == "N")
            {
                chboxHipertensaoNAO.Checked = true;
            }

            if (cardiopatia == "S")
            {
                chboxCardiopatiaSIM.Checked = true;
            }
            else if (cardiopatia == "N")
            {
                chboxCardiopatiaNAO.Checked = true;
            }

            if (uso_cont == "S")
            {
                chboxUsoMedicamentosSIM.Checked = true;
            }
            else if (uso_cont == "N")
            {
                chboxUsoMedicamentosNAO.Checked = true;
            }

            if (alerg_medic == "S")
            {
                chboxAlergiaMedicamentosaSIM.Checked = true;
            }
            else if (alerg_medic == "N")
            {
                chboxAlergiaMedicamentosaNAO.Checked = true;
            }

            if (probl_hemor == "S")
            {
                chboxProblHemorragSIM.Checked = true;
            }
            else if (probl_hemor == "N")
            {
                chboxProblHemorragNAO.Checked = true;
            }

            if (compl_odont == "S")
            {
                chboxComplOdontoSIM.Checked = true;
            }
            else if (compl_odont == "N")
            {
                chboxComplOdontoNAO.Checked = true;
            }

            if (doen_cong == "S")
            {
                chboxDoencaCongSIM.Checked = true;
            }
            else if (doen_cong == "N")
            {
                chboxDoencaCongNAO.Checked = true;
            }

            txtUsoQualMedicamento.Text = medic_cont;
            txtAlergiaQualMedicamento.Text = alergqual_medic;
            txtMotivoProblemas.Text = motivo_probl;
            txtComplicacoes.Text = porq_compl;
            txtDoenca.Text = qual_doen;        

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


        private void btnAtualizarAnm_Click(object sender, EventArgs e)
        {
            //VERIFICANDO SE O FORM ESTÁ VALIDO
            if (ValidarForm() == false)
            {
                MessageBox.Show("Ficha Anamnese não preenchida corretamente. Verifique campos duplicados!", "Erro no preenchimento!");
            }
            else
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

                try
                {
                    this.obj.Diabetes = diabetes;
                    this.obj.Hipertensao = hipertensao;
                    this.obj.Cardiopatia = cardiopatia;
                    this.obj.Uso_Continuo = uso_continuo;
                    this.obj.Medicamento_Continuo = txtUsoQualMedicamento.Text;
                    this.obj.Alergia_Medicamento = alergia_medic;
                    this.obj.Alergia_Qual_Medicamento = txtAlergiaQualMedicamento.Text;
                    this.obj.Problemas_Hemorragicos = probl_hemorrag;
                    this.obj.Motivo_Problemas = txtMotivoProblemas.Text;
                    this.obj.Complicacoes_Odonto = compl_odonto;
                    this.obj.Porque_Complicacoes = txtComplicacoes.Text;
                    this.obj.Doenca_Cong = doenca_cong;
                    this.obj.Qual_Doenca = txtDoenca.Text;

                    serviceAnm.Editar(this.obj);
                    MessageBox.Show("Anamnese do Paciente Atualizada com Sucesso!", "Dados atualizados!");
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
