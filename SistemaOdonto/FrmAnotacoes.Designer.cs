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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnotacoes));
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.btnRoxo = new System.Windows.Forms.Button();
            this.btnLaranja = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarLembrete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmarelo.Location = new System.Drawing.Point(204, 12);
            this.btnAmarelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(36, 71);
            this.btnAmarelo.TabIndex = 12;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnRosa
            // 
            this.btnRosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRosa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRosa.Location = new System.Drawing.Point(384, 12);
            this.btnRosa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(36, 71);
            this.btnRosa.TabIndex = 11;
            this.btnRosa.UseVisualStyleBackColor = false;
            this.btnRosa.Click += new System.EventHandler(this.btnRosa_Click);
            // 
            // btnRoxo
            // 
            this.btnRoxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoxo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoxo.Location = new System.Drawing.Point(339, 12);
            this.btnRoxo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoxo.Name = "btnRoxo";
            this.btnRoxo.Size = new System.Drawing.Size(36, 71);
            this.btnRoxo.TabIndex = 10;
            this.btnRoxo.UseVisualStyleBackColor = false;
            this.btnRoxo.Click += new System.EventHandler(this.btnRoxo_Click);
            // 
            // btnLaranja
            // 
            this.btnLaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaranja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaranja.Location = new System.Drawing.Point(294, 12);
            this.btnLaranja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaranja.Name = "btnLaranja";
            this.btnLaranja.Size = new System.Drawing.Size(36, 71);
            this.btnLaranja.TabIndex = 9;
            this.btnLaranja.UseVisualStyleBackColor = false;
            this.btnLaranja.Click += new System.EventHandler(this.btnLaranja_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.GreenYellow;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerde.Location = new System.Drawing.Point(249, 12);
            this.btnVerde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(36, 71);
            this.btnVerde.TabIndex = 8;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 92);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.MaxLength = 144;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 301);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btnAdicionarLembrete);
            this.panel1.Controls.Add(this.btnVerde);
            this.panel1.Controls.Add(this.btnAmarelo);
            this.panel1.Controls.Add(this.btnLaranja);
            this.panel1.Controls.Add(this.btnRosa);
            this.panel1.Controls.Add(this.btnRoxo);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 405);
            this.panel1.TabIndex = 14;
            // 
            // btnAdicionarLembrete
            // 
            this.btnAdicionarLembrete.BackColor = System.Drawing.Color.White;
            this.btnAdicionarLembrete.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdicionarLembrete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionarLembrete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdicionarLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLembrete.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarLembrete.Image = global::SistemaOdonto.Properties.Resources.insert;
            this.btnAdicionarLembrete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarLembrete.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarLembrete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionarLembrete.Name = "btnAdicionarLembrete";
            this.btnAdicionarLembrete.Size = new System.Drawing.Size(148, 71);
            this.btnAdicionarLembrete.TabIndex = 13;
            this.btnAdicionarLembrete.Text = "Adicionar";
            this.btnAdicionarLembrete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarLembrete.UseVisualStyleBackColor = false;
            this.btnAdicionarLembrete.Click += new System.EventHandler(this.btnAdicionarLembrete_Click);
            // 
            // FrmAnotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(461, 422);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnotacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Anotação";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}