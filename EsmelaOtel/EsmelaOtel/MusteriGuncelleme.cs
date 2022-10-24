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
    public partial class MusteriGuncelleme : Form
    {
        public MusteriGuncelleme()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string id, tc, ad, soyad, mail, tel, odaNo, uyruk, adres, kanGrubu, odeme;

        private void button106_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "106";
        }

        private void button107_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "107";
        }

        private void button108_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "108";
        }

        private void button109_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "109";
        }

        private void button201_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "201";
        }

        private void button202_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "202";
        }

        private void button203_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "203";
        }

        private void button204_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "204";
        }

        private void button205_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "205";
        }

        private void button206_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "206";
        }

        private void button207_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "207";
        }

        private void button208_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "208";
        }

        private void button209_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "209";
        }

        private void button301_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "301";
        }

        private void button302_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "302";
        }

        private void button303_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "303";
        }

        private void button304_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "304";
        }

        private void button305_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "305";
        }

        private void button306_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "306";
        }

        private void button307_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "307";
        }

        private void button308_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "308";
        }

        private void button309_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "309";
        }

        private void button401_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "401";
        }

        private void button402_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "402";
        }

        private void button403_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "403";
        }

        private void button404_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "404";
        }

        private void button405_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "405";
        }

        private void button406_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "406";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "407";
        }

        private void button408_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "408";
        }

        private void button409_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "409";
        }

        private void button501_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "501";
        }

        private void button502_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "502";
        }

        private void button503_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "503";
        }

        private void button504_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "504";
        }

        private void button505_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "505";
        }

        private void button506_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "506";
        }

        private void button507_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "507";
        }

        private void button508_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "508";
        }

        private void button509_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "509";
        }

        private void button601_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "601";
        }

        private void button602_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "602";
        }

        private void button603_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "603";
        }

        private void button604_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "604";
        }

        private void button605_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "605";
        }

        private void button606_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "606";
        }

        private void button607_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "607";
        }

        private void button608_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "608";
        }

        private void button609_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "609";
        }

        private void button701_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "701";
        }

        private void button702_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "702";
        }

        private void button703_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "703";
        }

        private void button704_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "704";
        }

        private void button705_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "705";
        }

        private void button706_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "706";
        }

        private void button707_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "707";
        }

        private void button708_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "708";
        }

        private void button709_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "709";
        }

        private void button801_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "801";
        }

        private void button802_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "802";
        }

        private void button803_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "803";
        }

        private void button804_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "804";
        }

        private void button805_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "805";
        }

        private void button806_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "806";
        }

        private void button807_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "807";
        }

        private void button808_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "808";
        }

        private void button809_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "809";
        }

        private void button901_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "901";
        }

        private void button902_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "902";
        }

        private void button903_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "903";
        }

        private void button904_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "904";
        }

        private void button905_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "905";
        }

        private void button906_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "906";
        }

        private void button907_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "907";
        }

        private void button908_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "908";
        }

        private void button909_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "909";
        }

        private void MusteriGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSet2.Müsteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsteriTableAdapter1.Fill(this.dBOtelOtomasyonDataSet2.Müsteri);
            

            textBoxMusteriID.Text = id;
            maskedTextBoxMusteriTc.Text = tc;
            textBoxMusteriAd.Text = ad;
            textBoxMusteriSoyad.Text = soyad;
            textBoxMusteriMail.Text = mail;
            maskedTextBoxMusteriTelefon.Text = tel;
            comboBoxMusteriOdaNo.Text = odaNo;
            textBoxMusteriUyruk.Text = uyruk;
            richTextBoxMusteriAdres.Text = adres;
            textBoxMusteriKanGrubu.Text = kanGrubu;
            textBoxMusteriOdeme.Text = odeme;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, tc, ad, soyad, mail, tel, odaNo, uyruk, adres, kanGrubu;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tel = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            odaNo = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            uyruk = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            adres = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            kanGrubu = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            

            textBoxMusteriID.Text = id;
            maskedTextBoxMusteriTc.Text = tc;
            textBoxMusteriAd.Text = ad;
            textBoxMusteriSoyad.Text = soyad;
            textBoxMusteriMail.Text = mail;
            maskedTextBoxMusteriTelefon.Text = tel;
            comboBoxMusteriOdaNo.Text = odaNo;
            textBoxMusteriUyruk.Text = uyruk;
            richTextBoxMusteriAdres.Text = adres;
            textBoxMusteriKanGrubu.Text = kanGrubu;
            


        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Müsteri(MusteriTC,MusteriAd,MusteriSoyad,MusteriMail,MusteriTelefon,MusteriOdaNumarası,MusteriUyruk,MusteriAdres,MusteriKanGrubu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", maskedTextBoxMusteriTc.Text);
            komutkaydet.Parameters.AddWithValue("@p2", textBoxMusteriAd.Text);
            komutkaydet.Parameters.AddWithValue("@p3", textBoxMusteriSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p4", textBoxMusteriMail.Text);
            komutkaydet.Parameters.AddWithValue("@p5", maskedTextBoxMusteriTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p6", comboBoxMusteriOdaNo.Text);
            komutkaydet.Parameters.AddWithValue("@p7", textBoxMusteriUyruk.Text);
            komutkaydet.Parameters.AddWithValue("@p8", richTextBoxMusteriAdres.Text);
            komutkaydet.Parameters.AddWithValue("@p9",textBoxMusteriKanGrubu.Text);
            
            komutkaydet.ExecuteNonQuery();
            this.müsteriTableAdapter1.Fill(this.dBOtelOtomasyonDataSet2.Müsteri);
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Kaydedildi.");


            //Oda Kontenjanı Azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNumarası=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", comboBoxMusteriOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Müsteri where MusteriID = @d1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@d1", textBoxMusteriID.Text);
            komutsil.ExecuteNonQuery();
            this.müsteriTableAdapter1.Fill(this.dBOtelOtomasyonDataSet2.Müsteri);
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update Musteri set MusteriTC=@a2,MusteriAd=@a3,MusteriSoyad=@a4,MusteriMail=@a5,MusteriTelefon=@a6,MusteriOdaNumarası=@a7,MusteriUyruk=@a8,MusteriAdres=@a9,MusteriKanGrubu=@a10where MusteriID=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxMusteriID.Text);
                komutguncelle.Parameters.AddWithValue("@a2", maskedTextBoxMusteriTc.Text);
                komutguncelle.Parameters.AddWithValue("@a3", textBoxMusteriAd.Text);
                komutguncelle.Parameters.AddWithValue("@a4", textBoxMusteriSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a5", textBoxMusteriMail.Text);
                komutguncelle.Parameters.AddWithValue("@a6", maskedTextBoxMusteriTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@a7", comboBoxMusteriOdaNo.Text);
                komutguncelle.Parameters.AddWithValue("@a8", textBoxMusteriUyruk.Text);
                komutguncelle.Parameters.AddWithValue("@a9", richTextBoxMusteriAdres.Text);
                komutguncelle.Parameters.AddWithValue("@a10", textBoxMusteriKanGrubu.Text);
                
                komutguncelle.ExecuteNonQuery();
                this.müsteriTableAdapter1.Fill(this.dBOtelOtomasyonDataSet2.Müsteri);
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }
        private void button101_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "101";
        }
        private void button102_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "102";
        }
        private void button103_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "103";
        }
        private void button105_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "105";
        }

        private void button104_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "104";
        }



    }
}
