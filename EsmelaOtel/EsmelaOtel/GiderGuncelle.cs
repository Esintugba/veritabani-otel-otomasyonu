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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace EsmelaOtel
{
    public partial class GiderGuncelle : Form
    {
        public GiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string gideray, giderad, telefon, internet, elektrik, su, dogalgaz, temizlik, mutfak, personel, diger;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GiderGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSet1.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.dBOtelOtomasyonDataSet1.Giderler);
            textBoxGiderAd.Text = giderad;
            comboBoxGiderAy.Text = gideray;
            textBoxGiderTelefon.Text = telefon;
            textBoxGiderİnternet.Text = internet;
            textBoxGiderSu.Text = su;
            textBoxGiderDogalgaz.Text = dogalgaz;
            textBoxGiderTemizlik.Text = telefon;
            textBoxGiderMutfak.Text = mutfak;
            textBoxGiderPersobel.Text = personel;
            textBoxGiderDiger.Text = diger;


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set GiderAy=@p1,GiderAd=@p2,Telefon=@p3,İnternet=@p4,Elektrik=@p5,Su=@p6,Dogalgaz=@p7,TemizlikMalzemeleri=@p8,MutfakMasraflari=@p9,PersonelMaasları=@p10,Diger=@p11 where GiderID=@p12", bgl.baglanti());
                komut.Parameters.AddWithValue("@p12", textBoxGiderID.Text);
                komut.Parameters.AddWithValue("@p1", comboBoxGiderAy.Text);
                komut.Parameters.AddWithValue("@p2", textBoxGiderAd.Text);
                komut.Parameters.AddWithValue("@p3", textBoxGiderTelefon.Text);
                komut.Parameters.AddWithValue("@p4", textBoxGiderİnternet.Text);
                komut.Parameters.AddWithValue("@p5", textBoxGiderElektirk.Text);
                komut.Parameters.AddWithValue("@p6", textBoxGiderSu.Text);
                komut.Parameters.AddWithValue("@p7", textBoxGiderDogalgaz.Text);
                komut.Parameters.AddWithValue("@p8", textBoxGiderTemizlik.Text);
                komut.Parameters.AddWithValue("@p9", textBoxGiderMutfak.Text);
                komut.Parameters.AddWithValue("@p10", textBoxGiderPersobel.Text);
                komut.Parameters.AddWithValue("@p11", textBoxGiderDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }

        }
    }
}
