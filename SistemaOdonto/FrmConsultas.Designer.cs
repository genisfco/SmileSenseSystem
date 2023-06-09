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
            this.dtpDataMostrada = new System.Windows.Forms.DateTimePicker();
            this.tabControlAgenda = new System.Windows.Forms.TabControl();
            this.HomeAgenda = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarData = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControlAgenda.SuspendLayout();
            this.HomeAgenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataMostrada
            // 
            this.dtpDataMostrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataMostrada.Location = new System.Drawing.Point(158, 2);
            this.dtpDataMostrada.Name = "dtpDataMostrada";
            this.dtpDataMostrada.Size = new System.Drawing.Size(327, 26);
            this.dtpDataMostrada.TabIndex = 17;
            // 
            // tabControlAgenda
            // 
            this.tabControlAgenda.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAgenda.Controls.Add(this.HomeAgenda);
            this.tabControlAgenda.Location = new System.Drawing.Point(4, 32);
            this.tabControlAgenda.Multiline = true;
            this.tabControlAgenda.Name = "tabControlAgenda";
            this.tabControlAgenda.SelectedIndex = 0;
            this.tabControlAgenda.Size = new System.Drawing.Size(577, 497);
            this.tabControlAgenda.TabIndex = 14;
            this.tabControlAgenda.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlAgenda_Selecting);
            // 
            // HomeAgenda
            // 
            this.HomeAgenda.BackColor = System.Drawing.Color.White;
            this.HomeAgenda.Controls.Add(this.label2);
            this.HomeAgenda.Controls.Add(this.label1);
            this.HomeAgenda.Location = new System.Drawing.Point(23, 4);
            this.HomeAgenda.Name = "HomeAgenda";
            this.HomeAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.HomeAgenda.Size = new System.Drawing.Size(550, 489);
            this.HomeAgenda.TabIndex = 0;
            this.HomeAgenda.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta é a Agenda das Consultas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tabControlAgenda);
            this.panel1.Controls.Add(this.btnBuscarData);
            this.panel1.Controls.Add(this.btnAvancar);
            this.panel1.Controls.Add(this.dtpDataMostrada);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 532);
            this.panel1.TabIndex = 19;
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.BackColor = System.Drawing.Color.White;
            this.btnBuscarData.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarData.FlatAppearance.BorderSize = 2;
            this.btnBuscarData.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarData.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarData.Image = global::SistemaOdonto.Properties.Resources.find_file;
            this.btnBuscarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarData.Location = new System.Drawing.Point(487, 1);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(95, 27);
            this.btnBuscarData.TabIndex = 18;
            this.btnBuscarData.Text = "Buscar";
            this.btnBuscarData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarData.UseVisualStyleBackColor = false;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscarData_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.White;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvancar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnAvancar.FlatAppearance.BorderSize = 2;
            this.btnAvancar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAvancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Image = global::SistemaOdonto.Properties.Resources.iconedireita;
            this.btnAvancar.Location = new System.Drawing.Point(603, 32);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(44, 46);
            this.btnAvancar.TabIndex = 15;
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::SistemaOdonto.Properties.Resources.iconesquerda;
            this.btnVoltar.Location = new System.Drawing.Point(603, 85);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(44, 46);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(667, 538);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Consultas";
            this.tabControlAgenda.ResumeLayout(false);
            this.HomeAgenda.ResumeLayout(false);
            this.HomeAgenda.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}