namespace ProjetoFazendaUrbana.view
{
    partial class CartaoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartaoPagamento));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNome = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textCVV = new System.Windows.Forms.MaskedTextBox();
            this.textNumero = new System.Windows.Forms.MaskedTextBox();
            this.TextData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(403, 169);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(453, 65);
            this.label25.TabIndex = 27;
            this.label25.Text = "CARTÃO DÉBITO/CRÉDITO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.textNome);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textCVV);
            this.panel1.Controls.Add(this.textNumero);
            this.panel1.Controls.Add(this.TextData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(349, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 268);
            this.panel1.TabIndex = 28;
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(29, 72);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(211, 23);
            this.textNome.TabIndex = 39;
            this.textNome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textNome_MaskInputRejected);
            this.textNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLetras_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.button2.Location = new System.Drawing.Point(127, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.button1.Location = new System.Drawing.Point(348, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 37;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCVV
            // 
            this.textCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCVV.Location = new System.Drawing.Point(290, 160);
            this.textCVV.Mask = "000";
            this.textCVV.Name = "textCVV";
            this.textCVV.Size = new System.Drawing.Size(211, 23);
            this.textCVV.TabIndex = 36;
            this.textCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInteger_KeyPress);
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(29, 160);
            this.textNumero.Mask = "0000 0000 0000 0000";
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(211, 23);
            this.textNumero.TabIndex = 35;
            this.textNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInteger_KeyPress);
            // 
            // TextData
            // 
            this.TextData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextData.Location = new System.Drawing.Point(290, 72);
            this.TextData.Mask = "00/00";
            this.TextData.Name = "TextData";
            this.TextData.Size = new System.Drawing.Size(211, 23);
            this.TextData.TabIndex = 33;
            this.TextData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextData_MaskInputRejected);
            this.TextData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInteger_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(286, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "CÓDIGO DE SERGURANÇA (CVV)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(286, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "DATA DE VALIDADE";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "NOME DO TITULAR";
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
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "NÚMERO DO CARTÃO";
            // 
            // CartaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartaoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartaoPagamento";
            this.Load += new System.EventHandler(this.CartaoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TextData;
        private System.Windows.Forms.MaskedTextBox textCVV;
        private System.Windows.Forms.MaskedTextBox textNumero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox textNome;
    }
}