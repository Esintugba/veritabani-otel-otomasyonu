namespace EsmelaOtel
{
    partial class ÖdemeKredi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖdemeKredi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCVC = new System.Windows.Forms.MaskedTextBox();
            this.lblGuvenlikKodu = new System.Windows.Forms.Label();
            this.maskedTextBoxSonKullanma = new System.Windows.Forms.MaskedTextBox();
            this.lblSonKullanmaTarihi = new System.Windows.Forms.Label();
            this.textBoxKartİsim = new System.Windows.Forms.TextBox();
            this.lblKartİsim = new System.Windows.Forms.Label();
            this.maskedTextBoxKartNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.lblKartNumarasi = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.textBoxMusteriID = new System.Windows.Forms.TextBox();
            this.textBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.textBoxMusteriSoyad = new System.Windows.Forms.TextBox();
            this.lblOdenenTutar = new System.Windows.Forms.Label();
            this.lblOdenenTarih = new System.Windows.Forms.Label();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            this.textBoxOdenenTutar = new System.Windows.Forms.TextBox();
            this.dateTimePickerOdenenTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxKalanBorc = new System.Windows.Forms.TextBox();
            this.buttonOdemeYap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRezervasyonID = new System.Windows.Forms.TextBox();
            this.lblRezervasyonID = new System.Windows.Forms.Label();
            this.maskedTextBoxMusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.lblMusteriTC = new System.Windows.Forms.Label();
            this.textBoxÖdenecekTutar = new System.Windows.Forms.TextBox();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxKalanTutar = new System.Windows.Forms.TextBox();
            this.lbkKalanTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.maskedTextBoxCVC);
            this.groupBox1.Controls.Add(this.lblGuvenlikKodu);
            this.groupBox1.Controls.Add(this.maskedTextBoxSonKullanma);
            this.groupBox1.Controls.Add(this.lblSonKullanmaTarihi);
            this.groupBox1.Controls.Add(this.textBoxKartİsim);
            this.groupBox1.Controls.Add(this.lblKartİsim);
            this.groupBox1.Controls.Add(this.maskedTextBoxKartNumarasi);
            this.groupBox1.Controls.Add(this.lblKartNumarasi);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(102, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kartı/Banka Kartı";
            // 
            // maskedTextBoxCVC
            // 
            this.maskedTextBoxCVC.Location = new System.Drawing.Point(320, 340);
            this.maskedTextBoxCVC.Mask = "000";
            this.maskedTextBoxCVC.Name = "maskedTextBoxCVC";
            this.maskedTextBoxCVC.Size = new System.Drawing.Size(196, 30);
            this.maskedTextBoxCVC.TabIndex = 7;
            this.maskedTextBoxCVC.ValidatingType = typeof(int);
            // 
            // lblGuvenlikKodu
            // 
            this.lblGuvenlikKodu.AutoSize = true;
            this.lblGuvenlikKodu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlikKodu.Location = new System.Drawing.Point(327, 281);
            this.lblGuvenlikKodu.Name = "lblGuvenlikKodu";
            this.lblGuvenlikKodu.Size = new System.Drawing.Size(199, 20);
            this.lblGuvenlikKodu.TabIndex = 6;
            this.lblGuvenlikKodu.Text = "Güvenlik Kodu(CVC)";
            // 
            // maskedTextBoxSonKullanma
            // 
            this.maskedTextBoxSonKullanma.Location = new System.Drawing.Point(93, 340);
            this.maskedTextBoxSonKullanma.Mask = "00/00";
            this.maskedTextBoxSonKullanma.Name = "maskedTextBoxSonKullanma";
            this.maskedTextBoxSonKullanma.Size = new System.Drawing.Size(196, 30);
            this.maskedTextBoxSonKullanma.TabIndex = 5;
            this.maskedTextBoxSonKullanma.ValidatingType = typeof(System.DateTime);
            // 
            // lblSonKullanmaTarihi
            // 
            this.lblSonKullanmaTarihi.AutoSize = true;
            this.lblSonKullanmaTarihi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonKullanmaTarihi.Location = new System.Drawing.Point(89, 281);
            this.lblSonKullanmaTarihi.Name = "lblSonKullanmaTarihi";
            this.lblSonKullanmaTarihi.Size = new System.Drawing.Size(200, 20);
            this.lblSonKullanmaTarihi.TabIndex = 4;
            this.lblSonKullanmaTarihi.Text = "Son Kullanma Tarihi";
            // 
            // textBoxKartİsim
            // 
            this.textBoxKartİsim.Location = new System.Drawing.Point(93, 211);
            this.textBoxKartİsim.Name = "textBoxKartİsim";
            this.textBoxKartİsim.Size = new System.Drawing.Size(423, 30);
            this.textBoxKartİsim.TabIndex = 3;
            // 
            // lblKartİsim
            // 
            this.lblKartİsim.AutoSize = true;
            this.lblKartİsim.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartİsim.Location = new System.Drawing.Point(80, 166);
            this.lblKartİsim.Name = "lblKartİsim";
            this.lblKartİsim.Size = new System.Drawing.Size(218, 20);
            this.lblKartİsim.TabIndex = 2;
            this.lblKartİsim.Text = "Kartın Üzerindeki İsim";
            // 
            // maskedTextBoxKartNumarasi
            // 
            this.maskedTextBoxKartNumarasi.Location = new System.Drawing.Point(93, 91);
            this.maskedTextBoxKartNumarasi.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxKartNumarasi.Name = "maskedTextBoxKartNumarasi";
            this.maskedTextBoxKartNumarasi.Size = new System.Drawing.Size(423, 30);
            this.maskedTextBoxKartNumarasi.TabIndex = 1;
            // 
            // lblKartNumarasi
            // 
            this.lblKartNumarasi.AutoSize = true;
            this.lblKartNumarasi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNumarasi.Location = new System.Drawing.Point(80, 51);
            this.lblKartNumarasi.Name = "lblKartNumarasi";
            this.lblKartNumarasi.Size = new System.Drawing.Size(144, 20);
            this.lblKartNumarasi.TabIndex = 0;
            this.lblKartNumarasi.Text = "Kart Numarası";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.Location = new System.Drawing.Point(110, 192);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(115, 20);
            this.lblMusteriAd.TabIndex = 11;
            this.lblMusteriAd.Text = "Müşteri Ad:";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.Location = new System.Drawing.Point(80, 233);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(145, 20);
            this.lblMusteriSoyad.TabIndex = 12;
            this.lblMusteriSoyad.Text = "Müşteri Soyad:";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(112, 113);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(113, 20);
            this.lblMusteriID.TabIndex = 13;
            this.lblMusteriID.Text = "Müşteri ID:";
            // 
            // textBoxMusteriID
            // 
            this.textBoxMusteriID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMusteriID.Location = new System.Drawing.Point(253, 106);
            this.textBoxMusteriID.Name = "textBoxMusteriID";
            this.textBoxMusteriID.Size = new System.Drawing.Size(239, 27);
            this.textBoxMusteriID.TabIndex = 14;
            // 
            // textBoxMusteriAd
            // 
            this.textBoxMusteriAd.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMusteriAd.Location = new System.Drawing.Point(253, 185);
            this.textBoxMusteriAd.Name = "textBoxMusteriAd";
            this.textBoxMusteriAd.Size = new System.Drawing.Size(239, 27);
            this.textBoxMusteriAd.TabIndex = 15;
            // 
            // textBoxMusteriSoyad
            // 
            this.textBoxMusteriSoyad.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMusteriSoyad.Location = new System.Drawing.Point(253, 225);
            this.textBoxMusteriSoyad.Name = "textBoxMusteriSoyad";
            this.textBoxMusteriSoyad.Size = new System.Drawing.Size(239, 27);
            this.textBoxMusteriSoyad.TabIndex = 16;
            // 
            // lblOdenenTutar
            // 
            this.lblOdenenTutar.AutoSize = true;
            this.lblOdenenTutar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenTutar.Location = new System.Drawing.Point(80, 361);
            this.lblOdenenTutar.Name = "lblOdenenTutar";
            this.lblOdenenTutar.Size = new System.Drawing.Size(143, 20);
            this.lblOdenenTutar.TabIndex = 17;
            this.lblOdenenTutar.Text = "Ödenen Tutar:";
            // 
            // lblOdenenTarih
            // 
            this.lblOdenenTarih.AutoSize = true;
            this.lblOdenenTarih.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenTarih.Location = new System.Drawing.Point(84, 402);
            this.lblOdenenTarih.Name = "lblOdenenTarih";
            this.lblOdenenTarih.Size = new System.Drawing.Size(139, 20);
            this.lblOdenenTarih.TabIndex = 18;
            this.lblOdenenTarih.Text = "Ödeme Tarihi:";
            // 
            // lblKalanBorc
            // 
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanBorc.Location = new System.Drawing.Point(107, 443);
            this.lblKalanBorc.Name = "lblKalanBorc";
            this.lblKalanBorc.Size = new System.Drawing.Size(116, 20);
            this.lblKalanBorc.TabIndex = 19;
            this.lblKalanBorc.Text = "Kalan Borç:";
            // 
            // textBoxOdenenTutar
            // 
            this.textBoxOdenenTutar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOdenenTutar.Location = new System.Drawing.Point(253, 354);
            this.textBoxOdenenTutar.Name = "textBoxOdenenTutar";
            this.textBoxOdenenTutar.Size = new System.Drawing.Size(239, 27);
            this.textBoxOdenenTutar.TabIndex = 20;
            // 
            // dateTimePickerOdenenTarihi
            // 
            this.dateTimePickerOdenenTarihi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerOdenenTarihi.Location = new System.Drawing.Point(253, 395);
            this.dateTimePickerOdenenTarihi.Name = "dateTimePickerOdenenTarihi";
            this.dateTimePickerOdenenTarihi.Size = new System.Drawing.Size(239, 27);
            this.dateTimePickerOdenenTarihi.TabIndex = 21;
            // 
            // textBoxKalanBorc
            // 
            this.textBoxKalanBorc.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKalanBorc.Location = new System.Drawing.Point(253, 436);
            this.textBoxKalanBorc.Name = "textBoxKalanBorc";
            this.textBoxKalanBorc.Size = new System.Drawing.Size(239, 27);
            this.textBoxKalanBorc.TabIndex = 22;
            // 
            // buttonOdemeYap
            // 
            this.buttonOdemeYap.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOdemeYap.Location = new System.Drawing.Point(357, 472);
            this.buttonOdemeYap.Name = "buttonOdemeYap";
            this.buttonOdemeYap.Size = new System.Drawing.Size(135, 42);
            this.buttonOdemeYap.TabIndex = 23;
            this.buttonOdemeYap.Text = "Ödeme Yap";
            this.buttonOdemeYap.UseVisualStyleBackColor = true;
            this.buttonOdemeYap.Click += new System.EventHandler(this.buttonOdemeYap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.textBoxKalanTutar);
            this.groupBox3.Controls.Add(this.lbkKalanTutar);
            this.groupBox3.Controls.Add(this.textBoxRezervasyonID);
            this.groupBox3.Controls.Add(this.lblRezervasyonID);
            this.groupBox3.Controls.Add(this.maskedTextBoxMusteriTC);
            this.groupBox3.Controls.Add(this.buttonGoster);
            this.groupBox3.Controls.Add(this.lblMusteriTC);
            this.groupBox3.Controls.Add(this.textBoxÖdenecekTutar);
            this.groupBox3.Controls.Add(this.lblOdenecekTutar);
            this.groupBox3.Controls.Add(this.buttonOdemeYap);
            this.groupBox3.Controls.Add(this.textBoxKalanBorc);
            this.groupBox3.Controls.Add(this.dateTimePickerOdenenTarihi);
            this.groupBox3.Controls.Add(this.textBoxOdenenTutar);
            this.groupBox3.Controls.Add(this.lblKalanBorc);
            this.groupBox3.Controls.Add(this.lblOdenenTarih);
            this.groupBox3.Controls.Add(this.lblOdenenTutar);
            this.groupBox3.Controls.Add(this.textBoxMusteriSoyad);
            this.groupBox3.Controls.Add(this.textBoxMusteriAd);
            this.groupBox3.Controls.Add(this.textBoxMusteriID);
            this.groupBox3.Controls.Add(this.lblMusteriID);
            this.groupBox3.Controls.Add(this.lblMusteriSoyad);
            this.groupBox3.Controls.Add(this.lblMusteriAd);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(707, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 537);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Bilgileri";
            // 
            // textBoxRezervasyonID
            // 
            this.textBoxRezervasyonID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRezervasyonID.Location = new System.Drawing.Point(253, 70);
            this.textBoxRezervasyonID.Name = "textBoxRezervasyonID";
            this.textBoxRezervasyonID.Size = new System.Drawing.Size(239, 27);
            this.textBoxRezervasyonID.TabIndex = 29;
            // 
            // lblRezervasyonID
            // 
            this.lblRezervasyonID.AutoSize = true;
            this.lblRezervasyonID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRezervasyonID.Location = new System.Drawing.Point(63, 73);
            this.lblRezervasyonID.Name = "lblRezervasyonID";
            this.lblRezervasyonID.Size = new System.Drawing.Size(158, 20);
            this.lblRezervasyonID.TabIndex = 28;
            this.lblRezervasyonID.Text = "Rezervasyon ID:";
            // 
            // maskedTextBoxMusteriTC
            // 
            this.maskedTextBoxMusteriTC.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxMusteriTC.Location = new System.Drawing.Point(253, 143);
            this.maskedTextBoxMusteriTC.Mask = "00000000000";
            this.maskedTextBoxMusteriTC.Name = "maskedTextBoxMusteriTC";
            this.maskedTextBoxMusteriTC.Size = new System.Drawing.Size(239, 27);
            this.maskedTextBoxMusteriTC.TabIndex = 27;
            // 
            // buttonGoster
            // 
            this.buttonGoster.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGoster.Location = new System.Drawing.Point(508, 323);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(76, 23);
            this.buttonGoster.TabIndex = 8;
            this.buttonGoster.Text = "Göster";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // lblMusteriTC
            // 
            this.lblMusteriTC.AutoSize = true;
            this.lblMusteriTC.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriTC.Location = new System.Drawing.Point(103, 150);
            this.lblMusteriTC.Name = "lblMusteriTC";
            this.lblMusteriTC.Size = new System.Drawing.Size(120, 20);
            this.lblMusteriTC.TabIndex = 26;
            this.lblMusteriTC.Text = "Müşteri T.C:";
            // 
            // textBoxÖdenecekTutar
            // 
            this.textBoxÖdenecekTutar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxÖdenecekTutar.Location = new System.Drawing.Point(253, 266);
            this.textBoxÖdenecekTutar.Name = "textBoxÖdenecekTutar";
            this.textBoxÖdenecekTutar.Size = new System.Drawing.Size(239, 27);
            this.textBoxÖdenecekTutar.TabIndex = 25;
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(63, 273);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(160, 20);
            this.lblOdenecekTutar.TabIndex = 24;
            this.lblOdenecekTutar.Text = "Ödenecek Tutar:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1275, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 173;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1332, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 174;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(410, 420);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(106, 40);
            this.buttonKaydet.TabIndex = 8;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxKalanTutar
            // 
            this.textBoxKalanTutar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKalanTutar.Location = new System.Drawing.Point(253, 319);
            this.textBoxKalanTutar.Name = "textBoxKalanTutar";
            this.textBoxKalanTutar.Size = new System.Drawing.Size(239, 27);
            this.textBoxKalanTutar.TabIndex = 31;
            // 
            // lbkKalanTutar
            // 
            this.lbkKalanTutar.AutoSize = true;
            this.lbkKalanTutar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkKalanTutar.Location = new System.Drawing.Point(73, 307);
            this.lbkKalanTutar.Name = "lbkKalanTutar";
            this.lbkKalanTutar.Size = new System.Drawing.Size(146, 40);
            this.lbkKalanTutar.TabIndex = 30;
            this.lbkKalanTutar.Text = "Son Ödemeden\r\nKalan Tutar:";
            this.lbkKalanTutar.Click += new System.EventHandler(this.label1_Click);
            // 
            // ÖdemeKredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 732);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ÖdemeKredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.ÖdemeKredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCVC;
        private System.Windows.Forms.Label lblGuvenlikKodu;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSonKullanma;
        private System.Windows.Forms.Label lblSonKullanmaTarihi;
        private System.Windows.Forms.TextBox textBoxKartİsim;
        private System.Windows.Forms.Label lblKartİsim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKartNumarasi;
        private System.Windows.Forms.Label lblKartNumarasi;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox textBoxMusteriID;
        private System.Windows.Forms.TextBox textBoxMusteriAd;
        private System.Windows.Forms.TextBox textBoxMusteriSoyad;
        private System.Windows.Forms.Label lblOdenenTutar;
        private System.Windows.Forms.Label lblOdenenTarih;
        private System.Windows.Forms.Label lblKalanBorc;
        private System.Windows.Forms.TextBox textBoxOdenenTutar;
        private System.Windows.Forms.DateTimePicker dateTimePickerOdenenTarihi;
        private System.Windows.Forms.TextBox textBoxKalanBorc;
        private System.Windows.Forms.Button buttonOdemeYap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMusteriTC;
        private System.Windows.Forms.TextBox textBoxÖdenecekTutar;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Button buttonGoster;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMusteriTC;
        private System.Windows.Forms.TextBox textBoxRezervasyonID;
        private System.Windows.Forms.Label lblRezervasyonID;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxKalanTutar;
        private System.Windows.Forms.Label lbkKalanTutar;
    }
}