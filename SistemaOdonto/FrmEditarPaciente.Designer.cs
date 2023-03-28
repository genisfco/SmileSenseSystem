namespace SistemaOdonto
{
    partial class FrmEditarPaciente
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
            this.btnBuscaCEP = new System.Windows.Forms.Button();
            this.rgpaciente = new System.Windows.Forms.Label();
            this.cpfpaciente = new System.Windows.Forms.Label();
            this.masktxtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.masktxtRGPaciente = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnAbrirAnamnese = new System.Windows.Forms.Button();
            this.btnAbrirOdontograma = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(3, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "tsNenhuma";
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
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::SistemaOdonto.Properties.Resources.btnExcluir_BackgroundImage;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(259, 313);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(63, 65);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::SistemaOdonto.Properties.Resources.btnEditar_BackgroundImage;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(147, 313);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(63, 65);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, -1);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(19, 13);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "01";
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaCEP.Location = new System.Drawing.Point(340, 132);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(118, 37);
            this.btnBuscaCEP.TabIndex = 96;
            this.btnBuscaCEP.Text = "Buscar CEP";
            this.btnBuscaCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaCEP.UseVisualStyleBackColor = true;
            this.btnBuscaCEP.Click += new System.EventHandler(this.btnBuscaCEP_Click);
            // 
            // rgpaciente
            // 
            this.rgpaciente.AutoSize = true;
            this.rgpaciente.Location = new System.Drawing.Point(23, 58);
            this.rgpaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rgpaciente.Name = "rgpaciente";
            this.rgpaciente.Size = new System.Drawing.Size(26, 13);
            this.rgpaciente.TabIndex = 92;
            this.rgpaciente.Text = "RG:";
            // 
            // cpfpaciente
            // 
            this.cpfpaciente.AutoSize = true;
            this.cpfpaciente.Location = new System.Drawing.Point(169, 58);
            this.cpfpaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpfpaciente.Name = "cpfpaciente";
            this.cpfpaciente.Size = new System.Drawing.Size(30, 13);
            this.cpfpaciente.TabIndex = 93;
            this.cpfpaciente.Text = "CPF:";
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(200, 55);
            this.masktxtCPFPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(83, 20);
            this.masktxtCPFPaciente.TabIndex = 94;
            // 
            // masktxtRGPaciente
            // 
            this.masktxtRGPaciente.Location = new System.Drawing.Point(51, 55);
            this.masktxtRGPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtRGPaciente.Mask = "00.000.000-C";
            this.masktxtRGPaciente.Name = "masktxtRGPaciente";
            this.masktxtRGPaciente.Size = new System.Drawing.Size(71, 20);
            this.masktxtRGPaciente.TabIndex = 95;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(340, 20);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(119, 21);
            this.cbSexo.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "Sexo:";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Location = new System.Drawing.Point(339, 55);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(120, 20);
            this.dtDataNasc.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Nasc:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(395, 101);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(64, 20);
            this.txtCEP.TabIndex = 85;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(195, 142);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(87, 20);
            this.txtCelular.TabIndex = 84;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(51, 142);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(87, 20);
            this.txtTelefone.TabIndex = 83;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 82;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Fone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Location = new System.Drawing.Point(9, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(449, 84);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(17, 24);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(257, 20);
            this.txtEndereco.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nº";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(397, 24);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(29, 20);
            this.txtNum.TabIndex = 76;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(397, 53);
            this.txtUF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(29, 20);
            this.txtUF.TabIndex = 79;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(17, 53);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(112, 20);
            this.txtBairro.TabIndex = 77;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(163, 53);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(111, 20);
            this.txtCidade.TabIndex = 78;
            // 
            // btnAbrirAnamnese
            // 
            this.btnAbrirAnamnese.Location = new System.Drawing.Point(26, 313);
            this.btnAbrirAnamnese.Name = "btnAbrirAnamnese";
            this.btnAbrirAnamnese.Size = new System.Drawing.Size(96, 65);
            this.btnAbrirAnamnese.TabIndex = 98;
            this.btnAbrirAnamnese.Text = "Anamnese";
            this.btnAbrirAnamnese.UseVisualStyleBackColor = true;
            this.btnAbrirAnamnese.Click += new System.EventHandler(this.btnAbrirAnamnese_Click);
            // 
            // btnAbrirOdontograma
            // 
            this.btnAbrirOdontograma.Location = new System.Drawing.Point(361, 313);
            this.btnAbrirOdontograma.Name = "btnAbrirOdontograma";
            this.btnAbrirOdontograma.Size = new System.Drawing.Size(96, 65);
            this.btnAbrirOdontograma.TabIndex = 99;
            this.btnAbrirOdontograma.Text = "Odontograma";
            this.btnAbrirOdontograma.UseVisualStyleBackColor = true;
            this.btnAbrirOdontograma.Click += new System.EventHandler(this.btnAbrirOdontograma_Click);
            // 
            // FrmEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 419);
            this.Controls.Add(this.btnAbrirOdontograma);
            this.Controls.Add(this.btnAbrirAnamnese);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaCEP);
            this.Controls.Add(this.rgpaciente);
            this.Controls.Add(this.cpfpaciente);
            this.Controls.Add(this.masktxtCPFPaciente);
            this.Controls.Add(this.masktxtRGPaciente);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtDataNasc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Paciente";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.ToolStripStatusLabel tsNenhuma;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscaCEP;
        private System.Windows.Forms.Label rgpaciente;
        private System.Windows.Forms.Label cpfpaciente;
        private System.Windows.Forms.MaskedTextBox masktxtCPFPaciente;
        private System.Windows.Forms.MaskedTextBox masktxtRGPaciente;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnAbrirAnamnese;
        private System.Windows.Forms.Button btnAbrirOdontograma;
    }
}