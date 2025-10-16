namespace HraRaketa
{
    partial class Okno
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_hraciPlocha = new System.Windows.Forms.GroupBox();
            this.pictureBox_stop = new System.Windows.Forms.PictureBox();
            this.pictureBox_trojuhelnik = new System.Windows.Forms.PictureBox();
            this.pictureBox_pc = new System.Windows.Forms.PictureBox();
            this.txt_skore = new System.Windows.Forms.Label();
            this.txt_zivoty = new System.Windows.Forms.Label();
            this.txt_palivo = new System.Windows.Forms.Label();
            this.textBox_skore = new System.Windows.Forms.ProgressBar();
            this.textBox_palivo = new System.Windows.Forms.ProgressBar();
            this.pictureBox_srdce1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_srdce2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_srdce3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox_hraciPlocha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trojuhelnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(318, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = " Virus X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_hraciPlocha
            // 
            this.groupBox_hraciPlocha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_hraciPlocha.Controls.Add(this.pictureBox_stop);
            this.groupBox_hraciPlocha.Controls.Add(this.pictureBox_trojuhelnik);
            this.groupBox_hraciPlocha.Controls.Add(this.pictureBox_pc);
            this.groupBox_hraciPlocha.Location = new System.Drawing.Point(19, 69);
            this.groupBox_hraciPlocha.Name = "groupBox_hraciPlocha";
            this.groupBox_hraciPlocha.Size = new System.Drawing.Size(743, 412);
            this.groupBox_hraciPlocha.TabIndex = 5;
            this.groupBox_hraciPlocha.TabStop = false;
            this.groupBox_hraciPlocha.Text = "HraciPole";
            this.groupBox_hraciPlocha.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox_stop
            // 
            this.pictureBox_stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_stop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_stop.Image")));
            this.pictureBox_stop.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_stop.InitialImage")));
            this.pictureBox_stop.Location = new System.Drawing.Point(411, 236);
            this.pictureBox_stop.Name = "pictureBox_stop";
            this.pictureBox_stop.Size = new System.Drawing.Size(70, 60);
            this.pictureBox_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_stop.TabIndex = 2;
            this.pictureBox_stop.TabStop = false;
            // 
            // pictureBox_trojuhelnik
            // 
            this.pictureBox_trojuhelnik.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_trojuhelnik.Image")));
            this.pictureBox_trojuhelnik.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_trojuhelnik.InitialImage")));
            this.pictureBox_trojuhelnik.Location = new System.Drawing.Point(179, 51);
            this.pictureBox_trojuhelnik.Name = "pictureBox_trojuhelnik";
            this.pictureBox_trojuhelnik.Size = new System.Drawing.Size(65, 50);
            this.pictureBox_trojuhelnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_trojuhelnik.TabIndex = 1;
            this.pictureBox_trojuhelnik.TabStop = false;
            // 
            // pictureBox_pc
            // 
            this.pictureBox_pc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_pc.Image")));
            this.pictureBox_pc.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_pc.InitialImage")));
            this.pictureBox_pc.Location = new System.Drawing.Point(331, 321);
            this.pictureBox_pc.Name = "pictureBox_pc";
            this.pictureBox_pc.Size = new System.Drawing.Size(96, 85);
            this.pictureBox_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pc.TabIndex = 0;
            this.pictureBox_pc.TabStop = false;
            this.pictureBox_pc.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txt_skore
            // 
            this.txt_skore.AutoSize = true;
            this.txt_skore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_skore.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_skore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_skore.Location = new System.Drawing.Point(35, 519);
            this.txt_skore.Name = "txt_skore";
            this.txt_skore.Size = new System.Drawing.Size(54, 18);
            this.txt_skore.TabIndex = 6;
            this.txt_skore.Text = "Skore";
            this.txt_skore.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_zivoty
            // 
            this.txt_zivoty.AutoSize = true;
            this.txt_zivoty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_zivoty.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_zivoty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_zivoty.Location = new System.Drawing.Point(286, 520);
            this.txt_zivoty.Name = "txt_zivoty";
            this.txt_zivoty.Size = new System.Drawing.Size(58, 18);
            this.txt_zivoty.TabIndex = 7;
            this.txt_zivoty.Text = "Životy";
            this.txt_zivoty.Click += new System.EventHandler(this.txt_zivoty_Click);
            // 
            // txt_palivo
            // 
            this.txt_palivo.AutoSize = true;
            this.txt_palivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_palivo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_palivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_palivo.Location = new System.Drawing.Point(625, 520);
            this.txt_palivo.Name = "txt_palivo";
            this.txt_palivo.Size = new System.Drawing.Size(71, 18);
            this.txt_palivo.TabIndex = 8;
            this.txt_palivo.Text = "Energie";
            this.txt_palivo.Click += new System.EventHandler(this.txt_palivo_Click);
            // 
            // textBox_skore
            // 
            this.textBox_skore.Location = new System.Drawing.Point(95, 519);
            this.textBox_skore.Name = "textBox_skore";
            this.textBox_skore.Size = new System.Drawing.Size(67, 21);
            this.textBox_skore.TabIndex = 9;
            // 
            // textBox_palivo
            // 
            this.textBox_palivo.Location = new System.Drawing.Point(702, 519);
            this.textBox_palivo.Name = "textBox_palivo";
            this.textBox_palivo.Size = new System.Drawing.Size(60, 21);
            this.textBox_palivo.TabIndex = 10;
            // 
            // pictureBox_srdce1
            // 
            this.pictureBox_srdce1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce1.Image")));
            this.pictureBox_srdce1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce1.InitialImage")));
            this.pictureBox_srdce1.Location = new System.Drawing.Point(350, 508);
            this.pictureBox_srdce1.Name = "pictureBox_srdce1";
            this.pictureBox_srdce1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox_srdce1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_srdce1.TabIndex = 0;
            this.pictureBox_srdce1.TabStop = false;
            // 
            // pictureBox_srdce2
            // 
            this.pictureBox_srdce2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce2.Image")));
            this.pictureBox_srdce2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce2.InitialImage")));
            this.pictureBox_srdce2.Location = new System.Drawing.Point(402, 508);
            this.pictureBox_srdce2.Name = "pictureBox_srdce2";
            this.pictureBox_srdce2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox_srdce2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_srdce2.TabIndex = 11;
            this.pictureBox_srdce2.TabStop = false;
            // 
            // pictureBox_srdce3
            // 
            this.pictureBox_srdce3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce3.Image")));
            this.pictureBox_srdce3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce3.InitialImage")));
            this.pictureBox_srdce3.Location = new System.Drawing.Point(454, 508);
            this.pictureBox_srdce3.Name = "pictureBox_srdce3";
            this.pictureBox_srdce3.Size = new System.Drawing.Size(46, 41);
            this.pictureBox_srdce3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_srdce3.TabIndex = 12;
            this.pictureBox_srdce3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(489, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(249, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(63, 51);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox_srdce3);
            this.Controls.Add(this.pictureBox_srdce2);
            this.Controls.Add(this.pictureBox_srdce1);
            this.Controls.Add(this.textBox_palivo);
            this.Controls.Add(this.textBox_skore);
            this.Controls.Add(this.txt_palivo);
            this.Controls.Add(this.txt_zivoty);
            this.Controls.Add(this.txt_skore);
            this.Controls.Add(this.groupBox_hraciPlocha);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Okno";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_hraciPlocha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trojuhelnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_hraciPlocha;
        private System.Windows.Forms.Label txt_skore;
        private System.Windows.Forms.Label txt_zivoty;
        private System.Windows.Forms.Label txt_palivo;
        private System.Windows.Forms.ProgressBar textBox_skore;
        private System.Windows.Forms.ProgressBar textBox_palivo;
        private System.Windows.Forms.PictureBox pictureBox_srdce1;
        private System.Windows.Forms.PictureBox pictureBox_pc;
        private System.Windows.Forms.PictureBox pictureBox_srdce2;
        private System.Windows.Forms.PictureBox pictureBox_srdce3;
        private System.Windows.Forms.PictureBox pictureBox_stop;
        private System.Windows.Forms.PictureBox pictureBox_trojuhelnik;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

