namespace SistemaOdonto
{
    partial class FrmGestaoUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirUser = new System.Windows.Forms.Button();
            this.btnSalvarAlterUser = new System.Windows.Forms.Button();
            this.btnNovoUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.nup_Nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.EnableHeadersVisualStyles = false;
            this.dgv_Usuarios.Location = new System.Drawing.Point(348, 26);
            this.dgv_Usuarios.MultiSelect = false;
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowHeadersVisible = false;
            this.dgv_Usuarios.RowHeadersWidth = 62;
            this.dgv_Usuarios.RowTemplate.Height = 28;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(506, 211);
            this.dgv_Usuarios.TabIndex = 46;
            this.dgv_Usuarios.SelectionChanged += new System.EventHandler(this.dgv_Usuarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnExcluirUser);
            this.panel1.Controls.Add(this.btnSalvarAlterUser);
            this.panel1.Controls.Add(this.btnNovoUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 69);
            this.panel1.TabIndex = 45;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::SistemaOdonto.Properties.Resources.delete;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(736, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(148, 66);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluirUser
            // 
            this.btnExcluirUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUser.Image = global::SistemaOdonto.Properties.Resources.delete_user;
            this.btnExcluirUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirUser.Location = new System.Drawing.Point(492, 3);
            this.btnExcluirUser.Name = "btnExcluirUser";
            this.btnExcluirUser.Size = new System.Drawing.Size(189, 63);
            this.btnExcluirUser.TabIndex = 2;
            this.btnExcluirUser.Text = "Excluir Usuário";
            this.btnExcluirUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirUser.UseVisualStyleBackColor = true;
            this.btnExcluirUser.Click += new System.EventHandler(this.btnExcluirUser_Click);
            // 
            // btnSalvarAlterUser
            // 
            this.btnSalvarAlterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlterUser.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalvarAlterUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarAlterUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalvarAlterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlterUser.Image = global::SistemaOdonto.Properties.Resources.reload;
            this.btnSalvarAlterUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAlterUser.Location = new System.Drawing.Point(231, 2);
            this.btnSalvarAlterUser.Name = "btnSalvarAlterUser";
            this.btnSalvarAlterUser.Size = new System.Drawing.Size(204, 63);
            this.btnSalvarAlterUser.TabIndex = 1;
            this.btnSalvarAlterUser.Text = "Salvar alterações";
            this.btnSalvarAlterUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarAlterUser.UseVisualStyleBackColor = true;
            this.btnSalvarAlterUser.Click += new System.EventHandler(this.btnSalvarAlterUser_Click);
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUser.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnNovoUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNovoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoUser.Image = global::SistemaOdonto.Properties.Resources.file;
            this.btnNovoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoUser.Location = new System.Drawing.Point(0, 3);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Size = new System.Drawing.Size(178, 63);
            this.btnNovoUser.TabIndex = 0;
            this.btnNovoUser.Text = "Novo Usuário";
            this.btnNovoUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoUser.UseVisualStyleBackColor = true;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(8, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(110, 26);
            this.txt_ID.TabIndex = 43;
            this.txt_ID.TabStop = false;
            // 
            // nup_Nivel
            // 
            this.nup_Nivel.Location = new System.Drawing.Point(6, 294);
            this.nup_Nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nup_Nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Nivel.Name = "nup_Nivel";
            this.nup_Nivel.ReadOnly = true;
            this.nup_Nivel.Size = new System.Drawing.Size(112, 26);
            this.nup_Nivel.TabIndex = 39;
            this.nup_Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_Status.Location = new System.Drawing.Point(156, 292);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(58, 28);
            this.cb_Status.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nível Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(156, 211);
            this.txt_Senha.MaxLength = 10;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(162, 26);
            this.txt_Senha.TabIndex = 32;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(8, 211);
            this.txt_Username.MaxLength = 8;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(110, 26);
            this.txt_Username.TabIndex = 31;
            // 
            // txt_NomeUsuario
            // 
            this.txt_NomeUsuario.Location = new System.Drawing.Point(8, 111);
            this.txt_NomeUsuario.MaxLength = 30;
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.Size = new System.Drawing.Size(310, 26);
            this.txt_NomeUsuario.TabIndex = 30;
            this.txt_NomeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeUsuario_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SistemaOdonto.Properties.Resources.user_online;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(814, 275);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 45);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaOdonto.Properties.Resources.user2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(582, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 45);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SistemaOdonto.Properties.Resources.user_offline;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(342, 275);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 45);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "D=Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "B=Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "A=Ativo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.txt_NomeUsuario);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_Username);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txt_Senha);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgv_Usuarios);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_Status);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.nup_Nivel);
            this.panel2.Location = new System.Drawing.Point(13, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 337);
            this.panel2.TabIndex = 53;
            // 
            // FrmGestaoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(888, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestaoUser";
            this.Text = "Gestão de Usuários";
            this.Load += new System.EventHandler(this.FrmGestaoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirUser;
        private System.Windows.Forms.Button btnSalvarAlterUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovoUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.NumericUpDown nup_Nivel;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_NomeUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}