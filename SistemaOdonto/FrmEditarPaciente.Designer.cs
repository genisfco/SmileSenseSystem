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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, -1);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(28, 13);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "cod.";
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
            this.masktxtCPFPaciente.ReadOnly = true;
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(83, 20);
            this.masktxtCPFPaciente.TabIndex = 4;
            this.masktxtCPFPaciente.Enter += new System.EventHandler(this.masktxtCPFPaciente_Enter);
            // 
            // masktxtRGPaciente
            // 
            this.masktxtRGPaciente.Location = new System.Drawing.Point(51, 55);
            this.masktxtRGPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtRGPaciente.Mask = "00.000.000-C";
            this.masktxtRGPaciente.Name = "masktxtRGPaciente";
            this.masktxtRGPaciente.ReadOnly = true;
            this.masktxtRGPaciente.Size = new System.Drawing.Size(71, 20);
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
            this.cbSexo.Location = new System.Drawing.Point(331, 20);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(128, 21);
            this.cbSexo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 58);
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
            this.txtCEP.TabIndex = 9;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(195, 142);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(87, 20);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(51, 142);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(87, 20);
            this.txtTelefone.TabIndex = 12;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(449, 84);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "UF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Bairro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Logradouro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(69, 26);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(289, 20);
            this.txtEndereco.TabIndex = 14;
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(69, 53);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(112, 20);
            this.txtBairro.TabIndex = 15;
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(247, 53);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(111, 20);
            this.txtCidade.TabIndex = 16;
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nº";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(413, 25);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(29, 20);
            this.txtNum.TabIndex = 11;
            this.txtNum.Enter += new System.EventHandler(this.txtNum_Enter);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(413, 54);
            this.txtUF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(29, 20);
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
            this.cbAno.Location = new System.Drawing.Point(407, 54);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(52, 21);
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
            this.cbMes.Location = new System.Drawing.Point(369, 54);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(36, 21);
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
            this.cbDia.Location = new System.Drawing.Point(331, 54);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(36, 21);
            this.cbDia.TabIndex = 5;
            // 
            // btnAbrirOdontograma
            // 
            this.btnAbrirOdontograma.BackColor = System.Drawing.Color.White;
            this.btnAbrirOdontograma.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirOdontograma.FlatAppearance.BorderSize = 3;
            this.btnAbrirOdontograma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAbrirOdontograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirOdontograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirOdontograma.Image = global::SistemaOdonto.Properties.Resources.Odontograma;
            this.btnAbrirOdontograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirOdontograma.Location = new System.Drawing.Point(139, 309);
            this.btnAbrirOdontograma.Name = "btnAbrirOdontograma";
            this.btnAbrirOdontograma.Size = new System.Drawing.Size(121, 43);
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
            this.btnAbrirAnamnese.FlatAppearance.BorderSize = 3;
            this.btnAbrirAnamnese.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAbrirAnamnese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAbrirAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirAnamnese.Image = global::SistemaOdonto.Properties.Resources.anamnese;
            this.btnAbrirAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirAnamnese.Location = new System.Drawing.Point(3, 309);
            this.btnAbrirAnamnese.Name = "btnAbrirAnamnese";
            this.btnAbrirAnamnese.Size = new System.Drawing.Size(121, 43);
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
            this.btnBuscaCEP.FlatAppearance.BorderSize = 3;
            this.btnBuscaCEP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnBuscaCEP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.Image = global::SistemaOdonto.Properties.Resources.search;
            this.btnBuscaCEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaCEP.Location = new System.Drawing.Point(331, 132);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(127, 37);
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
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcluir.FlatAppearance.BorderSize = 3;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::SistemaOdonto.Properties.Resources.delete_user;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(376, 309);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 43);
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
            this.btnEditar.FlatAppearance.BorderSize = 3;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::SistemaOdonto.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(275, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 43);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 419);
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