namespace SistemaOdonto
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.textBoxBanco = new System.Windows.Forms.TextBox();
            this.labelBanco = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.checkBoxAutentWind = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.Location = new System.Drawing.Point(16, 97);
            this.textBoxBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(262, 26);
            this.textBoxBanco.TabIndex = 22;
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanco.Location = new System.Drawing.Point(12, 74);
            this.labelBanco.Name = "labelBanco";
            this.labelBanco.Size = new System.Drawing.Size(60, 20);
            this.labelBanco.TabIndex = 21;
            this.labelBanco.Text = "Banco";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(151, 173);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(127, 26);
            this.textBoxSenha.TabIndex = 20;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(147, 150);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 20);
            this.labelPass.TabIndex = 19;
            this.labelPass.Text = "Senha";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravar.Location = new System.Drawing.Point(12, 277);
            this.buttonGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(266, 51);
            this.buttonGravar.TabIndex = 18;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(18, 173);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(127, 26);
            this.textBoxUsuario.TabIndex = 17;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(13, 150);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(71, 20);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "Usuario";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(17, 33);
            this.textBoxLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(261, 26);
            this.textBoxLocal.TabIndex = 15;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(12, 9);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(52, 20);
            this.labelLocal.TabIndex = 14;
            this.labelLocal.Text = "Local";
            // 
            // checkBoxAutentWind
            // 
            this.checkBoxAutentWind.AutoSize = true;
            this.checkBoxAutentWind.Location = new System.Drawing.Point(17, 213);
            this.checkBoxAutentWind.Name = "checkBoxAutentWind";
            this.checkBoxAutentWind.Size = new System.Drawing.Size(219, 24);
            this.checkBoxAutentWind.TabIndex = 23;
            this.checkBoxAutentWind.Text = "Autenticação do Windows";
            this.checkBoxAutentWind.UseVisualStyleBackColor = true;
            this.checkBoxAutentWind.CheckedChanged += new System.EventHandler(this.checkBoxAutentWind_CheckedChanged);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 339);
            this.Controls.Add(this.checkBoxAutentWind);
            this.Controls.Add(this.textBoxBanco);
            this.Controls.Add(this.labelBanco);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.labelLocal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.Text = "Configuração Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBanco;
        private System.Windows.Forms.Label labelBanco;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.CheckBox checkBoxAutentWind;
    }
}