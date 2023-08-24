using Globais;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WcfService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaOdonto
{
    public partial class FrmRelatorioLoggers : Form
    {
        public static string ConnectionString { get; set; }

        DentistaService serviceDent = new DentistaService();
        PacienteService servicePcte = new PacienteService();

        public FrmRelatorioLoggers()
        {
            InitializeComponent();
            PreencherComboBoxTipo();

            comboxUsuarios.SelectedIndex = 0;
            comboxSobre.SelectedIndex = 0;  

            chboxBuscaespec.Enabled = false;
            comboxBuscaespec.Enabled = false;
            dtInicio.Enabled = false;   
            dtFinal.Enabled = false;

            dataGridRelatorio.AutoGenerateColumns = true; // Isso permite que as colunas sejam geradas automaticamente com base nos dados
            dataGridRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajusta automaticamente o tamanho das colunas
        }

        private DataTable GetReportData(string consultaSQL)
        {
            DataTable reportData = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, connection);
                adapter.Fill(reportData);
            }
            return reportData;
        }

        private void PreencherComboBoxTipo()
        {
            // Criar uma lista de itens
            string[] itens = { "Todos", "Cadastro", "Atualização", "Deleção"};

            // Adicionar a lista de itens à ComboBox
            comboxTipo.Items.Clear();
            comboxTipo.Items.AddRange(itens);
            comboxTipo.SelectedIndex = 0;
        }

        private void FrmAcoesUser_Load(object sender, EventArgs e)
        {
            ListarUsuarios();            
        }

        private void ListarUsuarios()
        {
            try
            {
                DataTable usuariosTable = Globais.RepositUser.ObterUsuariosIdNome();               

                DataTable dt = new DataTable();
                dt.Columns.Add("ID Usuário", typeof(int)); // Define a coluna para o ID do usuário
                dt.Columns.Add("Nome Usuário", typeof(string)); // Define a coluna para o nome do usuário

                // Adicionar o item "Todos" ao novo DataTable
                dt.Rows.Add(0, "Todos");

                // Adicionar os dados do DataTable original à frente do novo DataTable
                foreach (DataRow row in usuariosTable.Rows)
                {
                    dt.ImportRow(row);
                }

                //comboxUsuarios.DataSource = null;
                comboxUsuarios.Items.Clear();

                // Adicionar os dados do novo DataTable à ComboBox
                comboxUsuarios.DataSource = dt;
                comboxUsuarios.DisplayMember = "Nome Usuário"; // Define a coluna a ser exibida na ComboBox
                comboxUsuarios.ValueMember = "ID Usuário"; // Define a coluna com o valor associado a cada item

                // Opcional: Selecionar o primeiro item da lista (no caso, "Todos")
                comboxUsuarios.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Usuários!" + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chboxData_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxData.Checked)
            {
                dtInicio.Enabled=true;
                dtFinal.Enabled=true;
            }
            else if (!chboxData.Checked)
            {
                dtInicio.Enabled = false;
                dtFinal.Enabled = false;
            }
        }

        private void chboxBuscaespec_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxBuscaespec.Checked)
            {
                comboxBuscaespec.Enabled=true;
            }
            else if (!chboxBuscaespec.Checked)
            {
                comboxBuscaespec.Enabled=false;
            }
        }

        private void cboxSobre_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboxSobre.SelectedItem.ToString())
            {
                case "Paciente":
                    chboxBuscaespec.Enabled = true;

                    try
                    {
                        var lista = servicePcte.Listar();
                        var listaPcte = new Dictionary<int, string>();
                        //listaPcte.Add(0, "Selecione um Paciente");
                        foreach (var item in lista)
                        {
                            listaPcte.Add(item.Id, item.Nome);
                        }
                        comboxBuscaespec.DataSource = new BindingSource(listaPcte, null);
                        comboxBuscaespec.DisplayMember = "value";
                        comboxBuscaespec.ValueMember = "key";

                        PreencherComboBoxTipo();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar a lista de Pacientes!" + ex.Message);
                    }

                    break;

                case "Dentista":
                    chboxBuscaespec.Enabled = true;

                    try
                    {
                        var lista = serviceDent.Listar();
                        var listaDent = new Dictionary<int, string>();
                        listaDent.Add(0, "Selecione um Dentista");

                        foreach (var item in lista)
                        {
                            listaDent.Add(item.Id, item.Nome);
                        }
                        comboxBuscaespec.DataSource = new BindingSource(listaDent, null);
                        comboxBuscaespec.DisplayMember = "value";
                        comboxBuscaespec.ValueMember = "key";

                        PreencherComboBoxTipo();
                    }
                    catch (System.Exception ex)
                    {

                        MessageBox.Show("Erro ao carregar a lista de Dentistas!" + ex.Message);
                    }

                    break;

                case "Consulta":
                    chboxBuscaespec.Enabled = false;
                    chboxBuscaespec.Checked = false;
                    comboxBuscaespec.DataSource = null;
                    comboxBuscaespec.Items.Clear();

                    PreencherComboBoxTipo();

                    break;

                case "Anamnese":
                    chboxBuscaespec.Enabled = false;
                    chboxBuscaespec.Checked = false;
                    comboxBuscaespec.DataSource = null;
                    comboxBuscaespec.Items.Clear();

                    comboxTipo.Items.Clear();
                    comboxTipo.Items.Add("Todos");
                    comboxTipo.Items.Add("Cadastro");
                    comboxTipo.Items.Add("Atualização");
                    comboxTipo.SelectedIndex = 0;

                    break;

                case "Procedimento":
                    chboxBuscaespec.Enabled = false;
                    chboxBuscaespec.Checked = false;
                    comboxBuscaespec.DataSource = null;
                    comboxBuscaespec.Items.Clear();

                    comboxTipo.Items.Clear();
                    comboxTipo.Items.Add("Cadastro");
                    comboxTipo.SelectedIndex = 0;

                    break;

                case "Usuário":
                    chboxBuscaespec.Enabled = false;
                    chboxBuscaespec.Checked = false;
                    comboxBuscaespec.DataSource = null;
                    comboxBuscaespec.Items.Clear();

                    PreencherComboBoxTipo();

                    break;

                default:
                    chboxBuscaespec.Enabled = false;
                    chboxBuscaespec.Checked = false;
                    comboxBuscaespec.DataSource = null;
                    comboxBuscaespec.Items.Clear();

                    PreencherComboBoxTipo();

                    break;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            dataGridRelatorio.DataSource = null;

            // Obtenha os valores selecionados nos filtros
            string usuario = comboxUsuarios.SelectedValue.ToString();
            string tipoRegistro = comboxTipo.SelectedItem.ToString();
            string tabela = comboxSobre.SelectedItem.ToString();
            int referenciaTabela = chboxBuscaespec.Checked ? Convert.ToInt32(comboxBuscaespec.SelectedValue) : 0;
            DateTime? dataInicio = chboxData.Checked ? dtInicio.Value : (DateTime?)null;
            DateTime? dataFim = chboxData.Checked ? dtFinal.Value : (DateTime?)null;

            //VALIDANDO AS DATAS
            if (dataInicio.HasValue && dataFim.HasValue)
            {
                if (dataInicio.Value == dataFim.Value || dataInicio.Value < dataFim.Value)
                {
                    dataInicio = dataInicio.Value.Date.AddHours(00).AddMinutes(00).AddSeconds(00);
                    dataFim = dataFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                }               

                else if (dataInicio.Value > dataFim.Value)
                {
                    MessageBox.Show("A Data de Início não pode ser maior que a Data Final. Por Favor, Verifique os campos!", "Datas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
            }

            // Use esses valores para construir sua consulta SQL e obter os dados do relatório
            string consultaSQL = BuildReportQuery(usuario, tipoRegistro, tabela, referenciaTabela, dataInicio, dataFim);

            //MessageBox.Show(consultaSQL); //PARA TESTAR A STRING QUERY DE CONSULTA

            DataTable reportData = GetReportData(consultaSQL);

            dataGridRelatorio.DataSource = reportData;
        }        

        private string BuildReportQuery(string usuario, string tipoRegistro, string tabela, int referenciaTabela, DateTime? dataInicio, DateTime? dataFim)
        {
            string query = "SELECT * FROM Loggers WHERE 1 = 1";

            if (usuario.ToString() != "0") //Usuário foi selecionado no filtro de busca
            {
                query += $" AND ID_USUARIO = {usuario}"; // retorna a busca com o id do usuário selecionado
            }

            if (!string.IsNullOrEmpty(tipoRegistro) && tipoRegistro != "Todos")
            {
                query += $" AND TIPO_LOGGER = '{tipoRegistro}'";
            }

            if (!string.IsNullOrEmpty(tabela) && tabela != "Todos")
            {
                query += $" AND TABELA = '{tabela}'";
            }

            if (referenciaTabela != 0)
            {
                query += $" AND ID_TABELA = {referenciaTabela}";
            }

            if (dataInicio.HasValue)
            {
                query += $" AND DATA_LOGGER >= '{dataInicio.Value.ToString("dd-MM-yyyy HH:mm")}'";
            }

            if (dataFim.HasValue)
            {
                query += $" AND DATA_LOGGER <= '{dataFim.Value.ToString("dd-MM-yyyy HH:mm")}'";
            }
            return query;
        }        
    }
}
