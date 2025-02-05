﻿using Entidades;
using Globais;
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
    public partial class FrmDadosPaciente : Form
    {

        PacienteService serviceP = new PacienteService();

        public FrmDadosPaciente()
        {
            InitializeComponent();
            IniciarForm();
        }

        public void IniciarForm()
        {
            var lista = serviceP.Listar();
            if (lista == null)
            {
                MessageBox.Show("Não existem dados cadastrados");
            }
            else
            {
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach (var dado in lista)
                {
                    char primeiraLetra = dado.Nome.Trim()[0];
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        numTabela = numTabela + 1;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }

                    letraAnterior = primeiraLetra;
                }

            }
        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";

            link.Name = "Nome";
            dg.Columns.Add(link);

            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.tb_click);
        }

        private void GerarLinha(DataGridView data, Paciente dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Nome;
            data.Rows[linhaAtual].Cells[2].Value = dado.Telefone.ToString("(00) 0000-0000");
            data.Rows[linhaAtual].Cells[3].Value = dado.Celular.ToString("(00) 00000-0000");
        }

        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;

                    Paciente obj = serviceP.Buscar(Convert.ToInt32(id));

                    var form = new FrmEditarPaciente(obj);
                    form.ShowDialog();

                    if (form.status == "apagado")
                    {
                        this.Close();
                        FrmDadosPaciente frm = new FrmDadosPaciente();
                        frm.ShowDialog();
                    }
                    if (form.status == "editado")
                    {
                        dg.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dg, obj);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o Paciente " + ex.Message);
            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string cpf = masktxtCPFPaciente.Text;
            cpf = cpf.Replace(",", "").Replace("-", "");

            if (cpf.Length <11 || cpf == "")
            {
                MessageBox.Show("Digite o CPF completo!");
                return;
            }            

            try
            {
                Paciente paciente = serviceP.BuscarPorCPF(cpf);

                if (paciente == null) { MessageBox.Show("Paciente não localizado com este CPF.", "Erro ao Localizar!"); return; }

                dgViewPaciente.Rows.Clear();
                dgViewPaciente.Rows[0].Cells[0].Value = paciente.Id;
                dgViewPaciente.Rows[0].Cells[1].Value = paciente.Nome;
                dgViewPaciente.Rows[0].Cells[2].Value = paciente.Telefone;
                dgViewPaciente.Rows[0].Cells[3].Value = paciente.Celular;
                dgViewPaciente.Rows[0].Cells[4].Value = paciente.Email;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível localizar os dados:"+ ex.Message);
            }           
        }

        private void masktxtCPFPaciente_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => masktxtCPFPaciente.Select(0, 0)));
        }

        private void dgViewPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi feito em uma linha válida
            if (e.RowIndex >= 0)
            {
                DataGridView dg = sender as DataGridView;

                // Verifica se existem dados na linha
                bool hasData = false;
                foreach (DataGridViewCell cell in dg.Rows[e.RowIndex].Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        hasData = true;
                        break;
                    }
                }

                // Retorna imediatamente se não houver dados na linha
                if (!hasData)
                {
                    return;
                }                

                var id = dg.Rows[e.RowIndex].Cells[0].Value;

                Paciente obj = serviceP.Buscar(Convert.ToInt32(id));

                var form = new FrmEditarPaciente(obj);
                form.ShowDialog();

                if (form.status == "apagado")
                {
                    this.Close();
                    FrmDadosPaciente frm = new FrmDadosPaciente();
                    frm.ShowDialog();
                }
                if (form.status == "editado")
                {
                    dg.Rows.RemoveAt(e.RowIndex);
                    GerarLinha(dg, obj);
                }
            }
        }
    }
}
