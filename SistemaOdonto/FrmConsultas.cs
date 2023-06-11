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
    public partial class FrmConsultas : Form
    {
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        private Dictionary<int, DataGridView> DataGridViews = new Dictionary<int, DataGridView>();

        public FrmConsultas()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            var listaD = serviceD.Listar();
            foreach(var dentista in listaD)
            {
                tabControlAgenda.TabPages.Add(dentista.Id.ToString(), dentista.Nome);
                DataGridView dgv = new DataGridView();
                DataGridViews.Add(dentista.Id, dgv);
                GerarTabela(dgv);
                tabControlAgenda.TabPages[dentista.Id.ToString()].Controls.Add(dgv);
            }
        }

        private void GerarTabela(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Chocolate;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.Columns.Add("ColunaCodigoConsulta", "CodigoConsulta");
            dgv.Columns[0].Visible = false;
            dgv.Columns.Add("ColunaHora", "Horário");
            DataGridViewLinkColumn colPaciente = new DataGridViewLinkColumn();
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "ColunaNomePaciente";
            dgv.Columns.Add(colPaciente);
            dgv.Columns.Add("ColunaStatus", "Status");
            DataGridViewLinkColumn colConsulta = new DataGridViewLinkColumn();
            colConsulta.HeaderText = "";
            colConsulta.Name = "ColunaVerConsulta";
            dgv.Columns.Add(colConsulta);
            dgv.CellContentClick += new DataGridViewCellEventHandler(this.Tabela_Clicada);
            dgv.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.Cabecalho_Clicado);
        }

        private void Cabecalho_Clicado(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Desabilitar classificação temporariamente
            DataGridView dgv = (DataGridView)sender;
            dgv.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Reabilitar classificação após o evento ter sido acionado
            dgv.BeginInvoke(new Action(() =>
            {
                dgv.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
            }));
        }

        private void Tabela_Clicada(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
            {
                var idConsulta = dgv.Rows[e.RowIndex].Cells[0].Value;
                Consulta c = service.Buscar(Convert.ToInt32(idConsulta));

                try
                {
                    if (e.ColumnIndex == 2 && e.RowIndex != -1)
                    {
                        Paciente p = serviceP.Buscar(c.IdPaciente);
                        FrmEditarPaciente frm = new FrmEditarPaciente(p);
                        frm.ShowDialog();
                        AtualizarLinhas();
                    }
                    if (e.ColumnIndex == 4 && e.RowIndex != -1)
                    {
                        var Form = new frmEditarConsulta(c);
                        Form.ShowDialog();
                        AtualizarLinhas();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro, favor entrar em contato com o administrador do sistema", "Ops!");
                }
            }
        }


        public void GerarLinha(DataGridView dgv, int dentistaId)
        {
            var dentista = serviceD.Buscar(dentistaId);
            List<Consulta> consultas = service.Buscar(dentista, Convert.ToDateTime(dtpDataMostrada.Value.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada).ToList();

            foreach(var consulta in consultas)
            {
                int linhaAtual = dgv.Rows.Add();
                dgv.Rows[linhaAtual].Cells[0].Value = consulta.IdConsulta;
                dgv.Rows[linhaAtual].Cells[1].Value = consulta.HoraMarcada.Value.ToString("HH:mm");
                dgv.Rows[linhaAtual].Cells[2].Value = serviceP.Buscar(Convert.ToInt32(consulta.IdPaciente)).Nome;
                dgv.Rows[linhaAtual].Cells[3].Value = consulta.Status;
                dgv.Rows[linhaAtual].Cells[4].Value = "Ver Consulta";
            }
        }

        private void tabControlAgenda_Selecting(object sender, TabControlCancelEventArgs e)
        {
            AtualizarLinhas();
        }

        private void AtualizarLinhas()
        {
            if (tabControlAgenda.SelectedTab.Name != "HomeAgenda")
            {

                var indiceTab = Convert.ToInt32(tabControlAgenda.SelectedTab.Name);
                DataGridViews[indiceTab].Rows.Clear();
                GerarLinha(DataGridViews[indiceTab], indiceTab);
            }
        }

        private void btnBuscarData_Click(object sender, EventArgs e)
        {
            AtualizarLinhas();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            dtpDataMostrada.Value = dtpDataMostrada.Value.AddDays(1);
            AtualizarLinhas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dtpDataMostrada.Value = dtpDataMostrada.Value.AddDays(-1);
            AtualizarLinhas();
        }
    }
}
