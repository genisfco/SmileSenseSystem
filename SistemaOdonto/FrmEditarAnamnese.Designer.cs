namespace SistemaOdonto
{
    partial class FrmEditarAnamnese
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
            this.btnAtualizarAnm = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnFecharAnamnese = new System.Windows.Forms.Button();
            this.chboxDoencaCongNAO = new System.Windows.Forms.CheckBox();
            this.chboxDoencaCongSIM = new System.Windows.Forms.CheckBox();
            this.chboxComplOdontoNAO = new System.Windows.Forms.CheckBox();
            this.chboxComplOdontoSIM = new System.Windows.Forms.CheckBox();
            this.chboxProblHemorragNAO = new System.Windows.Forms.CheckBox();
            this.chboxProblHemorragSIM = new System.Windows.Forms.CheckBox();
            this.chboxAlergiaMedicamentosaNAO = new System.Windows.Forms.CheckBox();
            this.chboxAlergiaMedicamentosaSIM = new System.Windows.Forms.CheckBox();
            this.chboxUsoMedicamentosNAO = new System.Windows.Forms.CheckBox();
            this.chboxUsoMedicamentosSIM = new System.Windows.Forms.CheckBox();
            this.chboxCardiopatiaNAO = new System.Windows.Forms.CheckBox();
            this.chboxCardiopatiaSIM = new System.Windows.Forms.CheckBox();
            this.chboxHipertensaoNAO = new System.Windows.Forms.CheckBox();
            this.chboxHipertensaoSIM = new System.Windows.Forms.CheckBox();
            this.chboxDiabetesNAO = new System.Windows.Forms.CheckBox();
            this.chboxDiabetesSIM = new System.Windows.Forms.CheckBox();
            this.txtAlergiaQualMedicamento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.maskCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.txtDoenca = new System.Windows.Forms.TextBox();
            this.txtComplicacoes = new System.Windows.Forms.TextBox();
            this.txtMotivoProblemas = new System.Windows.Forms.TextBox();
            this.txtUsoQualMedicamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.lblCodAnm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtualizarAnm
            // 
            this.btnAtualizarAnm.BackColor = System.Drawing.Color.White;
            this.btnAtualizarAnm.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizarAnm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizarAnm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizarAnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarAnm.Image = global::SistemaOdonto.Properties.Resources.reload;
            this.btnAtualizarAnm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarAnm.Location = new System.Drawing.Point(72, 449);
            this.btnAtualizarAnm.Name = "btnAtualizarAnm";
            this.btnAtualizarAnm.Size = new System.Drawing.Size(306, 60);
            this.btnAtualizarAnm.TabIndex = 157;
            this.btnAtualizarAnm.Text = "Atualizar Anamnese";
            this.btnAtualizarAnm.UseVisualStyleBackColor = false;
            this.btnAtualizarAnm.Click += new System.EventHandler(this.btnAtualizarAnm_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(680, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 20);
            this.lblCodigo.TabIndex = 156;
            this.lblCodigo.Text = "ID.Pacte";
            // 
            // btnFecharAnamnese
            // 
            this.btnFecharAnamnese.BackColor = System.Drawing.Color.White;
            this.btnFecharAnamnese.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFecharAnamnese.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFecharAnamnese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFecharAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharAnamnese.Image = global::SistemaOdonto.Properties.Resources.delete;
            this.btnFecharAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharAnamnese.Location = new System.Drawing.Point(628, 449);
            this.btnFecharAnamnese.Name = "btnFecharAnamnese";
            this.btnFecharAnamnese.Size = new System.Drawing.Size(306, 60);
            this.btnFecharAnamnese.TabIndex = 155;
            this.btnFecharAnamnese.Text = "Fechar Ficha";
            this.btnFecharAnamnese.UseVisualStyleBackColor = false;
            this.btnFecharAnamnese.Click += new System.EventHandler(this.btnFecharAnamnese_Click);
            // 
            // chboxDoencaCongNAO
            // 
            this.chboxDoencaCongNAO.AutoSize = true;
            this.chboxDoencaCongNAO.Location = new System.Drawing.Point(400, 397);
            this.chboxDoencaCongNAO.Name = "chboxDoencaCongNAO";
            this.chboxDoencaCongNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxDoencaCongNAO.TabIndex = 153;
            this.chboxDoencaCongNAO.Text = "Não";
            this.chboxDoencaCongNAO.UseVisualStyleBackColor = true;
            // 
            // chboxDoencaCongSIM
            // 
            this.chboxDoencaCongSIM.AutoSize = true;
            this.chboxDoencaCongSIM.Location = new System.Drawing.Point(333, 397);
            this.chboxDoencaCongSIM.Name = "chboxDoencaCongSIM";
            this.chboxDoencaCongSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxDoencaCongSIM.TabIndex = 152;
            this.chboxDoencaCongSIM.Text = "Sim";
            this.chboxDoencaCongSIM.UseVisualStyleBackColor = true;
            // 
            // chboxComplOdontoNAO
            // 
            this.chboxComplOdontoNAO.AutoSize = true;
            this.chboxComplOdontoNAO.Location = new System.Drawing.Point(400, 355);
            this.chboxComplOdontoNAO.Name = "chboxComplOdontoNAO";
            this.chboxComplOdontoNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxComplOdontoNAO.TabIndex = 151;
            this.chboxComplOdontoNAO.Text = "Não";
            this.chboxComplOdontoNAO.UseVisualStyleBackColor = true;
            // 
            // chboxComplOdontoSIM
            // 
            this.chboxComplOdontoSIM.AutoSize = true;
            this.chboxComplOdontoSIM.Location = new System.Drawing.Point(333, 355);
            this.chboxComplOdontoSIM.Name = "chboxComplOdontoSIM";
            this.chboxComplOdontoSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxComplOdontoSIM.TabIndex = 150;
            this.chboxComplOdontoSIM.Text = "Sim";
            this.chboxComplOdontoSIM.UseVisualStyleBackColor = true;
            // 
            // chboxProblHemorragNAO
            // 
            this.chboxProblHemorragNAO.AutoSize = true;
            this.chboxProblHemorragNAO.Location = new System.Drawing.Point(400, 314);
            this.chboxProblHemorragNAO.Name = "chboxProblHemorragNAO";
            this.chboxProblHemorragNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxProblHemorragNAO.TabIndex = 149;
            this.chboxProblHemorragNAO.Text = "Não";
            this.chboxProblHemorragNAO.UseVisualStyleBackColor = true;
            // 
            // chboxProblHemorragSIM
            // 
            this.chboxProblHemorragSIM.AutoSize = true;
            this.chboxProblHemorragSIM.Location = new System.Drawing.Point(333, 314);
            this.chboxProblHemorragSIM.Name = "chboxProblHemorragSIM";
            this.chboxProblHemorragSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxProblHemorragSIM.TabIndex = 148;
            this.chboxProblHemorragSIM.Text = "Sim";
            this.chboxProblHemorragSIM.UseVisualStyleBackColor = true;
            // 
            // chboxAlergiaMedicamentosaNAO
            // 
            this.chboxAlergiaMedicamentosaNAO.AutoSize = true;
            this.chboxAlergiaMedicamentosaNAO.Location = new System.Drawing.Point(400, 271);
            this.chboxAlergiaMedicamentosaNAO.Name = "chboxAlergiaMedicamentosaNAO";
            this.chboxAlergiaMedicamentosaNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxAlergiaMedicamentosaNAO.TabIndex = 147;
            this.chboxAlergiaMedicamentosaNAO.Text = "Não";
            this.chboxAlergiaMedicamentosaNAO.UseVisualStyleBackColor = true;
            // 
            // chboxAlergiaMedicamentosaSIM
            // 
            this.chboxAlergiaMedicamentosaSIM.AutoSize = true;
            this.chboxAlergiaMedicamentosaSIM.Location = new System.Drawing.Point(333, 271);
            this.chboxAlergiaMedicamentosaSIM.Name = "chboxAlergiaMedicamentosaSIM";
            this.chboxAlergiaMedicamentosaSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxAlergiaMedicamentosaSIM.TabIndex = 146;
            this.chboxAlergiaMedicamentosaSIM.Text = "Sim";
            this.chboxAlergiaMedicamentosaSIM.UseVisualStyleBackColor = true;
            // 
            // chboxUsoMedicamentosNAO
            // 
            this.chboxUsoMedicamentosNAO.AutoSize = true;
            this.chboxUsoMedicamentosNAO.Location = new System.Drawing.Point(400, 226);
            this.chboxUsoMedicamentosNAO.Name = "chboxUsoMedicamentosNAO";
            this.chboxUsoMedicamentosNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxUsoMedicamentosNAO.TabIndex = 145;
            this.chboxUsoMedicamentosNAO.Text = "Não";
            this.chboxUsoMedicamentosNAO.UseVisualStyleBackColor = true;
            // 
            // chboxUsoMedicamentosSIM
            // 
            this.chboxUsoMedicamentosSIM.AutoSize = true;
            this.chboxUsoMedicamentosSIM.Location = new System.Drawing.Point(333, 226);
            this.chboxUsoMedicamentosSIM.Name = "chboxUsoMedicamentosSIM";
            this.chboxUsoMedicamentosSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxUsoMedicamentosSIM.TabIndex = 144;
            this.chboxUsoMedicamentosSIM.Text = "Sim";
            this.chboxUsoMedicamentosSIM.UseVisualStyleBackColor = true;
            // 
            // chboxCardiopatiaNAO
            // 
            this.chboxCardiopatiaNAO.AutoSize = true;
            this.chboxCardiopatiaNAO.Location = new System.Drawing.Point(400, 183);
            this.chboxCardiopatiaNAO.Name = "chboxCardiopatiaNAO";
            this.chboxCardiopatiaNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxCardiopatiaNAO.TabIndex = 143;
            this.chboxCardiopatiaNAO.Text = "Não";
            this.chboxCardiopatiaNAO.UseVisualStyleBackColor = true;
            // 
            // chboxCardiopatiaSIM
            // 
            this.chboxCardiopatiaSIM.AutoSize = true;
            this.chboxCardiopatiaSIM.Location = new System.Drawing.Point(333, 183);
            this.chboxCardiopatiaSIM.Name = "chboxCardiopatiaSIM";
            this.chboxCardiopatiaSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxCardiopatiaSIM.TabIndex = 142;
            this.chboxCardiopatiaSIM.Text = "Sim";
            this.chboxCardiopatiaSIM.UseVisualStyleBackColor = true;
            // 
            // chboxHipertensaoNAO
            // 
            this.chboxHipertensaoNAO.AutoSize = true;
            this.chboxHipertensaoNAO.Location = new System.Drawing.Point(400, 140);
            this.chboxHipertensaoNAO.Name = "chboxHipertensaoNAO";
            this.chboxHipertensaoNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxHipertensaoNAO.TabIndex = 141;
            this.chboxHipertensaoNAO.Text = "Não";
            this.chboxHipertensaoNAO.UseVisualStyleBackColor = true;
            // 
            // chboxHipertensaoSIM
            // 
            this.chboxHipertensaoSIM.AutoSize = true;
            this.chboxHipertensaoSIM.Location = new System.Drawing.Point(333, 140);
            this.chboxHipertensaoSIM.Name = "chboxHipertensaoSIM";
            this.chboxHipertensaoSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxHipertensaoSIM.TabIndex = 140;
            this.chboxHipertensaoSIM.Text = "Sim";
            this.chboxHipertensaoSIM.UseVisualStyleBackColor = true;
            // 
            // chboxDiabetesNAO
            // 
            this.chboxDiabetesNAO.AutoSize = true;
            this.chboxDiabetesNAO.Location = new System.Drawing.Point(400, 97);
            this.chboxDiabetesNAO.Name = "chboxDiabetesNAO";
            this.chboxDiabetesNAO.Size = new System.Drawing.Size(64, 24);
            this.chboxDiabetesNAO.TabIndex = 139;
            this.chboxDiabetesNAO.Text = "Não";
            this.chboxDiabetesNAO.UseVisualStyleBackColor = true;
            // 
            // chboxDiabetesSIM
            // 
            this.chboxDiabetesSIM.AutoSize = true;
            this.chboxDiabetesSIM.Location = new System.Drawing.Point(333, 97);
            this.chboxDiabetesSIM.Name = "chboxDiabetesSIM";
            this.chboxDiabetesSIM.Size = new System.Drawing.Size(62, 24);
            this.chboxDiabetesSIM.TabIndex = 138;
            this.chboxDiabetesSIM.Text = "Sim";
            this.chboxDiabetesSIM.UseVisualStyleBackColor = true;
            // 
            // txtAlergiaQualMedicamento
            // 
            this.txtAlergiaQualMedicamento.Location = new System.Drawing.Point(628, 266);
            this.txtAlergiaQualMedicamento.Name = "txtAlergiaQualMedicamento";
            this.txtAlergiaQualMedicamento.Size = new System.Drawing.Size(368, 26);
            this.txtAlergiaQualMedicamento.TabIndex = 137;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(568, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 136;
            this.label12.Text = "Qual?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 20);
            this.label13.TabIndex = 135;
            this.label13.Text = "Alergia Medicamentosa";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(45, 31);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(40, 20);
            this.lbCPF.TabIndex = 134;
            this.lbCPF.Text = "CPF";
            // 
            // maskCPFPaciente
            // 
            this.maskCPFPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.maskCPFPaciente.Location = new System.Drawing.Point(92, 25);
            this.maskCPFPaciente.Mask = "000.000.000-00";
            this.maskCPFPaciente.Name = "maskCPFPaciente";
            this.maskCPFPaciente.ReadOnly = true;
            this.maskCPFPaciente.Size = new System.Drawing.Size(122, 26);
            this.maskCPFPaciente.TabIndex = 133;
            this.maskCPFPaciente.TabStop = false;
            // 
            // txtDoenca
            // 
            this.txtDoenca.Location = new System.Drawing.Point(628, 392);
            this.txtDoenca.Name = "txtDoenca";
            this.txtDoenca.Size = new System.Drawing.Size(368, 26);
            this.txtDoenca.TabIndex = 132;
            // 
            // txtComplicacoes
            // 
            this.txtComplicacoes.Location = new System.Drawing.Point(628, 349);
            this.txtComplicacoes.Name = "txtComplicacoes";
            this.txtComplicacoes.Size = new System.Drawing.Size(368, 26);
            this.txtComplicacoes.TabIndex = 131;
            // 
            // txtMotivoProblemas
            // 
            this.txtMotivoProblemas.Location = new System.Drawing.Point(628, 308);
            this.txtMotivoProblemas.Name = "txtMotivoProblemas";
            this.txtMotivoProblemas.Size = new System.Drawing.Size(368, 26);
            this.txtMotivoProblemas.TabIndex = 130;
            // 
            // txtUsoQualMedicamento
            // 
            this.txtUsoQualMedicamento.Location = new System.Drawing.Point(628, 225);
            this.txtUsoQualMedicamento.Name = "txtUsoQualMedicamento";
            this.txtUsoQualMedicamento.Size = new System.Drawing.Size(368, 26);
            this.txtUsoQualMedicamento.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(568, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 128;
            this.label11.Text = "Qual?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 20);
            this.label10.TabIndex = 127;
            this.label10.Text = "Doença congenita ou adquirida?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 126;
            this.label9.Text = "Por quê?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 20);
            this.label8.TabIndex = 125;
            this.label8.Text = "Complicações em consulta odontológica?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 124;
            this.label7.Text = "Motivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 123;
            this.label6.Text = "Qual Medicamento?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 122;
            this.label5.Text = "Problemas Hemorrágicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 121;
            this.label4.Text = "Uso contínuo de medicamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "Cardiopatia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Hipertensão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Diabetes";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(382, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(616, 26);
            this.txtNome.TabIndex = 117;
            this.txtNome.TabStop = false;
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Location = new System.Drawing.Point(308, 31);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(71, 20);
            this.lbPaciente.TabIndex = 116;
            this.lbPaciente.Text = "Paciente";
            // 
            // lblCodAnm
            // 
            this.lblCodAnm.AutoSize = true;
            this.lblCodAnm.Location = new System.Drawing.Point(862, 97);
            this.lblCodAnm.Name = "lblCodAnm";
            this.lblCodAnm.Size = new System.Drawing.Size(72, 20);
            this.lblCodAnm.TabIndex = 158;
            this.lblCodAnm.Text = "ID.Anam";
            // 
            // FrmEditarAnamnese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 518);
            this.Controls.Add(this.lblCodAnm);
            this.Controls.Add(this.btnAtualizarAnm);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnFecharAnamnese);
            this.Controls.Add(this.chboxDoencaCongNAO);
            this.Controls.Add(this.chboxDoencaCongSIM);
            this.Controls.Add(this.chboxComplOdontoNAO);
            this.Controls.Add(this.chboxComplOdontoSIM);
            this.Controls.Add(this.chboxProblHemorragNAO);
            this.Controls.Add(this.chboxProblHemorragSIM);
            this.Controls.Add(this.chboxAlergiaMedicamentosaNAO);
            this.Controls.Add(this.chboxAlergiaMedicamentosaSIM);
            this.Controls.Add(this.chboxUsoMedicamentosNAO);
            this.Controls.Add(this.chboxUsoMedicamentosSIM);
            this.Controls.Add(this.chboxCardiopatiaNAO);
            this.Controls.Add(this.chboxCardiopatiaSIM);
            this.Controls.Add(this.chboxHipertensaoNAO);
            this.Controls.Add(this.chboxHipertensaoSIM);
            this.Controls.Add(this.chboxDiabetesNAO);
            this.Controls.Add(this.chboxDiabetesSIM);
            this.Controls.Add(this.txtAlergiaQualMedicamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.maskCPFPaciente);
            this.Controls.Add(this.txtDoenca);
            this.Controls.Add(this.txtComplicacoes);
            this.Controls.Add(this.txtMotivoProblemas);
            this.Controls.Add(this.txtUsoQualMedicamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbPaciente);
            this.Name = "FrmEditarAnamnese";
            this.Text = "Ficha Anamnese";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarAnm;
        public System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnFecharAnamnese;
        private System.Windows.Forms.CheckBox chboxDoencaCongNAO;
        private System.Windows.Forms.CheckBox chboxDoencaCongSIM;
        private System.Windows.Forms.CheckBox chboxComplOdontoNAO;
        private System.Windows.Forms.CheckBox chboxComplOdontoSIM;
        private System.Windows.Forms.CheckBox chboxProblHemorragNAO;
        private System.Windows.Forms.CheckBox chboxProblHemorragSIM;
        private System.Windows.Forms.CheckBox chboxAlergiaMedicamentosaNAO;
        private System.Windows.Forms.CheckBox chboxAlergiaMedicamentosaSIM;
        private System.Windows.Forms.CheckBox chboxUsoMedicamentosNAO;
        private System.Windows.Forms.CheckBox chboxUsoMedicamentosSIM;
        private System.Windows.Forms.CheckBox chboxCardiopatiaNAO;
        private System.Windows.Forms.CheckBox chboxCardiopatiaSIM;
        private System.Windows.Forms.CheckBox chboxHipertensaoNAO;
        private System.Windows.Forms.CheckBox chboxHipertensaoSIM;
        private System.Windows.Forms.CheckBox chboxDiabetesNAO;
        private System.Windows.Forms.CheckBox chboxDiabetesSIM;
        private System.Windows.Forms.TextBox txtAlergiaQualMedicamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCPF;
        public System.Windows.Forms.MaskedTextBox maskCPFPaciente;
        private System.Windows.Forms.TextBox txtDoenca;
        private System.Windows.Forms.TextBox txtComplicacoes;
        private System.Windows.Forms.TextBox txtMotivoProblemas;
        private System.Windows.Forms.TextBox txtUsoQualMedicamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbPaciente;
        public System.Windows.Forms.Label lblCodAnm;
    }
}