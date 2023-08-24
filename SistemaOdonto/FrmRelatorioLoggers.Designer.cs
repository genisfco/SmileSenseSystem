namespace SistemaOdonto
{
    partial class FrmRelatorioLoggers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioLoggers));
            this.dataGridRelatorio = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chboxBuscaespec = new System.Windows.Forms.CheckBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.comboxBuscaespec = new System.Windows.Forms.ComboBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.comboxSobre = new System.Windows.Forms.ComboBox();
            this.chboxData = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxTipo = new System.Windows.Forms.ComboBox();
            this.comboxUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRelatorio
            // 
            this.dataGridRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelatorio.Location = new System.Drawing.Point(363, 49);
            this.dataGridRelatorio.Name = "dataGridRelatorio";
            this.dataGridRelatorio.RowHeadersWidth = 62;
            this.dataGridRelatorio.RowTemplate.Height = 28;
            this.dataGridRelatorio.Size = new System.Drawing.Size(1076, 607);
            this.dataGridRelatorio.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(359, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Relatório Solicitado";
            // 
            // chboxBuscaespec
            // 
            this.chboxBuscaespec.AutoSize = true;
            this.chboxBuscaespec.Location = new System.Drawing.Point(12, 270);
            this.chboxBuscaespec.Name = "chboxBuscaespec";
            this.chboxBuscaespec.Size = new System.Drawing.Size(155, 24);
            this.chboxBuscaespec.TabIndex = 10;
            this.chboxBuscaespec.Text = "Busca específica";
            this.chboxBuscaespec.UseVisualStyleBackColor = true;
            this.chboxBuscaespec.CheckedChanged += new System.EventHandler(this.chboxBuscaespec_CheckedChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(12, 426);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(146, 26);
            this.dtInicio.TabIndex = 11;
            // 
            // comboxBuscaespec
            // 
            this.comboxBuscaespec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBuscaespec.FormattingEnabled = true;
            this.comboxBuscaespec.Items.AddRange(new object[] {
            "Todos",
            "Cadastro",
            "Atualização",
            "Deleção"});
            this.comboxBuscaespec.Location = new System.Drawing.Point(12, 300);
            this.comboxBuscaespec.Name = "comboxBuscaespec";
            this.comboxBuscaespec.Size = new System.Drawing.Size(317, 28);
            this.comboxBuscaespec.TabIndex = 9;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(183, 426);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(146, 26);
            this.dtFinal.TabIndex = 13;
            // 
            // comboxSobre
            // 
            this.comboxSobre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSobre.FormattingEnabled = true;
            this.comboxSobre.Items.AddRange(new object[] {
            "Todos",
            "Paciente",
            "Dentista",
            "Consulta",
            "Anamnese",
            "Procedimento",
            "Usuário"});
            this.comboxSobre.Location = new System.Drawing.Point(12, 174);
            this.comboxSobre.Name = "comboxSobre";
            this.comboxSobre.Size = new System.Drawing.Size(146, 28);
            this.comboxSobre.TabIndex = 8;
            this.comboxSobre.SelectedIndexChanged += new System.EventHandler(this.cboxSobre_SelectedIndexChanged);
            // 
            // chboxData
            // 
            this.chboxData.AutoSize = true;
            this.chboxData.Location = new System.Drawing.Point(103, 396);
            this.chboxData.Name = "chboxData";
            this.chboxData.Size = new System.Drawing.Size(128, 24);
            this.chboxData.TabIndex = 14;
            this.chboxData.Text = "Data Período";
            this.chboxData.UseVisualStyleBackColor = true;
            this.chboxData.CheckedChanged += new System.EventHandler(this.chboxData_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Busca Referente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Registro";
            // 
            // comboxTipo
            // 
            this.comboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTipo.FormattingEnabled = true;
            this.comboxTipo.Items.AddRange(new object[] {
            "Todos",
            "Cadastro",
            "Atualização",
            "Deleção"});
            this.comboxTipo.Location = new System.Drawing.Point(183, 174);
            this.comboxTipo.Name = "comboxTipo";
            this.comboxTipo.Size = new System.Drawing.Size(146, 28);
            this.comboxTipo.TabIndex = 1;
            // 
            // comboxUsuarios
            // 
            this.comboxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxUsuarios.FormattingEnabled = true;
            this.comboxUsuarios.Items.AddRange(new object[] {
            "Todos\t\t\t"});
            this.comboxUsuarios.Location = new System.Drawing.Point(12, 48);
            this.comboxUsuarios.Name = "comboxUsuarios";
            this.comboxUsuarios.Size = new System.Drawing.Size(146, 28);
            this.comboxUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboxUsuarios);
            this.panel1.Controls.Add(this.comboxTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chboxData);
            this.panel1.Controls.Add(this.comboxSobre);
            this.panel1.Controls.Add(this.dtFinal);
            this.panel1.Controls.Add(this.comboxBuscaespec);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Controls.Add(this.chboxBuscaespec);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 475);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(99, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Filtros de Pesquisa";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::SistemaOdonto.Properties.Resources.delete;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(13, 596);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(340, 58);
            this.btnFechar.TabIndex = 72;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.White;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Image = global::SistemaOdonto.Properties.Resources.btnLimpar_BackgroundImage;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.Location = new System.Drawing.Point(12, 532);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(340, 58);
            this.btnRelatorio.TabIndex = 71;
            this.btnRelatorio.Text = "Exibir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // FrmRelatorioLoggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1446, 668);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1468, 724);
            this.MinimumSize = new System.Drawing.Size(1468, 724);
            this.Name = "FrmRelatorioLoggers";
            this.Text = "Relatório de Registros dos Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAcoesUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridRelatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chboxBuscaespec;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ComboBox comboxBuscaespec;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.ComboBox comboxSobre;
        private System.Windows.Forms.CheckBox chboxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxTipo;
        private System.Windows.Forms.ComboBox comboxUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRelatorio;
    }
}