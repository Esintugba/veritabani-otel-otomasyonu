namespace EsmelaOtel
{
    partial class PersonelEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGiderBilgileri = new System.Windows.Forms.Button();
            this.buttonOdemeBilgileri = new System.Windows.Forms.Button();
            this.buttonOtelDüzenle = new System.Windows.Forms.Button();
            this.buttonMüsteriDüzenle = new System.Windows.Forms.Button();
            this.buttonPersonelDüzenle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriUyrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriKanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBOtelOtomasyonDataSet3 = new EsmelaOtel.DBOtelOtomasyonDataSet3();
            this.müsteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBOtelOtomasyonDataSetMsteri = new EsmelaOtel.DBOtelOtomasyonDataSetMsteri();
            this.müsteriTableAdapter = new EsmelaOtel.DBOtelOtomasyonDataSetMsteriTableAdapters.MüsteriTableAdapter();
            this.müsteriTableAdapter1 = new EsmelaOtel.DBOtelOtomasyonDataSet3TableAdapters.MüsteriTableAdapter();
            this.buttonOdaDüzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBOtelOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBOtelOtomasyonDataSetMsteri)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1055);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(352, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 124);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(76, 27);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(164, 24);
            this.lblTC.TabIndex = 6;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "T.C:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(164, 65);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(105, 24);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(20, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(138, 24);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Hoşgeldiniz ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.buttonGiderBilgileri);
            this.groupBox2.Controls.Add(this.buttonOdemeBilgileri);
            this.groupBox2.Controls.Add(this.buttonOtelDüzenle);
            this.groupBox2.Controls.Add(this.buttonOdaDüzenle);
            this.groupBox2.Controls.Add(this.buttonMüsteriDüzenle);
            this.groupBox2.Controls.Add(this.buttonPersonelDüzenle);
            this.groupBox2.Location = new System.Drawing.Point(144, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 704);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // buttonGiderBilgileri
            // 
            this.buttonGiderBilgileri.BackColor = System.Drawing.Color.White;
            this.buttonGiderBilgileri.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiderBilgileri.Location = new System.Drawing.Point(24, 638);
            this.buttonGiderBilgileri.Name = "buttonGiderBilgileri";
            this.buttonGiderBilgileri.Size = new System.Drawing.Size(217, 43);
            this.buttonGiderBilgileri.TabIndex = 25;
            this.buttonGiderBilgileri.Text = "Gider Bilgileri";
            this.buttonGiderBilgileri.UseVisualStyleBackColor = false;
            this.buttonGiderBilgileri.Click += new System.EventHandler(this.buttonGiderBilgileri_Click);
            // 
            // buttonOdemeBilgileri
            // 
            this.buttonOdemeBilgileri.BackColor = System.Drawing.Color.White;
            this.buttonOdemeBilgileri.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOdemeBilgileri.Location = new System.Drawing.Point(24, 524);
            this.buttonOdemeBilgileri.Name = "buttonOdemeBilgileri";
            this.buttonOdemeBilgileri.Size = new System.Drawing.Size(217, 43);
            this.buttonOdemeBilgileri.TabIndex = 24;
            this.buttonOdemeBilgileri.Text = "Ödeme Bilgileri";
            this.buttonOdemeBilgileri.UseVisualStyleBackColor = false;
            this.buttonOdemeBilgileri.Click += new System.EventHandler(this.buttonOdemeBilgileri_Click);
            // 
            // buttonOtelDüzenle
            // 
            this.buttonOtelDüzenle.BackColor = System.Drawing.Color.White;
            this.buttonOtelDüzenle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOtelDüzenle.Location = new System.Drawing.Point(24, 376);
            this.buttonOtelDüzenle.Name = "buttonOtelDüzenle";
            this.buttonOtelDüzenle.Size = new System.Drawing.Size(217, 80);
            this.buttonOtelDüzenle.TabIndex = 23;
            this.buttonOtelDüzenle.Text = "Otel Bilgileri\r\n    Düzenle";
            this.buttonOtelDüzenle.UseVisualStyleBackColor = false;
            this.buttonOtelDüzenle.Click += new System.EventHandler(this.buttonOtelDüzenle_Click);
            // 
            // buttonMüsteriDüzenle
            // 
            this.buttonMüsteriDüzenle.BackColor = System.Drawing.Color.White;
            this.buttonMüsteriDüzenle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMüsteriDüzenle.Location = new System.Drawing.Point(24, 155);
            this.buttonMüsteriDüzenle.Name = "buttonMüsteriDüzenle";
            this.buttonMüsteriDüzenle.Size = new System.Drawing.Size(217, 39);
            this.buttonMüsteriDüzenle.TabIndex = 21;
            this.buttonMüsteriDüzenle.Text = "Müşteri Düzenle";
            this.buttonMüsteriDüzenle.UseVisualStyleBackColor = false;
            this.buttonMüsteriDüzenle.Click += new System.EventHandler(this.buttonMüsteriDüzenle_Click);
            // 
            // buttonPersonelDüzenle
            // 
            this.buttonPersonelDüzenle.BackColor = System.Drawing.Color.White;
            this.buttonPersonelDüzenle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelDüzenle.Location = new System.Drawing.Point(24, 33);
            this.buttonPersonelDüzenle.Name = "buttonPersonelDüzenle";
            this.buttonPersonelDüzenle.Size = new System.Drawing.Size(217, 64);
            this.buttonPersonelDüzenle.TabIndex = 20;
            this.buttonPersonelDüzenle.Text = "Bilgilerimi Düzenle";
            this.buttonPersonelDüzenle.UseVisualStyleBackColor = false;
            this.buttonPersonelDüzenle.Click += new System.EventHandler(this.buttonPersonelDüzenle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.musteriTCDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.musteriMailDataGridViewTextBoxColumn,
            this.musteriTelefonDataGridViewTextBoxColumn,
            this.musteriUyrukDataGridViewTextBoxColumn,
            this.musteriAdresDataGridViewTextBoxColumn,
            this.musteriKanGrubuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.müsteriBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(632, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 738);
            this.dataGridView1.TabIndex = 24;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTCDataGridViewTextBoxColumn
            // 
            this.musteriTCDataGridViewTextBoxColumn.DataPropertyName = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.HeaderText = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTCDataGridViewTextBoxColumn.Name = "musteriTCDataGridViewTextBoxColumn";
            this.musteriTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            this.musteriAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            this.musteriSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriMailDataGridViewTextBoxColumn
            // 
            this.musteriMailDataGridViewTextBoxColumn.DataPropertyName = "MusteriMail";
            this.musteriMailDataGridViewTextBoxColumn.HeaderText = "MusteriMail";
            this.musteriMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriMailDataGridViewTextBoxColumn.Name = "musteriMailDataGridViewTextBoxColumn";
            this.musteriMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTelefonDataGridViewTextBoxColumn
            // 
            this.musteriTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.HeaderText = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTelefonDataGridViewTextBoxColumn.Name = "musteriTelefonDataGridViewTextBoxColumn";
            this.musteriTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriUyrukDataGridViewTextBoxColumn
            // 
            this.musteriUyrukDataGridViewTextBoxColumn.DataPropertyName = "MusteriUyruk";
            this.musteriUyrukDataGridViewTextBoxColumn.HeaderText = "MusteriUyruk";
            this.musteriUyrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriUyrukDataGridViewTextBoxColumn.Name = "musteriUyrukDataGridViewTextBoxColumn";
            this.musteriUyrukDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAdresDataGridViewTextBoxColumn
            // 
            this.musteriAdresDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.HeaderText = "MusteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdresDataGridViewTextBoxColumn.Name = "musteriAdresDataGridViewTextBoxColumn";
            this.musteriAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriKanGrubuDataGridViewTextBoxColumn
            // 
            this.musteriKanGrubuDataGridViewTextBoxColumn.DataPropertyName = "MusteriKanGrubu";
            this.musteriKanGrubuDataGridViewTextBoxColumn.HeaderText = "MusteriKanGrubu";
            this.musteriKanGrubuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriKanGrubuDataGridViewTextBoxColumn.Name = "musteriKanGrubuDataGridViewTextBoxColumn";
            this.musteriKanGrubuDataGridViewTextBoxColumn.Width = 125;
            // 
            // müsteriBindingSource1
            // 
            this.müsteriBindingSource1.DataMember = "Müsteri";
            this.müsteriBindingSource1.DataSource = this.dBOtelOtomasyonDataSet3;
            // 
            // dBOtelOtomasyonDataSet3
            // 
            this.dBOtelOtomasyonDataSet3.DataSetName = "DBOtelOtomasyonDataSet3";
            this.dBOtelOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsteriBindingSource
            // 
            this.müsteriBindingSource.DataMember = "Müsteri";
            this.müsteriBindingSource.DataSource = this.dBOtelOtomasyonDataSetMsteri;
            // 
            // dBOtelOtomasyonDataSetMsteri
            // 
            this.dBOtelOtomasyonDataSetMsteri.DataSetName = "DBOtelOtomasyonDataSetMsteri";
            this.dBOtelOtomasyonDataSetMsteri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsteriTableAdapter
            // 
            this.müsteriTableAdapter.ClearBeforeFill = true;
            // 
            // müsteriTableAdapter1
            // 
            this.müsteriTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonOdaDüzenle
            // 
            this.buttonOdaDüzenle.BackColor = System.Drawing.Color.White;
            this.buttonOdaDüzenle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOdaDüzenle.Location = new System.Drawing.Point(24, 255);
            this.buttonOdaDüzenle.Name = "buttonOdaDüzenle";
            this.buttonOdaDüzenle.Size = new System.Drawing.Size(217, 69);
            this.buttonOdaDüzenle.TabIndex = 22;
            this.buttonOdaDüzenle.Text = "Oda Bilgileri \r\n   Düzenle";
            this.buttonOdaDüzenle.UseVisualStyleBackColor = false;
            this.buttonOdaDüzenle.Click += new System.EventHandler(this.buttonOdaDüzenle_Click);
            // 
            // PersonelEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonelEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBOtelOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBOtelOtomasyonDataSetMsteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGiderBilgileri;
        private System.Windows.Forms.Button buttonOdemeBilgileri;
        private System.Windows.Forms.Button buttonOtelDüzenle;
        private System.Windows.Forms.Button buttonMüsteriDüzenle;
        private System.Windows.Forms.Button buttonPersonelDüzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBOtelOtomasyonDataSetMsteri dBOtelOtomasyonDataSetMsteri;
        private System.Windows.Forms.BindingSource müsteriBindingSource;
        private DBOtelOtomasyonDataSetMsteriTableAdapters.MüsteriTableAdapter müsteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriUyrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriKanGrubuDataGridViewTextBoxColumn;
        private DBOtelOtomasyonDataSet3 dBOtelOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource müsteriBindingSource1;
        private DBOtelOtomasyonDataSet3TableAdapters.MüsteriTableAdapter müsteriTableAdapter1;
        private System.Windows.Forms.Button buttonOdaDüzenle;
    }
}