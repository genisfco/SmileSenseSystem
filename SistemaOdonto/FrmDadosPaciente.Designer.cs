namespace SistemaOdonto
{
    partial class FrmDadosPaciente
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
            this.tc = new System.Windows.Forms.TabControl();
            this.masktxtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.dgViewPaciente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(3, 172);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1198, 414);
            this.tc.TabIndex = 1;
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(12, 92);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(152, 30);
            this.masktxtCPFPaciente.TabIndex = 44;
            this.masktxtCPFPaciente.Enter += new System.EventHandler(this.masktxtCPFPaciente_Enter);
            // 
            // dgViewPaciente
            // 
            this.dgViewPaciente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Telefone,
            this.Celular,
            this.Email});
            this.dgViewPaciente.Location = new System.Drawing.Point(383, 26);
            this.dgViewPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgViewPaciente.Name = "dgViewPaciente";
            this.dgViewPaciente.ReadOnly = true;
            this.dgViewPaciente.RowHeadersVisible = false;
            this.dgViewPaciente.RowHeadersWidth = 62;
            this.dgViewPaciente.RowTemplate.Height = 28;
            this.dgViewPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewPaciente.Size = new System.Drawing.Size(809, 102);
            this.dgViewPaciente.TabIndex = 50;
            this.dgViewPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPaciente_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 20;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 190;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 8;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone.Width = 115;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 8;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Celular.Width = 115;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "CPF";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Image = global::SistemaOdonto.Properties.Resources.find_file;
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(185, 59);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(154, 68);
            this.btnBuscarPaciente.TabIndex = 49;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // FrmDadosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgViewPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.masktxtCPFPaciente);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDadosPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consuta de Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.MaskedTextBox masktxtCPFPaciente;
        private System.Windows.Forms.DataGridView dgViewPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}