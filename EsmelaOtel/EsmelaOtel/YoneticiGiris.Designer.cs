namespace EsmelaOtel
{
    partial class YoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.buttonYoneticiGiris = new System.Windows.Forms.Button();
            this.textBoxYoneticiSifre = new System.Windows.Forms.TextBox();
            this.lblYoneticiSifre = new System.Windows.Forms.Label();
            this.lblYoneticiTC = new System.Windows.Forms.Label();
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
            this.labelBaslik.Location = new System.Drawing.Point(202, 44);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(287, 43);
            this.labelBaslik.TabIndex = 18;
            this.labelBaslik.Text = "Yönetici Girişi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTC.Location = new System.Drawing.Point(240, 189);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(249, 30);
            this.maskedTextBoxTC.TabIndex = 27;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // buttonYoneticiGiris
            // 
            this.buttonYoneticiGiris.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYoneticiGiris.Location = new System.Drawing.Point(370, 360);
            this.buttonYoneticiGiris.Name = "buttonYoneticiGiris";
            this.buttonYoneticiGiris.Size = new System.Drawing.Size(119, 44);
            this.buttonYoneticiGiris.TabIndex = 26;
            this.buttonYoneticiGiris.Text = "Giriş";
            this.buttonYoneticiGiris.UseVisualStyleBackColor = true;
            this.buttonYoneticiGiris.Click += new System.EventHandler(this.buttonYoneticiGiris_Click);
            // 
            // textBoxYoneticiSifre
            // 
            this.textBoxYoneticiSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiSifre.Location = new System.Drawing.Point(240, 268);
            this.textBoxYoneticiSifre.Name = "textBoxYoneticiSifre";
            this.textBoxYoneticiSifre.Size = new System.Drawing.Size(249, 30);
            this.textBoxYoneticiSifre.TabIndex = 25;
            // 
            // lblYoneticiSifre
            // 
            this.lblYoneticiSifre.AutoSize = true;
            this.lblYoneticiSifre.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiSifre.Location = new System.Drawing.Point(126, 271);
            this.lblYoneticiSifre.Name = "lblYoneticiSifre";
            this.lblYoneticiSifre.Size = new System.Drawing.Size(77, 27);
            this.lblYoneticiSifre.TabIndex = 24;
            this.lblYoneticiSifre.Text = "Şifre:";
            // 
            // lblYoneticiTC
            // 
            this.lblYoneticiTC.AutoSize = true;
            this.lblYoneticiTC.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiTC.Location = new System.Drawing.Point(143, 189);
            this.lblYoneticiTC.Name = "lblYoneticiTC";
            this.lblYoneticiTC.Size = new System.Drawing.Size(60, 27);
            this.lblYoneticiTC.TabIndex = 23;
            this.lblYoneticiTC.Text = "T.C:";
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 514);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.buttonYoneticiGiris);
            this.Controls.Add(this.textBoxYoneticiSifre);
            this.Controls.Add(this.lblYoneticiSifre);
            this.Controls.Add(this.lblYoneticiTC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            this.Load += new System.EventHandler(this.YöneticiGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.Button buttonYoneticiGiris;
        private System.Windows.Forms.TextBox textBoxYoneticiSifre;
        private System.Windows.Forms.Label lblYoneticiSifre;
        private System.Windows.Forms.Label lblYoneticiTC;
    }
}