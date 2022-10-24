namespace EsmelaOtel
{
    partial class MusteriGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxMusteriSoyad = new System.Windows.Forms.TextBox();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.S = new System.Windows.Forms.Label();
            this.buttonMusteriGiris = new System.Windows.Forms.Button();
            this.textBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaslik.Location = new System.Drawing.Point(219, 57);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(285, 43);
            this.labelBaslik.TabIndex = 26;
            this.labelBaslik.Text = "Müşteri Girişi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxMusteriSoyad
            // 
            this.textBoxMusteriSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMusteriSoyad.Location = new System.Drawing.Point(255, 330);
            this.textBoxMusteriSoyad.Name = "textBoxMusteriSoyad";
            this.textBoxMusteriSoyad.Size = new System.Drawing.Size(249, 30);
            this.textBoxMusteriSoyad.TabIndex = 52;
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.Location = new System.Drawing.Point(81, 330);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(139, 27);
            this.lblMusteriSoyad.TabIndex = 51;
            this.lblMusteriSoyad.Text = "Soyadınız:";
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTC.Location = new System.Drawing.Point(255, 168);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(249, 30);
            this.maskedTextBoxTC.TabIndex = 50;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.S.Location = new System.Drawing.Point(300, 414);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(60, 20);
            this.S.TabIndex = 49;
            this.S.Text = "Üye Ol";
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // buttonMusteriGiris
            // 
            this.buttonMusteriGiris.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMusteriGiris.Location = new System.Drawing.Point(385, 400);
            this.buttonMusteriGiris.Name = "buttonMusteriGiris";
            this.buttonMusteriGiris.Size = new System.Drawing.Size(119, 44);
            this.buttonMusteriGiris.TabIndex = 48;
            this.buttonMusteriGiris.Text = "Giriş";
            this.buttonMusteriGiris.UseVisualStyleBackColor = true;
            this.buttonMusteriGiris.Click += new System.EventHandler(this.buttonMusteriGiris_Click_1);
            // 
            // textBoxMusteriAd
            // 
            this.textBoxMusteriAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMusteriAd.Location = new System.Drawing.Point(255, 247);
            this.textBoxMusteriAd.Name = "textBoxMusteriAd";
            this.textBoxMusteriAd.Size = new System.Drawing.Size(249, 30);
            this.textBoxMusteriAd.TabIndex = 47;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.Location = new System.Drawing.Point(124, 248);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(96, 27);
            this.lblMusteriAd.TabIndex = 46;
            this.lblMusteriAd.Text = "Adınız:";
            // 
            // lblMusteriTC
            // 
            this.lblMusteriTC.AutoSize = true;
            this.lblMusteriTC.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriTC.Location = new System.Drawing.Point(160, 171);
            this.lblMusteriTC.Name = "lblMusteriTC";
            this.lblMusteriTC.Size = new System.Drawing.Size(60, 27);
            this.lblMusteriTC.TabIndex = 45;
            this.lblMusteriTC.Text = "T.C:";
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 514);
            this.Controls.Add(this.textBoxMusteriSoyad);
            this.Controls.Add(this.lblMusteriSoyad);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.S);
            this.Controls.Add(this.buttonMusteriGiris);
            this.Controls.Add(this.textBoxMusteriAd);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.lblMusteriTC);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusteriGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Giriş Ekranı";
            this.Load += new System.EventHandler(this.MusteriGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button buttonMusteriGiris;
        private System.Windows.Forms.TextBox textBoxMusteriAd;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriTC;
    }
}