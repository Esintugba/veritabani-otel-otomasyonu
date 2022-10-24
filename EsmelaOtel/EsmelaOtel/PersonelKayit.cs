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
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string id, tc, ad, soyad, mail, tel, sifre, kangrubu, departman, maas, dogumtarihi, dogumyeri, uyruk, isebaslama;
        private void PersonelKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSetPersonel.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.dBOtelOtomasyonDataSetPersonel.Personel);

            textBoxPersonelId.Text = id;
            maskedTextBoxPersonelTc.Text = tc;
            textBoxPersonelAd.Text = ad;
            textBoxPersonelSoyad.Text = soyad;
            textBoxPersonelMail.Text = mail;
            maskedTextBoxPersonelTelefon.Text = tel;
            textBoxPersonelSifre.Text = sifre;
            textBoxPersonelKanGrubu.Text = kangrubu;
            comboBoxPersonelDepartman.Text = departman;
            textBoxPersonelMaas.Text = maas;
            dateTimePickerDogumTarihi.Text = dogumtarihi;
            textBoxPersonelDogumYeri.Text = dogumyeri;
            textBoxPersonelUyruk.Text = uyruk;
            dateTimePickerİseBaslamaTarihi.Text = isebaslama;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Personel(PersonelTC,PersonelAd,PersonelSoyad,PersonelMail,PersonelTelefon,PersonelSifre,KanGrubu,PersonelDepartman,PersonelMaas,PersonelDogumTarihi,PersonelDogumYeri,PersonelUyruk,İseBaslamaTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", maskedTextBoxPersonelTc.Text);
            komutkaydet.Parameters.AddWithValue("@p2", textBoxPersonelAd.Text);
            komutkaydet.Parameters.AddWithValue("@p3", textBoxPersonelSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p4", textBoxPersonelMail.Text);
            komutkaydet.Parameters.AddWithValue("@p5", maskedTextBoxPersonelTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p6", textBoxPersonelSifre.Text);
            komutkaydet.Parameters.AddWithValue("@p7", textBoxPersonelKanGrubu.Text);
            komutkaydet.Parameters.AddWithValue("@p8", comboBoxPersonelDepartman.Text);
            komutkaydet.Parameters.AddWithValue("@p9", textBoxPersonelMaas.Text);
            komutkaydet.Parameters.AddWithValue("@p10", dateTimePickerDogumTarihi.Text);
            komutkaydet.Parameters.AddWithValue("@p11", textBoxPersonelDogumYeri.Text);
            komutkaydet.Parameters.AddWithValue("@p12", textBoxPersonelUyruk.Text);
            komutkaydet.Parameters.AddWithValue("@p13", dateTimePickerİseBaslamaTarihi.Text);
            komutkaydet.ExecuteNonQuery();
            this.personelTableAdapter.Fill(this.dBOtelOtomasyonDataSetPersonel.Personel);
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Kaydedildi.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Personel where PersonelID = @d1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@d1", textBoxPersonelId.Text);
            komutsil.ExecuteNonQuery();
            this.personelTableAdapter.Fill(this.dBOtelOtomasyonDataSetPersonel.Personel);
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update Personel set PersonelTC=@a2,PersonelAd=@a3,PersonelSoyad=@a4,PersonelMail=@a5,PersonelTelefon=@a6,PersonelSifre=@a7,KanGrubu=@a8,PersonelDepartman=@a9,PersonelMaas=@a10,PersonelDogumTarihi=@a11,PersonelDogumYeri=@a12,PersonelUyruk=@a13,İseBaslamaTarihi=@a14 where PersonelID=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxPersonelId.Text);
                komutguncelle.Parameters.AddWithValue("@a2", maskedTextBoxPersonelTc.Text);
                komutguncelle.Parameters.AddWithValue("@a3", textBoxPersonelAd.Text);
                komutguncelle.Parameters.AddWithValue("@a4", textBoxPersonelSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a5", textBoxPersonelMail.Text);
                komutguncelle.Parameters.AddWithValue("@a6", maskedTextBoxPersonelTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@a7", textBoxPersonelSifre.Text);
                komutguncelle.Parameters.AddWithValue("@a8", textBoxPersonelKanGrubu.Text);
                komutguncelle.Parameters.AddWithValue("@a9", comboBoxPersonelDepartman.Text);
                komutguncelle.Parameters.AddWithValue("@a10", textBoxPersonelMaas.Text);
                komutguncelle.Parameters.AddWithValue("@a11", dateTimePickerDogumTarihi.Text);
                komutguncelle.Parameters.AddWithValue("@a12", textBoxPersonelDogumYeri.Text);
                komutguncelle.Parameters.AddWithValue("@a13", textBoxPersonelUyruk.Text);
                komutguncelle.Parameters.AddWithValue("@a14", dateTimePickerİseBaslamaTarihi.Text);
                komutguncelle.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dBOtelOtomasyonDataSetPersonel.Personel);
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
            string id, tc, ad, soyad, mail, tel, sifre, kangrubu, departman, maas, dogumtarihi, dogumyeri, uyruk, isebaslama;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tel = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            kangrubu = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            departman = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            maas = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            dogumtarihi = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            dogumyeri = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            uyruk = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            isebaslama = dataGridView1.Rows[secilen].Cells[13].Value.ToString();

            textBoxPersonelId.Text = id;
            maskedTextBoxPersonelTc.Text = tc;
            textBoxPersonelAd.Text = ad;
            textBoxPersonelSoyad.Text = soyad;
            textBoxPersonelMail.Text = mail;
            maskedTextBoxPersonelTelefon.Text = tel;
            textBoxPersonelSifre.Text = sifre;
            textBoxPersonelKanGrubu.Text = kangrubu;
            comboBoxPersonelDepartman.Text = departman;
            textBoxPersonelMaas.Text = maas;
            dateTimePickerDogumTarihi.Text = dogumtarihi;
            textBoxPersonelDogumYeri.Text = dogumyeri;
            textBoxPersonelUyruk.Text = uyruk;
            dateTimePickerİseBaslamaTarihi.Text = isebaslama;

        }
    }
}
