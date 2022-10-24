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
    public partial class YoneticiKayit : Form
    {
        public YoneticiKayit()
        {
            InitializeComponent();
        }
        public string id, tc, ad, soyad, telefon, mail, sifre;

        

        SqlBaglantisi bgl = new SqlBaglantisi();

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void YoneticiKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSetYonetici.Yonetici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yoneticiTableAdapter.Fill(this.dBOtelOtomasyonDataSetYonetici.Yonetici);


            textBoxYoneticiID.Text = id;
            maskedTextBoxYoneticiTc.Text = tc;
            textBoxYoneticiAd.Text = ad;
            textBoxYoneticiSoyad.Text = soyad;
            maskedTextBoxYoneticiTelefon.Text = telefon;
            textBoxYoneticiMail.Text = mail;
            textBoxYoneticiSifre.Text = sifre;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            SqlCommand komutkaydet = new SqlCommand("insert into Yonetici(YoneticiTC,YoneticiAd,YoneticiSoyad,YoneticiTelefon,YoneticiMail,YoneticiSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", maskedTextBoxYoneticiTc.Text);
            komutkaydet.Parameters.AddWithValue("@p2", textBoxYoneticiAd.Text);
            komutkaydet.Parameters.AddWithValue("@p3", textBoxYoneticiSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p4", maskedTextBoxYoneticiTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p5", textBoxYoneticiMail.Text);
            komutkaydet.Parameters.AddWithValue("@p6", textBoxYoneticiSifre.Text);
            komutkaydet.ExecuteNonQuery();
            this.yoneticiTableAdapter.Fill(this.dBOtelOtomasyonDataSetYonetici.Yonetici);
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Bilgileri Başarıyla Kaydedildi.");



            //  Yönetici ID textboxa Çekilmesi
            SqlCommand komut = new SqlCommand("select YoneticiID from Yonetici", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBoxYoneticiID.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Yonetici where YoneticiID = @d1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@d1", textBoxYoneticiID.Text);
            komutsil.ExecuteNonQuery();
            this.yoneticiTableAdapter.Fill(this.dBOtelOtomasyonDataSetYonetici.Yonetici);
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update Yonetici set YoneticiTC=@a2,YoneticiAd=@a3,YoneticiSoyad=@a4,YoneticiTelefon=@a5,YoneticiMail=@a6,YoneticiSifre=a@7 where YoneticiID=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxYoneticiID.Text);
                komutguncelle.Parameters.AddWithValue("@a2", maskedTextBoxYoneticiTc.Text);
                komutguncelle.Parameters.AddWithValue("@a3", textBoxYoneticiAd.Text);
                komutguncelle.Parameters.AddWithValue("@a4", textBoxYoneticiSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a5", maskedTextBoxYoneticiTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@a6", textBoxYoneticiMail.Text);
                komutguncelle.Parameters.AddWithValue("@a7", textBoxYoneticiSifre.Text);
                komutguncelle.ExecuteNonQuery();
                this.yoneticiTableAdapter.Fill(this.dBOtelOtomasyonDataSetYonetici.Yonetici);
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, tc, ad, soyad, telefon, mail, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            textBoxYoneticiID.Text = id;
            maskedTextBoxYoneticiTc.Text = tc;
            textBoxYoneticiAd.Text = ad;
            textBoxYoneticiSoyad.Text = soyad;
            maskedTextBoxYoneticiTelefon.Text = telefon;
            textBoxYoneticiMail.Text = mail;
            textBoxYoneticiSifre.Text = sifre;
        }
    }
}
