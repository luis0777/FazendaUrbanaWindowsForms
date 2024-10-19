namespace ProjetoFazendaUrbana.view
{
    partial class LoginCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCliente));
            this.textInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSenha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFechar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textInicio
            // 
            this.textInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInicio.AutoSize = true;
            this.textInicio.BackColor = System.Drawing.Color.Transparent;
            this.textInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInicio.ForeColor = System.Drawing.Color.White;
            this.textInicio.Location = new System.Drawing.Point(114, 50);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(61, 28);
            this.textInicio.TabIndex = 2;
            this.textInicio.Text = "Inicio";
            this.textInicio.Click += new System.EventHandler(this.textInicio_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quem somos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textSenha);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Cadastrar);
            this.panel1.Controls.Add(this.textCPF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(401, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 344);
            this.panel1.TabIndex = 4;
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.LavenderBlush;
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(48, 219);
            this.textSenha.Mask = "####";
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(376, 23);
            this.textSenha.TabIndex = 15;
            this.textSenha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textSenha.UseSystemPasswordChar = true;
            this.textSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSenhaKeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(108, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "SENHA";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPF";
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.Color.White;
            this.Cadastrar.Location = new System.Drawing.Point(335, 280);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(89, 35);
            this.Cadastrar.TabIndex = 10;
            this.Cadastrar.Text = "Entrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            this.Cadastrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEntrarKeyPress);
            // 
            // textCPF
            // 
            this.textCPF.BackColor = System.Drawing.Color.LavenderBlush;
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(48, 110);
            this.textCPF.Mask = "###.###.###-##";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(376, 23);
            this.textCPF.TabIndex = 9;
            this.textCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textCPF_MaskInputRejected);
            this.textCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCPFKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "FAZER LOGIN";
            // 
            // textFechar
            // 
            this.textFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFechar.AutoSize = true;
            this.textFechar.BackColor = System.Drawing.Color.Transparent;
            this.textFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.textFechar.ForeColor = System.Drawing.Color.White;
            this.textFechar.Location = new System.Drawing.Point(1163, -3);
            this.textFechar.Name = "textFechar";
            this.textFechar.Size = new System.Drawing.Size(37, 41);
            this.textFechar.TabIndex = 11;
            this.textFechar.Text = "X";
            this.textFechar.Click += new System.EventHandler(this.textFechar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textFechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textInicio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCliente";
            this.Load += new System.EventHandler(this.LoginCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox textSenha;
    }
}