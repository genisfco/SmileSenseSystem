namespace SistemaOdonto
{
    partial class FrmCadConsulta
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
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.masktxtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPaciente
            // 
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(11, 87);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(213, 21);
            this.cbPaciente.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Paciente:";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(281, 88);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(143, 20);
            this.dtData.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Data:";
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Location = new System.Drawing.Point(13, 196);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(410, 75);
            this.txtAnotacoes.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Anotações:";
            // 
            // cbDentista
            // 
            this.cbDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbDentista.Location = new System.Drawing.Point(11, 137);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(213, 21);
            this.cbDentista.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Dentista:";
            // 
            // dtHora
            // 
            this.dtHora.CustomFormat = "HH:mm";
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHora.Location = new System.Drawing.Point(281, 138);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(143, 20);
            this.dtHora.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hora:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts,
            this.tsNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(6, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(416, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts
            // 
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(69, 17);
            this.ts.Text = "Mensagem:";
            // 
            // tsNenhuma
            // 
            this.tsNenhuma.Name = "tsNenhuma";
            this.tsNenhuma.Size = new System.Drawing.Size(60, 17);
            this.tsNenhuma.Text = "Nenhuma";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalvar.FlatAppearance.BorderSize = 3;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::SistemaOdonto.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(13, 306);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 44);
            this.btnSalvar.TabIndex = 60;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.White;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnConsulta.FlatAppearance.BorderSize = 3;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Image = global::SistemaOdonto.Properties.Resources.find_file;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(281, 306);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(141, 44);
            this.btnConsulta.TabIndex = 70;
            this.btnConsulta.Text = "Consultar Agenda";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "CPF";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 3;
            this.btnBuscarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Image = global::SistemaOdonto.Properties.Resources.find_file;
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(119, 19);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(105, 37);
            this.btnBuscarPaciente.TabIndex = 72;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(11, 33);
            this.masktxtCPFPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(89, 23);
            this.masktxtCPFPaciente.TabIndex = 71;
            this.masktxtCPFPaciente.Enter += new System.EventHandler(this.masktxtCPFPaciente_Enter);
            // 
            // FrmCadConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.masktxtCPFPaciente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consultas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDentista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.ToolStripStatusLabel tsNenhuma;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.MaskedTextBox masktxtCPFPaciente;
    }
}