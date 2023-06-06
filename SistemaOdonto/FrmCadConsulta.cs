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
    public partial class FrmCadConsulta : Form
    {

        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        public FrmCadConsulta()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            try
            {
                var lista = serviceD.Listar();
                var listaD = new Dictionary<int, string>();
                listaD.Add(0, "Selecione um Dentista");
                foreach(var item in lista)
                {
                    listaD.Add(item.Id, item.Nome);
                }
                cbDentista.DataSource = new BindingSource(listaD, null);
                cbDentista.DisplayMember = "value";
                cbDentista.ValueMember = "key";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }


            try
            {
                var lista2 = serviceP.Listar();
                var listaP = new Dictionary<int, string>();
                listaP.Add(0, "Selecione um Paciente");
                foreach (var item in lista2)
                {
                    listaP.Add(item.Id, item.Nome);
                }
                cbPaciente.DataSource = new BindingSource(listaP, null);
                cbPaciente.DisplayMember = "value";
                cbPaciente.ValueMember = "key";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }
        }



        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (Convert.ToInt32(cbDentista.SelectedValue) == 0)
            {
                return "Selecione um Dentista!";
            }
            
            else if (Convert.ToInt32(cbPaciente.SelectedValue) == 0)
            {
                return "Selecione um Paciente!";
            }

            else if (dtData.Text == String.Empty)
            {
                return "Escolha uma data!";
            }

            else if (dtData.Value < DateTime.Now.Date)
            {
                return "Escolha uma data válida!";
            }           

            else if (dtHora.Text == String.Empty)
            {
                return "Escolha o Horário!";
            }

            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }

        }
       

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.ShowDialog();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";

            string str_mensagem = string.Format("Paciente: {0}\r\n\r\nDentista: {1}\r\n\r\nAgendamento na Data: {2} e Hora: {3} ", cbPaciente.Text, cbDentista.Text, dtData.Value.ToShortDateString(), dtHora.Value.ToShortTimeString());            

            DialogResult confirmacao = MessageBox.Show(str_mensagem, "Confirmação de Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(confirmacao == DialogResult.No)
            {
                return;
            }            

            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Consulta Cadastrada com Sucesso");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }


        public Consulta objGerado()
        {
            Consulta obj = new Consulta();
            obj.IdDentista = Convert.ToInt32(cbDentista.SelectedValue);
            obj.IdPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
            obj.Data = Convert.ToDateTime(dtData.Value.ToString("dd/MM/yyyy"));
            obj.HoraMarcada = dtHora.Value;
            obj.HoraInicio = Convert.ToDateTime("00:00");
            obj.HoraFim = Convert.ToDateTime("00:00");
            obj.Observacao = txtAnotacoes.Text;
            obj.Status = "Nao confirmado";

            return obj;
        }

        private void masktxtCPFPaciente_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => masktxtCPFPaciente.Select(0, 0)));

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string cpf = masktxtCPFPaciente.Text;
            cpf = cpf.Replace(",", "").Replace("-", "");

            if (cpf.Length < 11 || cpf == "")
            {
                MessageBox.Show("Digite o CPF completo!");
                return;
            }

            try
            {
                Paciente paciente = serviceP.BuscarPorCPF(cpf);

                if (paciente == null) { MessageBox.Show("Paciente não localizado com este CPF."); return; }

                cbPaciente.Text = paciente.Nome.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível localizar os dados:" + ex.Message);
            }         

        }
    }
}
