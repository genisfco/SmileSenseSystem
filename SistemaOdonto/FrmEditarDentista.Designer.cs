namespace SistemaOdonto
{
    partial class FrmEditarDentista
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.especialidade1 = new System.Windows.Forms.Label();
            this.comboxEspecialidade1 = new System.Windows.Forms.ComboBox();
            this.especialidade2 = new System.Windows.Forms.Label();
            this.comboxEspecialidade2 = new System.Windows.Forms.ComboBox();
            this.rgEspecialista = new System.Windows.Forms.Label();
            this.cpfEspecialista = new System.Windows.Forms.Label();
            this.maskRGDentist = new System.Windows.Forms.MaskedTextBox();
            this.maskCPFDentist = new System.Windows.Forms.MaskedTextBox();
            this.txtCRO = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts,
            this.tsNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(5, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(358, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "tsNenhuma";
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.White;
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(69, 17);
            this.ts.Text = "Mensagem:";
            // 
            // tsNenhuma
            // 
            this.tsNenhuma.BackColor = System.Drawing.Color.White;
            this.tsNenhuma.Name = "tsNenhuma";
            this.tsNenhuma.Size = new System.Drawing.Size(60, 17);
            this.tsNenhuma.Text = "Nenhuma";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(19, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "01";
            // 
            // especialidade1
            // 
            this.especialidade1.AutoSize = true;
            this.especialidade1.Location = new System.Drawing.Point(6, 100);
            this.especialidade1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.especialidade1.Name = "especialidade1";
            this.especialidade1.Size = new System.Drawing.Size(46, 13);
            this.especialidade1.TabIndex = 106;
            this.especialidade1.Text = "Espec.1";
            // 
            // comboxEspecialidade1
            // 
            this.comboxEspecialidade1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxEspecialidade1.FormattingEnabled = true;
            this.comboxEspecialidade1.Items.AddRange(new object[] {
            "Clínico Geral",
            "Dentística",
            "Endodontia",
            "Implantodontia",
            "Odontogeriatria",
            "Odontopediatria",
            "Ortodontia",
            "Periodontia",
            "Outra"});
            this.comboxEspecialidade1.Location = new System.Drawing.Point(54, 96);
            this.comboxEspecialidade1.Margin = new System.Windows.Forms.Padding(2);
            this.comboxEspecialidade1.Name = "comboxEspecialidade1";
            this.comboxEspecialidade1.Size = new System.Drawing.Size(105, 21);
            this.comboxEspecialidade1.TabIndex = 5;
            // 
            // especialidade2
            // 
            this.especialidade2.AutoSize = true;
            this.especialidade2.Location = new System.Drawing.Point(197, 100);
            this.especialidade2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.especialidade2.Name = "especialidade2";
            this.especialidade2.Size = new System.Drawing.Size(46, 13);
            this.especialidade2.TabIndex = 108;
            this.especialidade2.Text = "Espec.2";
            // 
            // comboxEspecialidade2
            // 
            this.comboxEspecialidade2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxEspecialidade2.FormattingEnabled = true;
            this.comboxEspecialidade2.Items.AddRange(new object[] {
            "Clínico Geral",
            "Dentística",
            "Endodontia",
            "Implantodontia",
            "Odontogeriatria",
            "Odontopediatria",
            "Ortodontia",
            "Periodontia",
            "Outra"});
            this.comboxEspecialidade2.Location = new System.Drawing.Point(246, 96);
            this.comboxEspecialidade2.Margin = new System.Windows.Forms.Padding(2);
            this.comboxEspecialidade2.Name = "comboxEspecialidade2";
            this.comboxEspecialidade2.Size = new System.Drawing.Size(105, 21);
            this.comboxEspecialidade2.TabIndex = 6;
            // 
            // rgEspecialista
            // 
            this.rgEspecialista.AutoSize = true;
            this.rgEspecialista.Location = new System.Drawing.Point(129, 54);
            this.rgEspecialista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rgEspecialista.Name = "rgEspecialista";
            this.rgEspecialista.Size = new System.Drawing.Size(23, 13);
            this.rgEspecialista.TabIndex = 102;
            this.rgEspecialista.Text = "RG";
            // 
            // cpfEspecialista
            // 
            this.cpfEspecialista.AutoSize = true;
            this.cpfEspecialista.Location = new System.Drawing.Point(233, 54);
            this.cpfEspecialista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpfEspecialista.Name = "cpfEspecialista";
            this.cpfEspecialista.Size = new System.Drawing.Size(27, 13);
            this.cpfEspecialista.TabIndex = 103;
            this.cpfEspecialista.Text = "CPF";
            // 
            // maskRGDentist
            // 
            this.maskRGDentist.Location = new System.Drawing.Point(158, 50);
            this.maskRGDentist.Margin = new System.Windows.Forms.Padding(2);
            this.maskRGDentist.Mask = "00.000.000-C";
            this.maskRGDentist.Name = "maskRGDentist";
            this.maskRGDentist.ReadOnly = true;
            this.maskRGDentist.Size = new System.Drawing.Size(71, 20);
            this.maskRGDentist.TabIndex = 3;
            this.maskRGDentist.Enter += new System.EventHandler(this.maskRGDentist_Enter);
            // 
            // maskCPFDentist
            // 
            this.maskCPFDentist.Location = new System.Drawing.Point(266, 50);
            this.maskCPFDentist.Margin = new System.Windows.Forms.Padding(2);
            this.maskCPFDentist.Mask = "000.000.000-00";
            this.maskCPFDentist.Name = "maskCPFDentist";
            this.maskCPFDentist.ReadOnly = true;
            this.maskCPFDentist.Size = new System.Drawing.Size(83, 20);
            this.maskCPFDentist.TabIndex = 4;
            this.maskCPFDentist.Enter += new System.EventHandler(this.maskCPFDentist_Enter);
            // 
            // txtCRO
            // 
            this.txtCRO.Location = new System.Drawing.Point(54, 50);
            this.txtCRO.Mask = "LL 00-000";
            this.txtCRO.Name = "txtCRO";
            this.txtCRO.ReadOnly = true;
            this.txtCRO.Size = new System.Drawing.Size(70, 20);
            this.txtCRO.TabIndex = 2;
            this.txtCRO.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCRO.Enter += new System.EventHandler(this.txtCRO_Enter);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(258, 174);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(92, 20);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(54, 174);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(92, 20);
            this.txtTelefone.TabIndex = 8;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(54, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "CRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Fone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.especialidade1);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.comboxEspecialidade1);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.especialidade2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboxEspecialidade2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rgEspecialista);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cpfEspecialista);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maskRGDentist);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.maskCPFDentist);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtCRO);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 301);
            this.panel1.TabIndex = 109;
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
            this.btnEditar.Location = new System.Drawing.Point(21, 231);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 43);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::SistemaOdonto.Properties.Resources.delete_user;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(223, 231);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 43);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmEditarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(366, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditarDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dentista Cadastrado";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStripStatusLabel tsNenhuma;
        private System.Windows.Forms.Label especialidade1;
        private System.Windows.Forms.ComboBox comboxEspecialidade1;
        private System.Windows.Forms.Label especialidade2;
        private System.Windows.Forms.ComboBox comboxEspecialidade2;
        private System.Windows.Forms.Label rgEspecialista;
        private System.Windows.Forms.Label cpfEspecialista;
        private System.Windows.Forms.MaskedTextBox maskRGDentist;
        private System.Windows.Forms.MaskedTextBox maskCPFDentist;
        private System.Windows.Forms.MaskedTextBox txtCRO;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
    }
}