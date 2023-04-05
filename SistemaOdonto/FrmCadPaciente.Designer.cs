namespace SistemaOdonto
{
    partial class FrmCadPaciente
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.rgpaciente = new System.Windows.Forms.Label();
            this.cpfpaciente = new System.Windows.Forms.Label();
            this.masktxtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.masktxtRGPaciente = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscaCEP = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.BackgroundImage = global::SistemaOdonto.Properties.Resources.btnLimpar_BackgroundImage;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(290, 299);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(63, 65);
            this.btnConsulta.TabIndex = 33;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImage = global::SistemaOdonto.Properties.Resources.btnConsulta_BackgroundImage;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(205, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(63, 65);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts,
            this.tsNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(2, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(457, 22);
            this.statusStrip1.TabIndex = 31;
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
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::SistemaOdonto.Properties.Resources.btnSalvar_BackgroundImage;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(119, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(63, 65);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(394, 109);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(64, 20);
            this.txtCEP.TabIndex = 28;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(195, 149);
            this.txtCelular.Mask = "(00) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(87, 20);
            this.txtCelular.TabIndex = 27;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(51, 149);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(87, 20);
            this.txtTelefone.TabIndex = 26;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nasc:";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Location = new System.Drawing.Point(9, 5);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(120, 20);
            this.dtDataNasc.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(329, 30);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(129, 21);
            this.cbSexo.TabIndex = 41;
            // 
            // rgpaciente
            // 
            this.rgpaciente.AutoSize = true;
            this.rgpaciente.Location = new System.Drawing.Point(23, 70);
            this.rgpaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rgpaciente.Name = "rgpaciente";
            this.rgpaciente.Size = new System.Drawing.Size(26, 13);
            this.rgpaciente.TabIndex = 42;
            this.rgpaciente.Text = "RG:";
            // 
            // cpfpaciente
            // 
            this.cpfpaciente.AutoSize = true;
            this.cpfpaciente.Location = new System.Drawing.Point(169, 70);
            this.cpfpaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpfpaciente.Name = "cpfpaciente";
            this.cpfpaciente.Size = new System.Drawing.Size(30, 13);
            this.cpfpaciente.TabIndex = 43;
            this.cpfpaciente.Text = "CPF:";
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(200, 63);
            this.masktxtCPFPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(83, 20);
            this.masktxtCPFPaciente.TabIndex = 44;
            // 
            // masktxtRGPaciente
            // 
            this.masktxtRGPaciente.Location = new System.Drawing.Point(51, 63);
            this.masktxtRGPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtRGPaciente.Mask = "00.000.000-C";
            this.masktxtRGPaciente.Name = "masktxtRGPaciente";
            this.masktxtRGPaciente.Size = new System.Drawing.Size(71, 20);
            this.masktxtRGPaciente.TabIndex = 45;
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaCEP.Location = new System.Drawing.Point(340, 138);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(118, 37);
            this.btnBuscaCEP.TabIndex = 75;
            this.btnBuscaCEP.Text = "Buscar CEP";
            this.btnBuscaCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaCEP.UseVisualStyleBackColor = true;
            this.btnBuscaCEP.Click += new System.EventHandler(this.btnBuscaCEP_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(415, 24);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(29, 20);
            this.txtNum.TabIndex = 76;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(69, 53);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(112, 20);
            this.txtBairro.TabIndex = 77;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(247, 53);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(111, 20);
            this.txtCidade.TabIndex = 78;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(415, 53);
            this.txtUF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(29, 20);
            this.txtUF.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Nº";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Location = new System.Drawing.Point(9, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(449, 84);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "UF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Bairro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Logradouro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(69, 26);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(289, 20);
            this.txtEndereco.TabIndex = 35;
            // 
            // cbDia
            // 
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
            this.cbDia.Location = new System.Drawing.Point(329, 62);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(36, 21);
            this.cbDia.TabIndex = 82;
            // 
            // cbMes
            // 
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
            this.cbMes.Location = new System.Drawing.Point(367, 62);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(36, 21);
            this.cbMes.TabIndex = 83;
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
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
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100",
            "2101",
            "2102",
            "2103",
            "2104",
            "2105",
            "2106",
            "2107",
            "2108",
            "2109",
            "2110",
            "2111",
            "2112",
            "2113",
            "2114",
            "2115",
            "2116",
            "2117",
            "2118",
            "2119",
            "2120",
            "2121",
            "2122",
            "2123",
            "2124",
            "2125",
            "2126",
            "2127",
            "2128",
            "2129",
            "2130",
            "2131",
            "2132",
            "2133",
            "2134",
            "2135",
            "2136",
            "2137",
            "2138",
            "2139",
            "2140",
            "2141",
            "2142",
            "2143",
            "2144",
            "2145",
            "2146",
            "2147",
            "2148",
            "2149",
            "2150",
            "2151",
            "2152",
            "2153",
            "2154",
            "2155",
            "2156",
            "2157",
            "2158",
            "2159",
            "2160",
            "2161",
            "2162",
            "2163",
            "2164",
            "2165",
            "2166",
            "2167",
            "2168",
            "2169",
            "2170",
            "2171",
            "2172",
            "2173",
            "2174",
            "2175",
            "2176",
            "2177",
            "2178",
            "2179",
            "2180",
            "2181",
            "2182",
            "2183",
            "2184",
            "2185",
            "2186",
            "2187",
            "2188",
            "2189",
            "2190",
            "2191",
            "2192",
            "2193",
            "2194",
            "2195",
            "2196",
            "2197",
            "2198",
            "2199",
            "2200"});
            this.cbAno.Location = new System.Drawing.Point(405, 62);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(52, 21);
            this.cbAno.TabIndex = 84;
            // 
            // FrmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 409);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbDia);
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
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.ToolStripStatusLabel tsNenhuma;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label rgpaciente;
        private System.Windows.Forms.Label cpfpaciente;
        private System.Windows.Forms.MaskedTextBox masktxtCPFPaciente;
        private System.Windows.Forms.MaskedTextBox masktxtRGPaciente;
        private System.Windows.Forms.Button btnBuscaCEP;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAno;
    }
}