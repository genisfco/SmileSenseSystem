namespace SistemaOdonto
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDadosDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDadosPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripNovoUser = new System.Windows.Forms.ToolStripMenuItem();
            this.stripGestaoUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.anot = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBarraLogin = new System.Windows.Forms.Panel();
            this.lb_NomeUsuario = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_Acesso = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparNotes = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.pnlBarraLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultarDadosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.MAjuda,
            this.MLogoff,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(985, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsulta,
            this.menuDentista,
            this.menuPaciente});
            this.cadastrosToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.insert;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.cadastrosToolStripMenuItem.Text = "Cadastrar";
            // 
            // menuConsulta
            // 
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(180, 22);
            this.menuConsulta.Text = "Nova Consulta";
            this.menuConsulta.Click += new System.EventHandler(this.menuConsulta_Click);
            // 
            // menuDentista
            // 
            this.menuDentista.Name = "menuDentista";
            this.menuDentista.Size = new System.Drawing.Size(180, 22);
            this.menuDentista.Text = "Novo Dentista";
            this.menuDentista.Click += new System.EventHandler(this.menuDentista_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(180, 22);
            this.menuPaciente.Text = "Novo Paciente";
            this.menuPaciente.Click += new System.EventHandler(this.menuPaciente_Click);
            // 
            // consultarDadosToolStripMenuItem
            // 
            this.consultarDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDadosDentistas,
            this.menuDadosPacientes});
            this.consultarDadosToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.find_file;
            this.consultarDadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultarDadosToolStripMenuItem.Name = "consultarDadosToolStripMenuItem";
            this.consultarDadosToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.consultarDadosToolStripMenuItem.Text = "Consultar Dados";
            // 
            // menuDadosDentistas
            // 
            this.menuDadosDentistas.Name = "menuDadosDentistas";
            this.menuDadosDentistas.Size = new System.Drawing.Size(124, 22);
            this.menuDadosDentistas.Text = "Dentistas";
            this.menuDadosDentistas.Click += new System.EventHandler(this.menuDadosDentistas_Click);
            // 
            // menuDadosPacientes
            // 
            this.menuDadosPacientes.Name = "menuDadosPacientes";
            this.menuDadosPacientes.Size = new System.Drawing.Size(124, 22);
            this.menuDadosPacientes.Text = "Pacientes";
            this.menuDadosPacientes.Click += new System.EventHandler(this.menuDadosPacientes_Click);
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgConsultas});
            this.agendasToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.agendasToolStripMenuItem_Image;
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.agendasToolStripMenuItem.Text = "Agenda";
            // 
            // menuAgConsultas
            // 
            this.menuAgConsultas.Name = "menuAgConsultas";
            this.menuAgConsultas.Size = new System.Drawing.Size(144, 22);
            this.menuAgConsultas.Text = "Abrir Agenda";
            this.menuAgConsultas.Click += new System.EventHandler(this.menuAgConsultas_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripNovoUser,
            this.stripGestaoUser});
            this.usuáriosToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.users;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // stripNovoUser
            // 
            this.stripNovoUser.Name = "stripNovoUser";
            this.stripNovoUser.Size = new System.Drawing.Size(180, 22);
            this.stripNovoUser.Text = "Novo Usuário";
            this.stripNovoUser.Click += new System.EventHandler(this.stripNovoUser_Click);
            // 
            // stripGestaoUser
            // 
            this.stripGestaoUser.Name = "stripGestaoUser";
            this.stripGestaoUser.Size = new System.Drawing.Size(180, 22);
            this.stripGestaoUser.Text = "Gestão de Usuários";
            this.stripGestaoUser.Click += new System.EventHandler(this.stripGestaoUser_Click);
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.MAjuda.Image = global::SistemaOdonto.Properties.Resources.MAjuda_Image;
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(74, 36);
            this.MAjuda.Text = "Ajuda";
            // 
            // menuSuporte
            // 
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(115, 22);
            this.menuSuporte.Text = "Suporte";
            this.menuSuporte.Click += new System.EventHandler(this.menuSuporte_Click);
            // 
            // MLogoff
            // 
            this.MLogoff.Name = "MLogoff";
            this.MLogoff.Size = new System.Drawing.Size(54, 36);
            this.MLogoff.Text = "Logoff";
            this.MLogoff.Click += new System.EventHandler(this.MLogoff_Click);
            // 
            // MSair
            // 
            this.MSair.Image = global::SistemaOdonto.Properties.Resources.delete;
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(62, 36);
            this.MSair.Text = "Sair";
            this.MSair.Click += new System.EventHandler(this.MSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas do Dia";
            // 
            // cbDentista
            // 
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(129, 42);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(210, 21);
            this.cbDentista.TabIndex = 2;
            this.cbDentista.SelectionChangeCommitted += new System.EventHandler(this.cbDentista_SelectionChangeCommitted);
            this.cbDentista.Click += new System.EventHandler(this.cbDentista_Click);
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Hora,
            this.Paciente,
            this.Status,
            this.CodigoPaciente});
            this.dg.Location = new System.Drawing.Point(15, 99);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 62;
            this.dg.Size = new System.Drawing.Size(324, 520);
            this.dg.TabIndex = 3;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "ColunaCodigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            this.Codigo.Width = 150;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.Width = 70;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 8;
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 60;
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.MinimumWidth = 8;
            this.CodigoPaciente.Name = "CodigoPaciente";
            this.CodigoPaciente.Visible = false;
            this.CodigoPaciente.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anotações";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(443, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anot
            // 
            this.anot.AutoScroll = true;
            this.anot.Location = new System.Drawing.Point(370, 315);
            this.anot.Name = "anot";
            this.anot.Size = new System.Drawing.Size(830, 304);
            this.anot.TabIndex = 7;
            // 
            // pnlBarraLogin
            // 
            this.pnlBarraLogin.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBarraLogin.Controls.Add(this.lb_NomeUsuario);
            this.pnlBarraLogin.Controls.Add(this.label24);
            this.pnlBarraLogin.Controls.Add(this.lb_Acesso);
            this.pnlBarraLogin.Controls.Add(this.label26);
            this.pnlBarraLogin.Controls.Add(this.pb_ledLogado);
            this.pnlBarraLogin.Location = new System.Drawing.Point(0, 625);
            this.pnlBarraLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraLogin.Name = "pnlBarraLogin";
            this.pnlBarraLogin.Size = new System.Drawing.Size(1320, 25);
            this.pnlBarraLogin.TabIndex = 29;
            // 
            // lb_NomeUsuario
            // 
            this.lb_NomeUsuario.AutoSize = true;
            this.lb_NomeUsuario.Location = new System.Drawing.Point(127, 5);
            this.lb_NomeUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NomeUsuario.Name = "lb_NomeUsuario";
            this.lb_NomeUsuario.Size = new System.Drawing.Size(16, 13);
            this.lb_NomeUsuario.TabIndex = 4;
            this.lb_NomeUsuario.Text = "---";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 5);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Usuário logado:";
            // 
            // lb_Acesso
            // 
            this.lb_Acesso.AutoSize = true;
            this.lb_Acesso.Location = new System.Drawing.Point(360, 5);
            this.lb_Acesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Acesso.Name = "lb_Acesso";
            this.lb_Acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_Acesso.TabIndex = 2;
            this.lb_Acesso.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(284, 5);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Nível Acesso:";
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::SistemaOdonto.Properties.Resources.Circle_Red;
            this.pb_ledLogado.Location = new System.Drawing.Point(3, 3);
            this.pb_ledLogado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(20, 21);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 0;
            this.pb_ledLogado.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SistemaOdonto.Properties.Resources.banner2_2;
            this.panel1.Location = new System.Drawing.Point(370, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 244);
            this.panel1.TabIndex = 4;
            // 
            // btnLimparNotes
            // 
            this.btnLimparNotes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimparNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparNotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparNotes.Location = new System.Drawing.Point(481, 293);
            this.btnLimparNotes.Name = "btnLimparNotes";
            this.btnLimparNotes.Size = new System.Drawing.Size(33, 23);
            this.btnLimparNotes.TabIndex = 30;
            this.btnLimparNotes.Text = "-";
            this.btnLimparNotes.UseVisualStyleBackColor = false;
            this.btnLimparNotes.Click += new System.EventHandler(this.btnLimparNotes_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SistemaOdonto.Properties.Resources.Circle_Red;
            this.pictureBox5.Location = new System.Drawing.Point(166, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaOdonto.Properties.Resources.Circle_Orange;
            this.pictureBox4.Location = new System.Drawing.Point(241, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 22);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaOdonto.Properties.Resources.Circle_Grey;
            this.pictureBox3.Location = new System.Drawing.Point(15, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaOdonto.Properties.Resources.Circle_Green;
            this.pictureBox2.Location = new System.Drawing.Point(315, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaOdonto.Properties.Resources.Circle_Blue;
            this.pictureBox1.Location = new System.Drawing.Point(91, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(985, 652);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimparNotes);
            this.Controls.Add(this.pnlBarraLogin);
            this.Controls.Add(this.anot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.cbDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmileSense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.pnlBarraLogin.ResumeLayout(false);
            this.pnlBarraLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDentista;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewLinkColumn Paciente;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel anot;
        private System.Windows.Forms.ToolStripMenuItem consultarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDadosDentistas;
        private System.Windows.Forms.ToolStripMenuItem menuDadosPacientes;
        private System.Windows.Forms.ToolStripMenuItem stripGestaoUser;
        private System.Windows.Forms.ToolStripMenuItem stripNovoUser;
        public System.Windows.Forms.Label lb_NomeUsuario;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label lb_Acesso;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.PictureBox pb_ledLogado;
        private System.Windows.Forms.Button btnLimparNotes;
        private System.Windows.Forms.ToolStripMenuItem MLogoff;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlBarraLogin;
        public System.Windows.Forms.ToolStripMenuItem menuDentista;
        public System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}

