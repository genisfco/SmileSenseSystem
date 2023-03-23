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
    public partial class frmEditarConsulta : Form
    {
        Consulta consulta = new Consulta();
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        public frmEditarConsulta(Consulta c)
        {
            InitializeComponent();
            IniciarFormulario(c);
        }

        private void IniciarFormulario(Consulta c)
        {

            try
            {
                var lista = serviceD.Listar();
                var listaD = new Dictionary<int, string>();
                listaD.Add(0, "Selecione um Dentista");
                foreach (var item in lista)
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



            this.consulta = c;

            lblCodigo.Text = this.consulta.IdConsulta.ToString();
            cbPaciente.Text = serviceP.Buscar(this.consulta.IdPaciente).Nome;
            cbDentista.Text = serviceD.Buscar(this.consulta.IdDentista).Nome;
            dtData.Text = this.consulta.Data.ToString();
            dtHora.Text = this.consulta.HoraMarcada.ToString();
            dtInicio.Text = this.consulta.HoraInicio.ToString();
            dtFim.Text = this.consulta.HoraFim.ToString();
            txtAnotacoes.Text = this.consulta.Observacao;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if (ts.Text == "Sucesso")
            {

                this.consulta.IdPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
                this.consulta.IdDentista = Convert.ToInt32(cbDentista.SelectedValue);
                this.consulta.Data = Convert.ToDateTime(dtData.Text);
                this.consulta.HoraMarcada = Convert.ToDateTime(dtHora.Text);
                this.consulta.HoraInicio = Convert.ToDateTime(dtInicio.Text);
                this.consulta.HoraFim = Convert.ToDateTime(dtFim.Text);
                this.consulta.Observacao = txtAnotacoes.Text;
                service.Editar(this.consulta);
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (ValidarExclusao())
            {
                service.Deletar(this.consulta.IdConsulta);
                MessageBox.Show("Excluido com sucesso!");
                
                this.Close();
            }
        }

        private bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("Deseja excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }
    }
}
