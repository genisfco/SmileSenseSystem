namespace SistemaOdonto
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.btnBuscarData = new System.Windows.Forms.Button();
            this.dtpDataMostrada = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.tabControlAgenda = new System.Windows.Forms.TabControl();
            this.HomeAgenda = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlAgenda.SuspendLayout();
            this.HomeAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarData.ForeColor = System.Drawing.Color.White;
            this.btnBuscarData.Location = new System.Drawing.Point(748, 14);
            this.btnBuscarData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(112, 42);
            this.btnBuscarData.TabIndex = 18;
            this.btnBuscarData.Text = "Buscar";
            this.btnBuscarData.UseVisualStyleBackColor = false;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscarData_Click);
            // 
            // dtpDataMostrada
            // 
            this.dtpDataMostrada.Location = new System.Drawing.Point(412, 18);
            this.dtpDataMostrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataMostrada.Name = "dtpDataMostrada";
            this.dtpDataMostrada.Size = new System.Drawing.Size(338, 26);
            this.dtpDataMostrada.TabIndex = 17;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(896, 195);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(66, 71);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.White;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvancar.Location = new System.Drawing.Point(896, 114);
            this.btnAvancar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(66, 71);
            this.btnAvancar.TabIndex = 15;
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // tabControlAgenda
            // 
            this.tabControlAgenda.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAgenda.Controls.Add(this.HomeAgenda);
            this.tabControlAgenda.Location = new System.Drawing.Point(-4, 65);
            this.tabControlAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlAgenda.Multiline = true;
            this.tabControlAgenda.Name = "tabControlAgenda";
            this.tabControlAgenda.SelectedIndex = 0;
            this.tabControlAgenda.Size = new System.Drawing.Size(866, 765);
            this.tabControlAgenda.TabIndex = 14;
            this.tabControlAgenda.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlAgenda_Selecting);
            // 
            // HomeAgenda
            // 
            this.HomeAgenda.BackColor = System.Drawing.Color.White;
            this.HomeAgenda.Controls.Add(this.label2);
            this.HomeAgenda.Controls.Add(this.label1);
            this.HomeAgenda.Location = new System.Drawing.Point(28, 4);
            this.HomeAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeAgenda.Name = "HomeAgenda";
            this.HomeAgenda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeAgenda.Size = new System.Drawing.Size(834, 757);
            this.HomeAgenda.TabIndex = 0;
            this.HomeAgenda.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(698, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta é a Agenda das Consultas";
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 877);
            this.Controls.Add(this.btnBuscarData);
            this.Controls.Add(this.dtpDataMostrada);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.tabControlAgenda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Consultas";
            this.tabControlAgenda.ResumeLayout(false);
            this.HomeAgenda.ResumeLayout(false);
            this.HomeAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarData;
        private System.Windows.Forms.DateTimePicker dtpDataMostrada;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.TabControl tabControlAgenda;
        private System.Windows.Forms.TabPage HomeAgenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}