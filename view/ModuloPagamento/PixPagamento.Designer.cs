namespace ProjetoFazendaUrbana.view
{
    partial class textConfirmaPag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textConfirmaPag));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textValorTotal = new System.Windows.Forms.Label();
            this.textChavePix = new System.Windows.Forms.Label();
            this.CopiarChave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(508, 211);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(209, 179);
            this.pictureBoxQRCode.TabIndex = 27;
            this.pictureBoxQRCode.TabStop = false;
            this.pictureBoxQRCode.Click += new System.EventHandler(this.pictureBoxQRCode_Click);
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
            this.label2.Location = new System.Drawing.Point(244, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Use seu aplicativo bancário para escanear o QR Code abaixo e completar a transaçã" +
    "o.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(439, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(355, 54);
            this.label25.TabIndex = 26;
            this.label25.Text = "Pagamento via pix";
            // 
            // textValorTotal
            // 
            this.textValorTotal.AutoSize = true;
            this.textValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.textValorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textValorTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textValorTotal.Location = new System.Drawing.Point(503, 393);
            this.textValorTotal.Name = "textValorTotal";
            this.textValorTotal.Size = new System.Drawing.Size(163, 25);
            this.textValorTotal.TabIndex = 29;
            this.textValorTotal.Text = "Valor a Pagar: R$ ";
            // 
            // textChavePix
            // 
            this.textChavePix.AutoSize = true;
            this.textChavePix.BackColor = System.Drawing.Color.Transparent;
            this.textChavePix.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textChavePix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textChavePix.Location = new System.Drawing.Point(473, 435);
            this.textChavePix.Name = "textChavePix";
            this.textChavePix.Size = new System.Drawing.Size(275, 25);
            this.textChavePix.TabIndex = 30;
            this.textChavePix.Text = "Chave pix: pitayas@gmail.com";
            // 
            // CopiarChave
            // 
            this.CopiarChave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CopiarChave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopiarChave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiarChave.ForeColor = System.Drawing.Color.White;
            this.CopiarChave.Location = new System.Drawing.Point(549, 463);
            this.CopiarChave.Name = "CopiarChave";
            this.CopiarChave.Size = new System.Drawing.Size(126, 32);
            this.CopiarChave.TabIndex = 31;
            this.CopiarChave.Text = "Copiar chave pix";
            this.CopiarChave.UseVisualStyleBackColor = false;
            this.CopiarChave.Click += new System.EventHandler(this.CopiarChave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 11F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(566, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 47);
            this.button2.TabIndex = 39;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(507, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 49);
            this.button1.TabIndex = 40;
            this.button1.Text = "Confirmar Pagamento";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textConfirmaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CopiarChave);
            this.Controls.Add(this.textChavePix);
            this.Controls.Add(this.textValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "textConfirmaPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pix";
            this.Load += new System.EventHandler(this.Pix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label textValorTotal;
        private System.Windows.Forms.Label textChavePix;
        private System.Windows.Forms.Button CopiarChave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}