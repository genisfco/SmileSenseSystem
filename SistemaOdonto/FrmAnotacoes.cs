using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class FrmAnotacoes : Form
    {

        public string texto { get; set; }
        public Color cor { get; set; }

        public FrmAnotacoes()
        {
            InitializeComponent();
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(252, 254, 156);
            this.cor = Color.FromArgb(252, 254, 156);
        }

      



        private void btnAdicionarLembrete_Click(object sender, EventArgs e)
        {
            this.texto = richTextBox1.Text;
            this.Close();
        }

        private void btnLaranja_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 221, 178);
            this.cor = Color.FromArgb(255, 221, 178);
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(205, 240, 178);
            this.cor = Color.FromArgb(205, 240, 178);
        }

        private void btnRoxo_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(220, 156, 254);
            this.cor = Color.FromArgb(220, 156, 254);
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 175, 197);
            this.cor = Color.FromArgb(245, 175, 197);
        }
    }
}
