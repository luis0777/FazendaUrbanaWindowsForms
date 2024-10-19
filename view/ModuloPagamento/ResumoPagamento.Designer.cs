namespace ProjetoFazendaUrbana.view
{
    partial class ResumoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumoPagamento));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textResumo = new System.Windows.Forms.LinkLabel();
            this.textValorTotal = new System.Windows.Forms.TextBox();
            this.textForPag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.textNomeSelBran = new System.Windows.Forms.Label();
            this.textNomeSelAmar = new System.Windows.Forms.Label();
            this.textQuanSeLVerm = new System.Windows.Forms.Label();
            this.textQuanSeLBran = new System.Windows.Forms.Label();
            this.textQuanSeLAmar = new System.Windows.Forms.Label();
            this.textPrecSelAmar = new System.Windows.Forms.Label();
            this.textPrecSelBran = new System.Windows.Forms.Label();
            this.textPrecSelVerm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomeSelVerm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(-9, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(451, 147);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(237, 65);
            this.label25.TabIndex = 25;
            this.label25.Text = "PAGAMENTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.textResumo);
            this.panel1.Controls.Add(this.textValorTotal);
            this.panel1.Controls.Add(this.textForPag);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(416, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 225);
            this.panel1.TabIndex = 26;
            // 
            // textResumo
            // 
            this.textResumo.AutoSize = true;
            this.textResumo.Font = new System.Drawing.Font("Arial Black", 8F);
            this.textResumo.LinkColor = System.Drawing.Color.Black;
            this.textResumo.Location = new System.Drawing.Point(92, 86);
            this.textResumo.Name = "textResumo";
            this.textResumo.Size = new System.Drawing.Size(121, 15);
            this.textResumo.TabIndex = 28;
            this.textResumo.TabStop = true;
            this.textResumo.Text = "Resumo da compra";
            this.textResumo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textResumo_LinkClicked_1);
            this.textResumo.Click += new System.EventHandler(this.textResumoClick);
            // 
            // textValorTotal
            // 
            this.textValorTotal.Enabled = false;
            this.textValorTotal.Font = new System.Drawing.Font("Arial Black", 12F);
            this.textValorTotal.Location = new System.Drawing.Point(46, 53);
            this.textValorTotal.Name = "textValorTotal";
            this.textValorTotal.Size = new System.Drawing.Size(207, 30);
            this.textValorTotal.TabIndex = 27;
            this.textValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textValorTotal.TextChanged += new System.EventHandler(this.textValorTotal_TextChanged);
            // 
            // textForPag
            // 
            this.textForPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textForPag.FormattingEnabled = true;
            this.textForPag.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Pix"});
            this.textForPag.Location = new System.Drawing.Point(46, 150);
            this.textForPag.Name = "textForPag";
            this.textForPag.Size = new System.Drawing.Size(207, 25);
            this.textForPag.TabIndex = 11;
            this.textForPag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFormaPagKeyDown);
            this.textForPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFormaPagKeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "FORMA DE PAGAMENTO";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "PREÇO TOTAL";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Location = new System.Drawing.Point(1104, 642);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(51, 46);
            this.pictureBox11.TabIndex = 35;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // textNomeSelBran
            // 
            this.textNomeSelBran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNomeSelBran.AutoSize = true;
            this.textNomeSelBran.BackColor = System.Drawing.Color.Transparent;
            this.textNomeSelBran.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textNomeSelBran.ForeColor = System.Drawing.Color.Black;
            this.textNomeSelBran.Location = new System.Drawing.Point(51, 127);
            this.textNomeSelBran.Name = "textNomeSelBran";
            this.textNomeSelBran.Size = new System.Drawing.Size(102, 20);
            this.textNomeSelBran.TabIndex = 43;
            this.textNomeSelBran.Text = "Pitaya Branca";
            this.textNomeSelBran.Visible = false;
            // 
            // textNomeSelAmar
            // 
            this.textNomeSelAmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNomeSelAmar.AutoSize = true;
            this.textNomeSelAmar.BackColor = System.Drawing.Color.Transparent;
            this.textNomeSelAmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textNomeSelAmar.ForeColor = System.Drawing.Color.Black;
            this.textNomeSelAmar.Location = new System.Drawing.Point(51, 219);
            this.textNomeSelAmar.Name = "textNomeSelAmar";
            this.textNomeSelAmar.Size = new System.Drawing.Size(112, 20);
            this.textNomeSelAmar.TabIndex = 44;
            this.textNomeSelAmar.Text = "Pitaya Amarela";
            this.textNomeSelAmar.Visible = false;
            // 
            // textQuanSeLVerm
            // 
            this.textQuanSeLVerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuanSeLVerm.AutoSize = true;
            this.textQuanSeLVerm.BackColor = System.Drawing.Color.Transparent;
            this.textQuanSeLVerm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textQuanSeLVerm.ForeColor = System.Drawing.Color.Black;
            this.textQuanSeLVerm.Location = new System.Drawing.Point(30, 63);
            this.textQuanSeLVerm.Name = "textQuanSeLVerm";
            this.textQuanSeLVerm.Size = new System.Drawing.Size(53, 20);
            this.textQuanSeLVerm.TabIndex = 45;
            this.textQuanSeLVerm.Text = "quant.";
            this.textQuanSeLVerm.Visible = false;
            // 
            // textQuanSeLBran
            // 
            this.textQuanSeLBran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuanSeLBran.AutoSize = true;
            this.textQuanSeLBran.BackColor = System.Drawing.Color.Transparent;
            this.textQuanSeLBran.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textQuanSeLBran.ForeColor = System.Drawing.Color.Black;
            this.textQuanSeLBran.Location = new System.Drawing.Point(29, 153);
            this.textQuanSeLBran.Name = "textQuanSeLBran";
            this.textQuanSeLBran.Size = new System.Drawing.Size(53, 20);
            this.textQuanSeLBran.TabIndex = 46;
            this.textQuanSeLBran.Text = "quant.";
            this.textQuanSeLBran.Visible = false;
            // 
            // textQuanSeLAmar
            // 
            this.textQuanSeLAmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuanSeLAmar.AutoSize = true;
            this.textQuanSeLAmar.BackColor = System.Drawing.Color.Transparent;
            this.textQuanSeLAmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textQuanSeLAmar.ForeColor = System.Drawing.Color.Black;
            this.textQuanSeLAmar.Location = new System.Drawing.Point(28, 243);
            this.textQuanSeLAmar.Name = "textQuanSeLAmar";
            this.textQuanSeLAmar.Size = new System.Drawing.Size(53, 20);
            this.textQuanSeLAmar.TabIndex = 47;
            this.textQuanSeLAmar.Text = "quant.";
            this.textQuanSeLAmar.Visible = false;
            // 
            // textPrecSelAmar
            // 
            this.textPrecSelAmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrecSelAmar.AutoSize = true;
            this.textPrecSelAmar.BackColor = System.Drawing.Color.Transparent;
            this.textPrecSelAmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textPrecSelAmar.ForeColor = System.Drawing.Color.Black;
            this.textPrecSelAmar.Location = new System.Drawing.Point(116, 243);
            this.textPrecSelAmar.Name = "textPrecSelAmar";
            this.textPrecSelAmar.Size = new System.Drawing.Size(53, 20);
            this.textPrecSelAmar.TabIndex = 48;
            this.textPrecSelAmar.Text = "quant.";
            this.textPrecSelAmar.Visible = false;
            // 
            // textPrecSelBran
            // 
            this.textPrecSelBran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrecSelBran.AutoSize = true;
            this.textPrecSelBran.BackColor = System.Drawing.Color.Transparent;
            this.textPrecSelBran.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textPrecSelBran.ForeColor = System.Drawing.Color.Black;
            this.textPrecSelBran.Location = new System.Drawing.Point(117, 153);
            this.textPrecSelBran.Name = "textPrecSelBran";
            this.textPrecSelBran.Size = new System.Drawing.Size(53, 20);
            this.textPrecSelBran.TabIndex = 49;
            this.textPrecSelBran.Text = "quant.";
            this.textPrecSelBran.Visible = false;
            // 
            // textPrecSelVerm
            // 
            this.textPrecSelVerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrecSelVerm.AutoSize = true;
            this.textPrecSelVerm.BackColor = System.Drawing.Color.Transparent;
            this.textPrecSelVerm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textPrecSelVerm.ForeColor = System.Drawing.Color.Black;
            this.textPrecSelVerm.Location = new System.Drawing.Point(119, 63);
            this.textPrecSelVerm.Name = "textPrecSelVerm";
            this.textPrecSelVerm.Size = new System.Drawing.Size(53, 20);
            this.textPrecSelVerm.TabIndex = 50;
            this.textPrecSelVerm.Text = "quant.";
            this.textPrecSelVerm.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(40, 642);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNomeSelVerm);
            this.groupBox1.Controls.Add(this.textPrecSelVerm);
            this.groupBox1.Controls.Add(this.textNomeSelBran);
            this.groupBox1.Controls.Add(this.textPrecSelBran);
            this.groupBox1.Controls.Add(this.textNomeSelAmar);
            this.groupBox1.Controls.Add(this.textPrecSelAmar);
            this.groupBox1.Controls.Add(this.textQuanSeLVerm);
            this.groupBox1.Controls.Add(this.textQuanSeLAmar);
            this.groupBox1.Controls.Add(this.textQuanSeLBran);
            this.groupBox1.Location = new System.Drawing.Point(725, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 309);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textNomeSelVerm
            // 
            this.textNomeSelVerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNomeSelVerm.AutoSize = true;
            this.textNomeSelVerm.BackColor = System.Drawing.Color.Transparent;
            this.textNomeSelVerm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textNomeSelVerm.ForeColor = System.Drawing.Color.Black;
            this.textNomeSelVerm.Location = new System.Drawing.Point(43, 39);
            this.textNomeSelVerm.Name = "textNomeSelVerm";
            this.textNomeSelVerm.Size = new System.Drawing.Size(120, 20);
            this.textNomeSelVerm.TabIndex = 42;
            this.textNomeSelVerm.Text = "Pitaya Vermelha";
            this.textNomeSelVerm.Visible = false;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textForPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textValorTotal;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label textNomeSelBran;
        private System.Windows.Forms.Label textNomeSelAmar;
        private System.Windows.Forms.Label textQuanSeLVerm;
        private System.Windows.Forms.Label textQuanSeLBran;
        private System.Windows.Forms.Label textQuanSeLAmar;
        private System.Windows.Forms.Label textPrecSelAmar;
        private System.Windows.Forms.Label textPrecSelBran;
        private System.Windows.Forms.Label textPrecSelVerm;
        private System.Windows.Forms.LinkLabel textResumo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textNomeSelVerm;
    }
}