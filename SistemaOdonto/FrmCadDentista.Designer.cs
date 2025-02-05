﻿namespace SistemaOdonto
{
    partial class FrmCadDentista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadDentista));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCRO = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.rgEspecialista = new System.Windows.Forms.Label();
            this.cpfEspecialista = new System.Windows.Forms.Label();
            this.maskRGDent = new System.Windows.Forms.MaskedTextBox();
            this.maskCPFDent = new System.Windows.Forms.MaskedTextBox();
            this.especialidade1 = new System.Windows.Forms.Label();
            this.comboxEspecialidade1 = new System.Windows.Forms.ComboBox();
            this.especialidade2 = new System.Windows.Forms.Label();
            this.comboxEspecialidade2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "CRO:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 22);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(444, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 209);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(81, 258);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 26);
            this.txtTelefone.TabIndex = 8;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(387, 258);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(136, 26);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            // 
            // txtCRO
            // 
            this.txtCRO.Location = new System.Drawing.Point(81, 69);
            this.txtCRO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCRO.Mask = "LL 000-000";
            this.txtCRO.Name = "txtCRO";
            this.txtCRO.Size = new System.Drawing.Size(103, 26);
            this.txtCRO.TabIndex = 2;
            this.txtCRO.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCRO.Enter += new System.EventHandler(this.txtCRO_Enter);
            this.txtCRO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCRO_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts,
            this.tsNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(554, 34);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
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
            // rgEspecialista
            // 
            this.rgEspecialista.AutoSize = true;
            this.rgEspecialista.Location = new System.Drawing.Point(194, 75);
            this.rgEspecialista.Name = "rgEspecialista";
            this.rgEspecialista.Size = new System.Drawing.Size(34, 20);
            this.rgEspecialista.TabIndex = 84;
            this.rgEspecialista.Text = "RG";
            // 
            // cpfEspecialista
            // 
            this.cpfEspecialista.AutoSize = true;
            this.cpfEspecialista.Location = new System.Drawing.Point(350, 75);
            this.cpfEspecialista.Name = "cpfEspecialista";
            this.cpfEspecialista.Size = new System.Drawing.Size(40, 20);
            this.cpfEspecialista.TabIndex = 85;
            this.cpfEspecialista.Text = "CPF";
            // 
            // maskRGDent
            // 
            this.maskRGDent.Location = new System.Drawing.Point(237, 69);
            this.maskRGDent.Mask = "00.000.000-C";
            this.maskRGDent.Name = "maskRGDent";
            this.maskRGDent.Size = new System.Drawing.Size(104, 26);
            this.maskRGDent.TabIndex = 3;
            this.maskRGDent.Enter += new System.EventHandler(this.maskRGDent_Enter);
            this.maskRGDent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskRGDent_KeyPress);
            // 
            // maskCPFDent
            // 
            this.maskCPFDent.Location = new System.Drawing.Point(399, 69);
            this.maskCPFDent.Mask = "000.000.000-00";
            this.maskCPFDent.Name = "maskCPFDent";
            this.maskCPFDent.Size = new System.Drawing.Size(122, 26);
            this.maskCPFDent.TabIndex = 4;
            this.maskCPFDent.Enter += new System.EventHandler(this.maskCPFDent_Enter);
            // 
            // especialidade1
            // 
            this.especialidade1.AutoSize = true;
            this.especialidade1.Location = new System.Drawing.Point(9, 146);
            this.especialidade1.Name = "especialidade1";
            this.especialidade1.Size = new System.Drawing.Size(67, 20);
            this.especialidade1.TabIndex = 88;
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
            this.comboxEspecialidade1.Location = new System.Drawing.Point(81, 138);
            this.comboxEspecialidade1.Name = "comboxEspecialidade1";
            this.comboxEspecialidade1.Size = new System.Drawing.Size(156, 28);
            this.comboxEspecialidade1.TabIndex = 5;
            // 
            // especialidade2
            // 
            this.especialidade2.AutoSize = true;
            this.especialidade2.Location = new System.Drawing.Point(294, 146);
            this.especialidade2.Name = "especialidade2";
            this.especialidade2.Size = new System.Drawing.Size(67, 20);
            this.especialidade2.TabIndex = 90;
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
            this.comboxEspecialidade2.Location = new System.Drawing.Point(369, 138);
            this.comboxEspecialidade2.Name = "comboxEspecialidade2";
            this.comboxEspecialidade2.Size = new System.Drawing.Size(156, 28);
            this.comboxEspecialidade2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.especialidade1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboxEspecialidade1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.especialidade2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboxEspecialidade2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rgEspecialista);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.cpfEspecialista);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.maskRGDent);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.maskCPFDent);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.txtCRO);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 458);
            this.panel1.TabIndex = 91;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::SistemaOdonto.Properties.Resources.file;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(336, 345);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(186, 66);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Novo/Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::SistemaOdonto.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(28, 345);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(186, 66);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(554, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCadDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Dentistas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCRO;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.ToolStripStatusLabel tsNenhuma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label rgEspecialista;
        private System.Windows.Forms.Label cpfEspecialista;
        private System.Windows.Forms.MaskedTextBox maskRGDent;
        private System.Windows.Forms.MaskedTextBox maskCPFDent;
        private System.Windows.Forms.Label especialidade1;
        private System.Windows.Forms.ComboBox comboxEspecialidade1;
        private System.Windows.Forms.Label especialidade2;
        private System.Windows.Forms.ComboBox comboxEspecialidade2;
        private System.Windows.Forms.Panel panel1;
    }
}