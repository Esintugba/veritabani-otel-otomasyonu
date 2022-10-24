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
    public partial class ÖdemeNakit : Form
    {
        public ÖdemeNakit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            //ödenen tutardan kalan tutarı çıkarma
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(textBoxOdenenTutar.Text);
            kalan = Convert.ToInt16(textBoxÖdenecekTutar.Text);
            yeniborc = kalan - odenen;
            textBoxKalanBorc.Text = yeniborc.ToString();

            //Yeni tutarı veritabanına kaydetme
            SqlCommand komut = new SqlCommand("update OdemeNakit set MusteriTC=@p2,MusteriAd=@p3,MusteriSoyad=@p4,OdenenTutar=@p5,OdemeTarihi=@p6,OdemeKodu=@p7, where MusteriID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxMusteriID.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBoxMusteriTC.Text);
            komut.Parameters.AddWithValue("@p3", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@p4", textBoxMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@p5", textBoxOdenenTutar.Text);
            komut.Parameters.AddWithValue("@p6", dateTimePickerOdemeTarihi.Text);
            komut.Parameters.AddWithValue("@p7", textBoxOdemeKodu.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödemesi Alındı");

            //Kasa Tablosuna Ekleme
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeTarih,OdemeMiktar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", dateTimePickerOdemeTarihi.Text);
            komut2.Parameters.AddWithValue("@k2", textBoxOdenenTutar.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBoxMusteriID.Clear();
            maskedTextBoxMusteriTC.Clear();
            textBoxMusteriAd.Clear();
            textBoxMusteriSoyad.Clear();
            textBoxOdemeKodu.Clear();
            textBoxOdenenTutar.Clear();
            dateTimePickerOdemeTarihi.Text = "";
            textBoxKalanBorc.Clear();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÖdemeNakit_Load(object sender, EventArgs e)
        {

        }

        private void buttonDogrula_Click(object sender, EventArgs e)
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

            //Musteri Ad textbox'a çekme

            SqlCommand komutad = new SqlCommand("select MusteriAd from Müsteri", bgl.baglanti());
            SqlDataReader okuad = komutad.ExecuteReader();
            while (okuad.Read())
            {
                textBoxMusteriID.Text = okuad[0].ToString();
            }
            bgl.baglanti().Close();


            //Musteri Soyad textbox'a çekme

            SqlCommand komutsoyad = new SqlCommand("select MusteriSoyad from Müsteri", bgl.baglanti());
            SqlDataReader okusoyad = komutsoyad.ExecuteReader();
            while (okusoyad.Read())
            {
                textBoxMusteriID.Text = okusoyad[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
