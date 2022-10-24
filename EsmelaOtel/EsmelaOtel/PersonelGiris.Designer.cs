namespace EsmelaOtel
{
    partial class PersonelGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPersonelTC = new System.Windows.Forms.Label();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblPersonelSifre = new System.Windows.Forms.Label();
            this.textBoxPersonelSifre = new System.Windows.Forms.TextBox();
            this.buttonPersonelGiris = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.BackColor = System.Drawing.Color.White;
            this.labelBaslik.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaslik.Location = new System.Drawing.Point(214, 82);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(291, 43);
            this.labelBaslik.TabIndex = 27;
            this.labelBaslik.Text = "Personel Girişi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(106, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // lblPersonelTC
            // 
            this.lblPersonelTC.AutoSize = true;
            this.lblPersonelTC.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelTC.Location = new System.Drawing.Point(145, 210);
            this.lblPersonelTC.Name = "lblPersonelTC";
            this.lblPersonelTC.Size = new System.Drawing.Size(60, 27);
            this.lblPersonelTC.TabIndex = 29;
            this.lblPersonelTC.Text = "T.C:";
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTC.Location = new System.Drawing.Point(256, 210);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(249, 30);
            this.maskedTextBoxTC.TabIndex = 30;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // lblPersonelSifre
            // 
            this.lblPersonelSifre.AutoSize = true;
            this.lblPersonelSifre.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSifre.Location = new System.Drawing.Point(128, 312);
            this.lblPersonelSifre.Name = "lblPersonelSifre";
            this.lblPersonelSifre.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSifre.TabIndex = 31;
            this.lblPersonelSifre.Text = "Şifre:";
            // 
            // textBoxPersonelSifre
            // 
            this.textBoxPersonelSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPersonelSifre.Location = new System.Drawing.Point(256, 311);
            this.textBoxPersonelSifre.Name = "textBoxPersonelSifre";
            this.textBoxPersonelSifre.Size = new System.Drawing.Size(249, 30);
            this.textBoxPersonelSifre.TabIndex = 32;
            // 
            // buttonPersonelGiris
            // 
            this.buttonPersonelGiris.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelGiris.Location = new System.Drawing.Point(386, 393);
            this.buttonPersonelGiris.Name = "buttonPersonelGiris";
            this.buttonPersonelGiris.Size = new System.Drawing.Size(119, 44);
            this.buttonPersonelGiris.TabIndex = 33;
            this.buttonPersonelGiris.Text = "Giriş";
            this.buttonPersonelGiris.UseVisualStyleBackColor = true;
            this.buttonPersonelGiris.Click += new System.EventHandler(this.buttonPersonelGiris_Click);
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 514);
            this.Controls.Add(this.buttonPersonelGiris);
            this.Controls.Add(this.textBoxPersonelSifre);
            this.Controls.Add(this.lblPersonelSifre);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.lblPersonelTC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş Ekranı";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPersonelTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.Label lblPersonelSifre;
        private System.Windows.Forms.TextBox textBoxPersonelSifre;
        private System.Windows.Forms.Button buttonPersonelGiris;
    }
}