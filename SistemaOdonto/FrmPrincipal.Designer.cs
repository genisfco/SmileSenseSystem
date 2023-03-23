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
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultarDadosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2055, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsulta,
            this.menuDentista,
            this.menuPaciente});
            this.cadastrosToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.cadastrosToolStripMenuItem_Image;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastrar";
            // 
            // menuConsulta
            // 
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(230, 34);
            this.menuConsulta.Text = "Nova Consulta";
            this.menuConsulta.Click += new System.EventHandler(this.menuConsulta_Click);
            // 
            // menuDentista
            // 
            this.menuDentista.Name = "menuDentista";
            this.menuDentista.Size = new System.Drawing.Size(230, 34);
            this.menuDentista.Text = "Novo Dentista";
            this.menuDentista.Click += new System.EventHandler(this.menuDentista_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(230, 34);
            this.menuPaciente.Text = "Novo Paciente";
            this.menuPaciente.Click += new System.EventHandler(this.menuPaciente_Click);
            // 
            // consultarDadosToolStripMenuItem
            // 
            this.consultarDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDadosDentistas,
            this.menuDadosPacientes});
            this.consultarDadosToolStripMenuItem.Name = "consultarDadosToolStripMenuItem";
            this.consultarDadosToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.consultarDadosToolStripMenuItem.Text = "Consultar Dados";
            // 
            // menuDadosDentistas
            // 
            this.menuDadosDentistas.Name = "menuDadosDentistas";
            this.menuDadosDentistas.Size = new System.Drawing.Size(270, 34);
            this.menuDadosDentistas.Text = "Dentistas";
            this.menuDadosDentistas.Click += new System.EventHandler(this.menuDadosDentistas_Click);
            // 
            // menuDadosPacientes
            // 
            this.menuDadosPacientes.Name = "menuDadosPacientes";
            this.menuDadosPacientes.Size = new System.Drawing.Size(270, 34);
            this.menuDadosPacientes.Text = "Pacientes";
            this.menuDadosPacientes.Click += new System.EventHandler(this.menuDadosPacientes_Click);
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgConsultas});
            this.agendasToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.agendasToolStripMenuItem_Image;
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.agendasToolStripMenuItem.Text = "Agenda";
            // 
            // menuAgConsultas
            // 
            this.menuAgConsultas.Name = "menuAgConsultas";
            this.menuAgConsultas.Size = new System.Drawing.Size(286, 34);
            this.menuAgConsultas.Text = "Consultas Agendadas";
            this.menuAgConsultas.Click += new System.EventHandler(this.menuAgConsultas_Click);
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.MAjuda.Image = global::SistemaOdonto.Properties.Resources.MAjuda_Image;
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(98, 29);
            this.MAjuda.Text = "Ajuda";
            // 
            // menuSuporte
            // 
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(177, 34);
            this.menuSuporte.Text = "Suporte";
            this.menuSuporte.Click += new System.EventHandler(this.menuSuporte_Click);
            // 
            // MSair
            // 
            this.MSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair});
            this.MSair.Image = global::SistemaOdonto.Properties.Resources.MSair_Image;
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(81, 29);
            this.MSair.Text = "Sair";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(143, 34);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas do Dia";
            // 
            // cbDentista
            // 
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(194, 63);
            this.cbDentista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(313, 28);
            this.cbDentista.TabIndex = 2;
            this.cbDentista.SelectedIndexChanged += new System.EventHandler(this.cbDentista_SelectedIndexChanged);
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
            this.dg.Location = new System.Drawing.Point(22, 117);
            this.dg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 62;
            this.dg.Size = new System.Drawing.Size(486, 1108);
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
            this.label2.Location = new System.Drawing.Point(550, 562);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
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
            this.button1.Location = new System.Drawing.Point(681, 558);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anot
            // 
            this.anot.Location = new System.Drawing.Point(555, 609);
            this.anot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anot.Name = "anot";
            this.anot.Size = new System.Drawing.Size(1245, 692);
            this.anot.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SistemaOdonto.Properties.Resources.panel11;
            this.panel1.Location = new System.Drawing.Point(555, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 462);
            this.panel1.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1392, 975);
            this.Controls.Add(this.anot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.cbDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Sistema Odonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuDentista;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
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
    }
}

