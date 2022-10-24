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
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSetmusteri.Müsteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsteriTableAdapter1.Fill(this.dBOtelOtomasyonDataSetmusteri.Müsteri);
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSetPersonelY.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.dBOtelOtomasyonDataSetPersonelY.Personel);
            

        }

        private void buttonPersonelDüzenle_Click(object sender, EventArgs e)
        {
            PersonelKayit fr = new PersonelKayit();
            fr.Show();
        }

        private void buttonMüsteriDüzenle_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme fr1 = new MusteriGuncelleme();
            fr1.Show();
        }

        private void buttonYöneticiDüzenle_Click(object sender, EventArgs e)
        {
            YoneticiKayit fr2 = new YoneticiKayit();
            fr2.Show();
        }

        private void buttonOtelDüzenle_Click(object sender, EventArgs e)
        {
            OtelBilgisi fr3 = new OtelBilgisi();
            fr3.Show();
        }

        private void buttonGiderBilgileri_Click(object sender, EventArgs e)
        {
            Giderler gd=new Giderler();
            gd.Show();
        }

        private void buttonOdaDüzenle_Click(object sender, EventArgs e)
        {
            OdaBilgi od=new OdaBilgi();
            od.Show();
        }

        private void buttonGiderİstatistik_Click(object sender, EventArgs e)
        {
            Giderİstatistik iss=new Giderİstatistik();
            iss.Show();
        }
    }
}
