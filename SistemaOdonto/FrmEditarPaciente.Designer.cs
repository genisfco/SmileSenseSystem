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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rgpaciente = new System.Windows.Forms.Label();
            this.cpfpaciente = new System.Windows.Forms.Label();
            this.masktxtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.masktxtRGPaciente = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.btnAbrirOdontograma = new System.Windows.Forms.Button();
            this.btnAbrirAnamnese = new System.Windows.Forms.Button();
            this.btnBuscaCEP = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.statusStrip1.Location = new System.Drawing.Point(4, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(690, 34);
            this.statusStrip1.TabIndex = 38;
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, -2);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 20);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "cod.";
            // 
            // rgpaciente
            // 
            this.rgpaciente.AutoSize = true;
            this.rgpaciente.Location = new System.Drawing.Point(34, 89);
            this.rgpaciente.Name = "rgpaciente";
            this.rgpaciente.Size = new System.Drawing.Size(38, 20);
            this.rgpaciente.TabIndex = 92;
            this.rgpaciente.Text = "RG:";
            // 
            // cpfpaciente
            // 
            this.cpfpaciente.AutoSize = true;
            this.cpfpaciente.Location = new System.Drawing.Point(254, 89);
            this.cpfpaciente.Name = "cpfpaciente";
            this.cpfpaciente.Size = new System.Drawing.Size(44, 20);
            this.cpfpaciente.TabIndex = 93;
            this.cpfpaciente.Text = "CPF:";
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(300, 85);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.ReadOnly = true;
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(122, 26);
            this.masktxtCPFPaciente.TabIndex = 4;
            this.masktxtCPFPaciente.Enter += new System.EventHandler(this.masktxtCPFPaciente_Enter);
            // 
            // masktxtRGPaciente
            // 
            this.masktxtRGPaciente.Location = new System.Drawing.Point(76, 85);
            this.masktxtRGPaciente.Mask = "00.000.000-C";
            this.masktxtRGPaciente.Name = "masktxtRGPaciente";
            this.masktxtRGPaciente.ReadOnly = true;
            this.masktxtRGPaciente.Size = new System.Drawing.Size(104, 26);
            this.masktxtRGPaciente.TabIndex = 3;
            this.masktxtRGPaciente.Enter += new System.EventHandler(this.masktxtRGPaciente_Enter);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(496, 31);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(190, 28);
            this.cbSexo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 90;
            this.label9.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 88;
            this.label8.Text = "Nasc:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(592, 155);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(94, 26);
            this.txtCEP.TabIndex = 9;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(292, 218);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(128, 26);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 218);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(128, 26);
            this.txtTelefone.TabIndex = 12;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 162);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 26);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 29);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Fone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Location = new System.Drawing.Point(14, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 129);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(579, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 90;
            this.label12.Text = "UF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 89;
            this.label11.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "Bairro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Logradouro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(104, 40);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(432, 26);
            this.txtEndereco.TabIndex = 14;
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(104, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(166, 26);
            this.txtBairro.TabIndex = 15;
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(370, 82);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(164, 26);
            this.txtCidade.TabIndex = 16;
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nº";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(620, 38);
            this.txtNum.MaxLength = 5;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(42, 26);
            this.txtNum.TabIndex = 11;
            this.txtNum.Enter += new System.EventHandler(this.txtNum_Enter);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Location = new System.Drawing.Point(620, 83);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(42, 26);
            this.txtUF.TabIndex = 17;
            this.txtUF.Enter += new System.EventHandler(this.txtUF_Enter);
            // 
            // cbAno
            // 
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.cbAno.Location = new System.Drawing.Point(610, 83);
            this.cbAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(76, 28);
            this.cbAno.TabIndex = 7;
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(554, 83);
            this.cbMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(52, 28);
            this.cbMes.TabIndex = 6;
            // 
            // cbDia
            // 
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDia.Location = new System.Drawing.Point(496, 83);
            this.cbDia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(52, 28);
            this.cbDia.TabIndex = 5;
            // 
            // btnAbrirOdontograma
            // 
            this.btnAbrirOdontograma.BackColor = System.Drawing.Color.White;
            this.btnAbrirOdontograma.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirOdontograma.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirOdontograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirOdontograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirOdontograma.Image = global::SistemaOdonto.Properties.Resources.Odontograma;
            this.btnAbrirOdontograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirOdontograma.Location = new System.Drawing.Point(208, 475);
            this.btnAbrirOdontograma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrirOdontograma.Name = "btnAbrirOdontograma";
            this.btnAbrirOdontograma.Size = new System.Drawing.Size(182, 66);
            this.btnAbrirOdontograma.TabIndex = 21;
            this.btnAbrirOdontograma.Text = "Odontograma";
            this.btnAbrirOdontograma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirOdontograma.UseVisualStyleBackColor = false;
            this.btnAbrirOdontograma.Click += new System.EventHandler(this.btnAbrirOdontograma_Click);
            // 
            // btnAbrirAnamnese
            // 
            this.btnAbrirAnamnese.BackColor = System.Drawing.Color.White;
            this.btnAbrirAnamnese.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirAnamnese.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirAnamnese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirAnamnese.Image = global::SistemaOdonto.Properties.Resources.anamnese;
            this.btnAbrirAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirAnamnese.Location = new System.Drawing.Point(4, 475);
            this.btnAbrirAnamnese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrirAnamnese.Name = "btnAbrirAnamnese";
            this.btnAbrirAnamnese.Size = new System.Drawing.Size(182, 66);
            this.btnAbrirAnamnese.TabIndex = 20;
            this.btnAbrirAnamnese.Text = "Anamnese";
            this.btnAbrirAnamnese.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirAnamnese.UseVisualStyleBackColor = false;
            this.btnAbrirAnamnese.Click += new System.EventHandler(this.btnAbrirAnamnese_Click);
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.BackColor = System.Drawing.Color.White;
            this.btnBuscaCEP.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaCEP.FlatAppearance.BorderSize = 2;
            this.btnBuscaCEP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscaCEP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.Image = global::SistemaOdonto.Properties.Resources.search;
            this.btnBuscaCEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaCEP.Location = new System.Drawing.Point(496, 203);
            this.btnBuscaCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(190, 57);
            this.btnBuscaCEP.TabIndex = 10;
            this.btnBuscaCEP.Text = "Buscar CEP";
            this.btnBuscaCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaCEP.UseVisualStyleBackColor = false;
            this.btnBuscaCEP.Click += new System.EventHandler(this.btnBuscaCEP_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(564, 475);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 66);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
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
            this.btnEditar.Location = new System.Drawing.Point(412, 475);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 66);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 645);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbDia);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEditarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente Cadastrado";
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscaCEP;
        private System.Windows.Forms.Label rgpaciente;
        private System.Windows.Forms.Label cpfpaciente;
        private System.Windows.Forms.MaskedTextBox masktxtCPFPaciente;
        private System.Windows.Forms.MaskedTextBox masktxtRGPaciente;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Button btnAbrirAnamnese;
        private System.Windows.Forms.Button btnAbrirOdontograma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbDia;
        public System.Windows.Forms.Button btnExcluir;
    }
}