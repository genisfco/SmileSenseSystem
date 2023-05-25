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
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.dgViewPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(3, 139);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1198, 447);
            this.tc.TabIndex = 1;
            // 
            // masktxtCPFPaciente
            // 
            this.masktxtCPFPaciente.Location = new System.Drawing.Point(12, 40);
            this.masktxtCPFPaciente.Mask = "000.000.000-00";
            this.masktxtCPFPaciente.Name = "masktxtCPFPaciente";
            this.masktxtCPFPaciente.Size = new System.Drawing.Size(122, 26);
            this.masktxtCPFPaciente.TabIndex = 44;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(168, 24);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 42);
            this.btnBuscarPaciente.TabIndex = 45;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // dgViewPaciente
            // 
            this.dgViewPaciente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPaciente.Location = new System.Drawing.Point(260, 3);
            this.dgViewPaciente.Name = "dgViewPaciente";
            this.dgViewPaciente.RowHeadersWidth = 62;
            this.dgViewPaciente.RowTemplate.Height = 28;
            this.dgViewPaciente.Size = new System.Drawing.Size(924, 75);
            this.dgViewPaciente.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "CPF";
            // 
            // FrmDadosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 592);
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
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.DataGridView dgViewPaciente;
        private System.Windows.Forms.Label label1;
    }
}