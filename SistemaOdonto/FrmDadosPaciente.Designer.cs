﻿namespace SistemaOdonto
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
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(-1, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(799, 331);
            this.tc.TabIndex = 1;
            // 
            // frmConPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 331);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consuta de Pacientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
    }
}