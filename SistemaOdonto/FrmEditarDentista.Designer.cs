﻿namespace SistemaOdonto
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.statusStrip1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(7, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(510, 34);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "tsNenhuma";
            // 
            // ts
            // 
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(104, 27);
            this.ts.Text = "Mensagem:";
            // 
            // tsNenhuma
            // 
            this.tsNenhuma.Name = "tsNenhuma";
            this.tsNenhuma.Size = new System.Drawing.Size(89, 27);
            this.tsNenhuma.Text = "Nenhuma";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExcluir.Image = global::SistemaOdonto.Properties.Resources.delete_user;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(329, 356);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(186, 66);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditar.Image = global::SistemaOdonto.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(25, 356);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 66);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(-2, 0);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(27, 20);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "01";
            // 
            // especialidade1
            // 
            this.especialidade1.AutoSize = true;
            this.especialidade1.Location = new System.Drawing.Point(3, 154);
            this.especialidade1.Name = "especialidade1";
            this.especialidade1.Size = new System.Drawing.Size(67, 20);
            this.especialidade1.TabIndex = 106;
            this.especialidade1.Text = "Espec.1";
            // 
            // comboxEspecialidade1
            // 
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
            this.comboxEspecialidade1.Location = new System.Drawing.Point(75, 147);
            this.comboxEspecialidade1.Name = "comboxEspecialidade1";
            this.comboxEspecialidade1.Size = new System.Drawing.Size(156, 28);
            this.comboxEspecialidade1.TabIndex = 5;
            // 
            // especialidade2
            // 
            this.especialidade2.AutoSize = true;
            this.especialidade2.Location = new System.Drawing.Point(289, 154);
            this.especialidade2.Name = "especialidade2";
            this.especialidade2.Size = new System.Drawing.Size(67, 20);
            this.especialidade2.TabIndex = 108;
            this.especialidade2.Text = "Espec.2";
            // 
            // comboxEspecialidade2
            // 
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
            this.comboxEspecialidade2.Location = new System.Drawing.Point(363, 147);
            this.comboxEspecialidade2.Name = "comboxEspecialidade2";
            this.comboxEspecialidade2.Size = new System.Drawing.Size(156, 28);
            this.comboxEspecialidade2.TabIndex = 6;
            // 
            // rgEspecialista
            // 
            this.rgEspecialista.AutoSize = true;
            this.rgEspecialista.Location = new System.Drawing.Point(188, 83);
            this.rgEspecialista.Name = "rgEspecialista";
            this.rgEspecialista.Size = new System.Drawing.Size(34, 20);
            this.rgEspecialista.TabIndex = 102;
            this.rgEspecialista.Text = "RG";
            // 
            // cpfEspecialista
            // 
            this.cpfEspecialista.AutoSize = true;
            this.cpfEspecialista.Location = new System.Drawing.Point(344, 83);
            this.cpfEspecialista.Name = "cpfEspecialista";
            this.cpfEspecialista.Size = new System.Drawing.Size(40, 20);
            this.cpfEspecialista.TabIndex = 103;
            this.cpfEspecialista.Text = "CPF";
            // 
            // maskRGDentist
            // 
            this.maskRGDentist.Location = new System.Drawing.Point(231, 77);
            this.maskRGDentist.Mask = "00.000.000-C";
            this.maskRGDentist.Name = "maskRGDentist";
            this.maskRGDentist.ReadOnly = true;
            this.maskRGDentist.Size = new System.Drawing.Size(104, 26);
            this.maskRGDentist.TabIndex = 3;
            this.maskRGDentist.Enter += new System.EventHandler(this.maskRGDentist_Enter);
            // 
            // maskCPFDentist
            // 
            this.maskCPFDentist.Location = new System.Drawing.Point(393, 77);
            this.maskCPFDentist.Mask = "000.000.000-00";
            this.maskCPFDentist.Name = "maskCPFDentist";
            this.maskCPFDentist.ReadOnly = true;
            this.maskCPFDentist.Size = new System.Drawing.Size(122, 26);
            this.maskCPFDentist.TabIndex = 4;
            this.maskCPFDentist.Enter += new System.EventHandler(this.maskCPFDentist_Enter);
            // 
            // txtCRO
            // 
            this.txtCRO.Location = new System.Drawing.Point(75, 77);
            this.txtCRO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCRO.Mask = "LL 00-000";
            this.txtCRO.Name = "txtCRO";
            this.txtCRO.ReadOnly = true;
            this.txtCRO.Size = new System.Drawing.Size(103, 26);
            this.txtCRO.TabIndex = 2;
            this.txtCRO.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCRO.Enter += new System.EventHandler(this.txtCRO_Enter);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(381, 267);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(136, 26);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(75, 267);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 26);
            this.txtTelefone.TabIndex = 8;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 30);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(444, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "CRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Fone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nome:";
            // 
            // FrmEditarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 529);
            this.Controls.Add(this.especialidade1);
            this.Controls.Add(this.comboxEspecialidade1);
            this.Controls.Add(this.especialidade2);
            this.Controls.Add(this.comboxEspecialidade2);
            this.Controls.Add(this.rgEspecialista);
            this.Controls.Add(this.cpfEspecialista);
            this.Controls.Add(this.maskRGDentist);
            this.Controls.Add(this.maskCPFDentist);
            this.Controls.Add(this.txtCRO);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEditarDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dentista Cadastrado";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}