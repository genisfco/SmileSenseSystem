namespace SistemaOdonto
{
    partial class FrmAnotacoes
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
            this.btnAdicionarLembrete = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.btnRoxo = new System.Windows.Forms.Button();
            this.btnLaranja = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAdicionarLembrete
            // 
            this.btnAdicionarLembrete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLembrete.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarLembrete.Location = new System.Drawing.Point(20, 10);
            this.btnAdicionarLembrete.Name = "btnAdicionarLembrete";
            this.btnAdicionarLembrete.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarLembrete.TabIndex = 13;
            this.btnAdicionarLembrete.Text = "Adicionar";
            this.btnAdicionarLembrete.UseVisualStyleBackColor = false;
            this.btnAdicionarLembrete.Click += new System.EventHandler(this.btnAdicionarLembrete_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmarelo.Location = new System.Drawing.Point(140, 9);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(24, 24);
            this.btnAmarelo.TabIndex = 12;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnRosa
            // 
            this.btnRosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRosa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRosa.Location = new System.Drawing.Point(260, 9);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(24, 24);
            this.btnRosa.TabIndex = 11;
            this.btnRosa.UseVisualStyleBackColor = false;
            this.btnRosa.Click += new System.EventHandler(this.btnRosa_Click);
            // 
            // btnRoxo
            // 
            this.btnRoxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoxo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoxo.Location = new System.Drawing.Point(230, 9);
            this.btnRoxo.Name = "btnRoxo";
            this.btnRoxo.Size = new System.Drawing.Size(24, 24);
            this.btnRoxo.TabIndex = 10;
            this.btnRoxo.UseVisualStyleBackColor = false;
            this.btnRoxo.Click += new System.EventHandler(this.btnRoxo_Click);
            // 
            // btnLaranja
            // 
            this.btnLaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaranja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaranja.Location = new System.Drawing.Point(200, 9);
            this.btnLaranja.Name = "btnLaranja";
            this.btnLaranja.Size = new System.Drawing.Size(24, 24);
            this.btnLaranja.TabIndex = 9;
            this.btnLaranja.UseVisualStyleBackColor = false;
            this.btnLaranja.Click += new System.EventHandler(this.btnLaranja_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.GreenYellow;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerde.Location = new System.Drawing.Point(170, 9);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(24, 24);
            this.btnVerde.TabIndex = 8;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 45);
            this.richTextBox1.MaxLength = 144;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 213);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // frmAnotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 264);
            this.Controls.Add(this.btnAdicionarLembrete);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnRosa);
            this.Controls.Add(this.btnRoxo);
            this.Controls.Add(this.btnLaranja);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnotacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Anotação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarLembrete;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnRosa;
        private System.Windows.Forms.Button btnRoxo;
        private System.Windows.Forms.Button btnLaranja;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}