﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdonto
{
    public partial class FrmPrincipal : Form
    {
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        public FrmPrincipal()
        {
            InitializeComponent();

            FrmLogin login = new FrmLogin(this);
            login.ShowDialog();

            IniciarFormulario();
            
            dg.Columns["Hora"].ReadOnly = true;
            dg.Columns["Paciente"].ReadOnly = true;

            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // para status
            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            imageLabels = new Label[pictureBoxes.Length];

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                PictureBox pictureBox = pictureBoxes[i];
                Label label = new Label();
                label.Text = imageMessages[i];
                label.ForeColor = Color.Blue;
                label.BackColor = Color.Transparent;
                label.AutoSize = true;
                label.Location = new Point(pictureBox.Location.X + 10, pictureBox.Location.Y + 10);
                label.Visible = false;
                Controls.Add(label);
                imageLabels[i] = label;

                pictureBox.MouseEnter += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
            }
        }

        // para status
        private PictureBox[] pictureBoxes;
        private Label[] imageLabels;
        private string[] imageMessages = { "Confirmado", "Em atendimento", "Não confirmado", "Já chegou", "Desmarcado" };

        // para status
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = Array.IndexOf(pictureBoxes, pictureBox);

            if (index >= 0 && index < imageLabels.Length)
            {
                Label label = imageLabels[index];
                label.Visible = true;
                label.BringToFront();
            }
        }
        // para status
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = Array.IndexOf(pictureBoxes, pictureBox);

            if (index >= 0 && index < imageLabels.Length)
            {
                Label label = imageLabels[index];
                label.Visible = false;
            }
        }

        private void IniciarFormulario()
        {
            atualizarCb();
        }

        private void atualizarCb()
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

                atualizarAgenda(Convert.ToInt32(cbDentista.SelectedValue));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }
        }

        private void atualizarAgenda(int id)
        {
            Dentista d = new Dentista();
            d = serviceD.Buscar(id);
            if(d != null)
            {
                dg.Rows.Clear();
                gerarConsulta(d);
            }
        }

        private void gerarConsulta(Dentista d)
        {
            var con = service.Buscar(d, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada);
            if(con == null)
            {
                MessageBox.Show("Este dentista não tem pacientes hoje!!");
            }
            else
            {
                foreach(var item in con)
                {
                    int linha = dg.Rows.Add();
                    dg.Rows[linha].Cells[0].Value = item.IdConsulta;
                    dg.Rows[linha].Cells[1].Value = item.HoraMarcada.Value.ToString("HH:mm");
                    dg.Rows[linha].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dg.Rows[linha].Cells[2].Value = serviceP.Buscar(item.IdPaciente).Nome;
                    dg.Rows[linha].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dg.Rows[linha].Cells[3].Value = imagemStatus(item.Status);
                    dg.Rows[linha].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dg.Rows[linha].Cells[4].Value = item.IdPaciente;
                }
                
            }
        }

        private Bitmap imagemStatus(string s)
        {
            var imagem = new Bitmap(Properties.Resources.Circle_Grey);
            switch (s)
            {
                case "Confirmado":
                    imagem = new Bitmap(Properties.Resources.Circle_Blue);
                    break;

                case "Desmarcado":
                    imagem = new Bitmap(Properties.Resources.Circle_Red);
                    break;

                case "Nao confirmado":
                    imagem = new Bitmap(Properties.Resources.Circle_Grey);
                    break;

                case "Ja chegou":
                    imagem = new Bitmap(Properties.Resources.Circle_Orange);
                    break;

                case "Em atendimento":
                    imagem = new Bitmap(Properties.Resources.Circle_Green);
                    break;

                default:
                    imagem = new Bitmap(Properties.Resources.address171);
                    break;
            }
            return imagem;
        }

        private void menuDentista_Click(object sender, EventArgs e)
        {
            FrmCadDentista frm = new FrmCadDentista();
            frm.ShowDialog();
        }


        private void menuPaciente_Click(object sender, EventArgs e)
        {
            FrmCadPaciente frm = new FrmCadPaciente();
            frm.ShowDialog();
        }    

        private void menuConsulta_Click(object sender, EventArgs e)
        {
            FrmCadConsulta frm = new FrmCadConsulta();
            frm.ShowDialog();
        }

        private void menuAgConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.ShowDialog();
        }

        private void menuSuporte_Click(object sender, EventArgs e)
        {
            frmSuporte frm = new frmSuporte();
            frm.ShowDialog();
        }               

        private void cbDentista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            atualizarAgenda(Convert.ToInt32(cbDentista.SelectedValue));
            
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DataGridView dg = sender as DataGridView;
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells[4].Value);
                Paciente p = serviceP.Buscar(id);
                FrmEditarPaciente frm = new FrmEditarPaciente(p);
                frm.Show();
            }
            if (e.ColumnIndex == 3 && e.RowIndex != -1 && dg.Rows[e.RowIndex].Cells[3].Value != null && dg.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
            {
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells[0].Value);
                Consulta c = service.Buscar(id);

                if (c != null)
                {
                    string s = c.Status;

                    switch (s)
                    {
                        case "Confirmado":
                            c.Status = "Desmarcado";
                            break;
                        case "Desmarcado":
                            c.Status = "Ja chegou";
                            break;
                        case "Ja chegou":
                            c.Status = "Em atendimento";
                            break;
                        case "Em atendimento":
                            c.Status = "Nao confirmado";
                            break;
                        case "Nao confirmado":
                            c.Status = "Confirmado";
                            break;
                        default:
                            c.Status = "Nao confirmado";
                            break;
                    }

                    service.Editar(c);
                    atualizarAgenda(Convert.ToInt32(cbDentista.SelectedValue));
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnotacoes frm = new FrmAnotacoes();
            frm.ShowDialog();

            RichTextBox post = new RichTextBox();
            post.ReadOnly = false;
            post.BorderStyle = BorderStyle.None;
            post.Font = new Font(FontFamily.GenericSansSerif, 15F);
            post.ForeColor = Color.FromArgb(64, 64, 64);
            post.Width = 150;
            post.Height = 150;
            post.BackColor = frm.cor;
            post.Text = frm.texto;
            anot.Controls.Add(post);

        }

        private void cbDentista_Click(object sender, EventArgs e)
        {
            atualizarCb();
        }

        private void menuDadosDentistas_Click(object sender, EventArgs e)
        {
            FrmDadosDentista frm = new FrmDadosDentista();
            frm.ShowDialog();
        }

        private void menuDadosPacientes_Click(object sender, EventArgs e)
        {
            FrmDadosPaciente frm = new FrmDadosPaciente();
            frm.ShowDialog();
        }

        private void stripNovoUser_Click(object sender, EventArgs e)
        {
            if (Globais.Global.logado == true)
            {
                if (Globais.Global.nivel == 3)
                {
                    FrmNovoUser abrirTelaNovoUser = new FrmNovoUser();
                    abrirTelaNovoUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }
        }

        private void stripGestaoUser_Click(object sender, EventArgs e)
        {
            if (Globais.Global.logado == true)
            {
                if (Globais.Global.nivel == 3)
                {
                    FrmGestaoUser abrirTelaGestaoUsers = new FrmGestaoUser();
                    abrirTelaGestaoUsers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }
        }

        private void MSair_Click(object sender, EventArgs e)
        {           
                                       
            DialogResult resultado = MessageBox.Show("Deseja sair da aplicação?", "Confirmação de saída",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                lb_Acesso.Text = "0";
                lb_NomeUsuario.Text = "---";
                pb_ledLogado.Image = Properties.Resources.Circle_Red;
                pnlBarraLogin.BackColor = Color.Red;
                    
                Globais.Global.id = 0;
                Globais.Global.nivel = 0;
                Globais.Global.logado = false;
                    
                Application.Exit();
            }                      
        }

        private void btnLimparNotes_Click(object sender, EventArgs e)
        {
            // Itera sobre todos os controles dentro do painel anot.Controls
            foreach (Control control in anot.Controls)
            {
                // Verifica se o controle é uma instância da classe RichTextBox
                if (control is RichTextBox)
                {
                    // Remove o controle
                    anot.Controls.Remove(control);
                }
            }
        }        

        private void MLogoff_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja deslogar do sistema?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Lógica para sair da aplicação
                lb_Acesso.Text = "0";
                lb_NomeUsuario.Text = "---";
                pb_ledLogado.Image = Properties.Resources.Circle_Red;
                pnlBarraLogin.BackColor = Color.Red;
                pnlBarraLogin.BackColor = Color.FromArgb(255, 160, 160);

                Globais.Global.id = 0;
                Globais.Global.nivel = 0;
                Globais.Global.logado = false;

                FrmLogin frmlogin = new FrmLogin(this);
                frmlogin.ShowDialog();
            }
                                             
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {            

            if (Globais.Global.logado == false)
            {
                MessageBox.Show("Nenhum Usuário logado!\r\nPor segurança, o sistema será encerrado", "Atenção");
                this.Close();
            }
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o Bloco de Notas: " + ex.Message);
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir a Calculadora: " + ex.Message);
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("winword.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o Microsoft Word: " + ex.Message);
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("excel.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o Microsoft Excel: " + ex.Message);
            }
        }

        private void stripRelatorios_Click(object sender, EventArgs e)
        {
            if (Globais.Global.logado == true)
            {
                if (Globais.Global.nivel == 3)
                {
                    FrmRelatorioLoggers abrirRelatorioUser = new FrmRelatorioLoggers();
                    abrirRelatorioUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }

        }
    }
}
