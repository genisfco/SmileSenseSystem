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
    public partial class frmEditarConsulta : Form
    {
        Consulta consulta = new Consulta();
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        public frmEditarConsulta(Consulta c)
        {
            InitializeComponent();
            lblCodigo.Visible = false;
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

            string str_mensagem = string.Format("Paciente: {0}\r\n\r\nDentista: {1}\r\n\r\nAgendamento na Data: {2} e Hora: {3} ", cbPaciente.Text, cbDentista.Text, dtData.Value.ToShortDateString(), dtHora.Value.ToShortTimeString());

            DialogResult confirmacao = MessageBox.Show(str_mensagem, "Confirmação de Edição no Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

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

                try
                {                   
                    service.Editar(this.consulta);

                    MessageBox.Show("Consulta atualizada com Sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível atualizar a Consulta: ", ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";

            // Exibe uma mensagem de confirmação antes de excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a Consulta?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {                
                try
                {
                    service.Deletar(this.consulta.IdConsulta);
                    MessageBox.Show("Consulta excluída com sucesso!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível fazer a exclusão: ", ex.Message);
                }            
                
            }
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
