namespace ProjetoFazendaUrbana.view
{
    partial class FuncionarioEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioEditar));
            this.textInicio = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textFuncaoNova = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textFechar = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.textInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInicio.ForeColor = System.Drawing.Color.White;
            this.textInicio.Location = new System.Drawing.Point(101, 44);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(50, 21);
            this.textInicio.TabIndex = 51;
            this.textInicio.Text = "Inicio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel7.Controls.Add(this.button8);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.textFuncaoNova);
            this.panel7.Controls.Add(this.textID);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.textFechar);
            this.panel7.Location = new System.Drawing.Point(345, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 403);
            this.panel7.TabIndex = 56;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Arial Black", 12F);
            this.button8.Location = new System.Drawing.Point(189, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 38);
            this.button8.TabIndex = 29;
            this.button8.Text = "ALTERAR ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label28.Location = new System.Drawing.Point(235, 200);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 19);
            this.label28.TabIndex = 28;
            this.label28.Text = "Nova função";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label27.Location = new System.Drawing.Point(266, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 23);
            this.label27.TabIndex = 25;
            this.label27.Text = "ID";
            // 
            // textFuncaoNova
            // 
            this.textFuncaoNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFuncaoNova.Location = new System.Drawing.Point(189, 222);
            this.textFuncaoNova.Name = "textFuncaoNova";
            this.textFuncaoNova.Size = new System.Drawing.Size(189, 23);
            this.textFuncaoNova.TabIndex = 27;
            this.textFuncaoNova.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNovaFuncaoKeyPress);
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(189, 141);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(189, 23);
            this.textID.TabIndex = 26;
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Black", 14F);
            this.label26.Location = new System.Drawing.Point(96, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(404, 27);
            this.label26.TabIndex = 25;
            this.label26.Text = "ALTERAR FUNÇÃO DO FUNCIONARIO";
            // 
            // textFechar
            // 
            this.textFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFechar.AutoSize = true;
            this.textFechar.BackColor = System.Drawing.Color.Transparent;
            this.textFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.textFechar.ForeColor = System.Drawing.Color.Black;
            this.textFechar.Location = new System.Drawing.Point(526, 0);
            this.textFechar.Name = "textFechar";
            this.textFechar.Size = new System.Drawing.Size(37, 41);
            this.textFechar.TabIndex = 13;
            this.textFechar.Text = "X";
            this.textFechar.Click += new System.EventHandler(this.textFechar_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1200, 700);
            this.panel8.TabIndex = 56;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // AlterarFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.textInicio);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarFuncao";
            this.Load += new System.EventHandler(this.AlterarFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textFuncaoNova;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label textFechar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}