namespace ProjetoFazendaUrbana.view
{
    partial class CadastroCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSenha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textClienteLog = new System.Windows.Forms.ToolStripMenuItem();
            this.textAdmLog = new System.Windows.Forms.ToolStripMenuItem();
            this.textFechar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.textSenha);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cadastrar);
            this.panel1.Controls.Add(this.textCPF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.textNome);
            this.panel1.Location = new System.Drawing.Point(675, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 408);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.LavenderBlush;
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(24, 295);
            this.textSenha.Mask = "####";
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(279, 23);
            this.textSenha.TabIndex = 19;
            this.textSenha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textSenha.UseSystemPasswordChar = true;
            this.textSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textSenha_MaskInputRejected);
            this.textSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSenhaKeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(81, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "SENHA";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "EMAIL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOME";
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.Color.White;
            this.Cadastrar.Location = new System.Drawing.Point(191, 343);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(112, 33);
            this.Cadastrar.TabIndex = 10;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // textCPF
            // 
            this.textCPF.BackColor = System.Drawing.Color.LavenderBlush;
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(22, 167);
            this.textCPF.Mask = "###.###.###-##";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(281, 23);
            this.textCPF.TabIndex = 9;
            this.textCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInteger_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "CLIENTE NOVO?\nFAÇA SEU CADASTRO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.LavenderBlush;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textEmail.Location = new System.Drawing.Point(23, 234);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(281, 25);
            this.textEmail.TabIndex = 3;
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmailKeyPress);
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.LavenderBlush;
            this.textNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textNome.Location = new System.Drawing.Point(22, 110);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(281, 25);
            this.textNome.TabIndex = 1;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            this.textNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLetras_KeyPress);
            // 
            // textInicio
            // 
            this.textInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInicio.AutoSize = true;
            this.textInicio.BackColor = System.Drawing.Color.Transparent;
            this.textInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInicio.ForeColor = System.Drawing.Color.White;
            this.textInicio.Location = new System.Drawing.Point(98, 44);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(54, 24);
            this.textInicio.TabIndex = 1;
            this.textInicio.Text = "Inicio";
            this.textInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quem somos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 45F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(197, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 373);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descubra a magia em cada pedaço com pitaya fresca";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseWaitCursor = true;
            // 
            // textlogin
            // 
            this.textlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textlogin.AutoSize = true;
            this.textlogin.BackColor = System.Drawing.Color.Transparent;
            this.textlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlogin.ForeColor = System.Drawing.Color.White;
            this.textlogin.Location = new System.Drawing.Point(994, 44);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(110, 24);
            this.textlogin.TabIndex = 5;
            this.textlogin.Text = "Fazer Login";
            this.textlogin.Click += new System.EventHandler(this.label9_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip1.BackgroundImage")));
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textClienteLog,
            this.textAdmLog});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // textClienteLog
            // 
            this.textClienteLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.textClienteLog.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.textClienteLog.ForeColor = System.Drawing.Color.White;
            this.textClienteLog.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.textClienteLog.Name = "textClienteLog";
            this.textClienteLog.Size = new System.Drawing.Size(147, 22);
            this.textClienteLog.Text = "Cliente";
            this.textClienteLog.Click += new System.EventHandler(this.textClienteLog_Click);
            // 
            // textAdmLog
            // 
            this.textAdmLog.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.textAdmLog.ForeColor = System.Drawing.Color.White;
            this.textAdmLog.Name = "textAdmLog";
            this.textAdmLog.Size = new System.Drawing.Size(147, 22);
            this.textAdmLog.Text = "Administrador";
            // 
            // textFechar
            // 
            this.textFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFechar.AutoSize = true;
            this.textFechar.BackColor = System.Drawing.Color.Transparent;
            this.textFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 25F);
            this.textFechar.ForeColor = System.Drawing.Color.White;
            this.textFechar.Location = new System.Drawing.Point(1162, -2);
            this.textFechar.Name = "textFechar";
            this.textFechar.Size = new System.Drawing.Size(41, 46);
            this.textFechar.TabIndex = 6;
            this.textFechar.Text = "X";
            this.textFechar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textFechar);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textInicio);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.INICIO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label textlogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textClienteLog;
        private System.Windows.Forms.ToolStripMenuItem textAdmLog;
        private System.Windows.Forms.Label textFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox textSenha;
    }
}