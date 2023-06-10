namespace SistemaOdonto
{
    partial class frmEditarConsulta
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
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.masktxtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtHora
            // 
            this.dtHora.CustomFormat = "HH:mm";
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHora.Location = new System.Drawing.Point(424, 218);
            this.dtHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(212, 26);
            this.dtHora.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Hora:";
            // 
            // cbDentista
            // 
            this.cbDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(20, 217);
            this.cbDentista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(318, 28);
            this.cbDentista.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Dentista:";
            // 
            // cbPaciente
            // 
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(20, 140);
            this.cbPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(318, 28);
            this.cbPaciente.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Paciente:";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(424, 142);
            this.dtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(212, 26);
            this.dtData.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Data:";
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Location = new System.Drawing.Point(26, 362);
            this.txtAnotacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(613, 113);
            this.txtAnotacoes.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Anotações:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 5);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(27, 20);
            this.lblCodigo.TabIndex = 63;
            this.lblCodigo.Text = "01";
            // 
            // dtFim
            // 
            this.dtFim.CustomFormat = "HH:mm";
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(525, 278);
            this.dtFim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFim.Name = "dtFim";
            this.dtFim.ShowUpDown = true;
            this.dtFim.Size = new System.Drawing.Size(109, 26);
            this.dtFim.TabIndex = 68;
            this.dtFim.Value = new System.DateTime(2015, 2, 3, 0, 0, 0, 0);
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "HH:mm";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(124, 278);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.ShowUpDown = true;
            this.dtInicio.Size = new System.Drawing.Size(109, 26);
            this.dtInicio.TabIndex = 67;
            this.dtInicio.Value = new System.DateTime(2015, 2, 3, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "Fim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "Início:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts,
            this.tsNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(666, 34);
            this.statusStrip1.TabIndex = 71;
            this.statusStrip1.Text = "tsNenhuma";
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.White;
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(104, 27);
            this.ts.Text = "Mensagem:";
            // 
            // tsNenhuma
            // 
            this.tsNenhuma.BackColor = System.Drawing.Color.White;
            this.tsNenhuma.Name = "tsNenhuma";
            this.tsNenhuma.Size = new System.Drawing.Size(89, 27);
            this.tsNenhuma.Text = "Nenhuma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "CPF";
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(20, 57);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(132, 30);
            this.masktxtCPFPaciente.TabIndex = 74;
            this.masktxtCPFPaciente.Enter += new System.EventHandler(this.masktxtCPFPaciente_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnBuscarPaciente);
            this.panel1.Controls.Add(this.txtAnotacoes);
            this.panel1.Controls.Add(this.masktxtCPFPaciente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtData);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbPaciente);
            this.panel1.Controls.Add(this.dtFim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Controls.Add(this.cbDentista);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtHora);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 598);
            this.panel1.TabIndex = 77;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::SistemaOdonto.Properties.Resources.botao_de_deletar;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(424, 505);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(216, 68);
            this.btnExcluir.TabIndex = 70;
            this.btnExcluir.Text = "Excluir Consulta";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::SistemaOdonto.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(26, 505);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(212, 68);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 2;
            this.btnBuscarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Image = global::SistemaOdonto.Properties.Resources.find_file;
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(182, 35);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(158, 57);
            this.btnBuscarPaciente.TabIndex = 75;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // frmEditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(666, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmEditarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição das Consultas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDentista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.ToolStripStatusLabel tsNenhuma;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.MaskedTextBox masktxtCPFPaciente;
        private System.Windows.Forms.Panel panel1;
    }
}