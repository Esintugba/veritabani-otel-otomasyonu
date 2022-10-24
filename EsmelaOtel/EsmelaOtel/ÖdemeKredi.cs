using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EsmelaOtel

{
    public partial class ÖdemeKredi : Form
    {
        public ÖdemeKredi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void ÖdemeKredi_Load(object sender, EventArgs e)
        {

        }

        private void buttonOdemeYap_Click(object sender, EventArgs e)
        {
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(textBoxOdenenTutar.Text);
            kalan = Convert.ToInt16(textBoxÖdenecekTutar.Text);
            yeniborc = kalan - odenen;
            textBoxKalanBorc.Text = yeniborc.ToString();

            //Yeni tutarı veritabanına kaydetme
            SqlCommand komutguncelle = new SqlCommand("update OdemeKredi set KalanBorc=@s2 where MusteriID=@s1", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@s1", textBoxMusteriID.Text);
            komutguncelle.Parameters.AddWithValue("@s2", textBoxKalanTutar.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();


            //Kasa Tablosuna Ekleme
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeTarih,OdemeMiktar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", dateTimePickerOdenenTarihi.Text);
            komut2.Parameters.AddWithValue("@k2", textBoxOdenenTutar.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            //MusteriId textbox'a çekme
            SqlCommand komutid = new SqlCommand("select MusteriID from Müsteri", bgl.baglanti());
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                textBoxMusteriID.Text = okuid[0].ToString();
            }
            bgl.baglanti().Close();

            //Odenecek tutarı textbox'a çekme
            SqlCommand kmd = new SqlCommand("select Odeme from Rezervasyon", bgl.baglanti());
            SqlDataReader okuu = kmd.ExecuteReader();
            while (okuu.Read())
            {
                textBoxÖdenecekTutar.Text = okuu[0].ToString();
            }
            bgl.baglanti().Close();

            //Kalan tutarı textbox'a çekme
            SqlCommand kmdkalan = new SqlCommand("select KalanBorc from OdemeKredi", bgl.baglanti());
            SqlDataReader okukalan = kmdkalan.ExecuteReader();
            while (okukalan.Read())
            {
                textBoxKalanTutar.Text = okukalan[0].ToString();
            }
            bgl.baglanti().Close();

            //Musteri Ad textbox'a çekme

            SqlCommand komutad = new SqlCommand("select MusteriAd from Müsteri", bgl.baglanti());
            SqlDataReader okuad = komutad.ExecuteReader();
            while (okuad.Read())
            {
                textBoxMusteriAd.Text = okuad[0].ToString();
            }
            bgl.baglanti().Close();

            //Musteri Soyad textbox'a çekme

            SqlCommand komutsoyad = new SqlCommand("select MusteriSoyad from Müsteri", bgl.baglanti());
            SqlDataReader okusoyad = komutsoyad.ExecuteReader();
            while (okusoyad.Read())
            {
                textBoxMusteriSoyad.Text = okusoyad[0].ToString();
            }
            bgl.baglanti().Close();


            SqlCommand komutrezervasyon = new SqlCommand("select RezervasyonID from Rezervasyon", bgl.baglanti());
            SqlDataReader okurezervasyon = komutrezervasyon.ExecuteReader();
            while (okurezervasyon.Read())
            {
                textBoxRezervasyonID.Text = okurezervasyon[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            maskedTextBoxMusteriTC.Clear();
            textBoxMusteriAd.Clear();
            textBoxMusteriSoyad.Clear();
            textBoxOdenenTutar.Clear();
            textBoxÖdenecekTutar.Clear();
            dateTimePickerOdenenTarihi.Text = "";
            textBoxMusteriID.Clear();
            textBoxKalanBorc.Clear();
            maskedTextBoxKartNumarasi.Clear();
            maskedTextBoxSonKullanma.Clear();
            maskedTextBoxCVC.Clear();
            textBoxKartİsim.Clear();

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into OdemeKredi (KartNumarası,Kartİsmi,SonKullanmaTarihi,GüvenlikKodu) values (@a1,@a2,@a3,@a4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", maskedTextBoxKartNumarasi.Text);
            komut.Parameters.AddWithValue("@a2", textBoxKartİsim.Text);
            komut.Parameters.AddWithValue("@a3", maskedTextBoxSonKullanma.Text);
            komut.Parameters.AddWithValue("@a4", maskedTextBoxCVC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
