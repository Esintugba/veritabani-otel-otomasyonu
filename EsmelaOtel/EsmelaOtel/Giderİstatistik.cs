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
    public partial class Giderİstatistik : Form
    {
        public Giderİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        private void Giderİstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam miktar
            SqlCommand komuta = new SqlCommand("Select sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader okua = komuta.ExecuteReader();
            while (okua.Read())
            {
                label3.Text = okua[0].ToString() + "TL";
            }
            bgl.baglanti().Close();

            //Tekrarsız olarak aylar listesi
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeTarih) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBoxGiderAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            //Grafiklere veritabanından veri çekme

            SqlCommand komut3 = new SqlCommand("select OdemeTarih,sum(OdemeMiktar) From Kasa group by OdemeTarih", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }

            bgl.baglanti().Close();
        }

        private void comboBoxGiderAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) From Kasa where OdemeTarih=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxGiderAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label4.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void textBoxGiderAd_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komutt = new SqlCommand("select sum(OdemeMiktar) From Kasa where OdemeAd=@b1", bgl.baglanti());
            komutt.Parameters.AddWithValue("@b1", textBoxGiderAd.Text);
            SqlDataReader okuu = komutt.ExecuteReader();
            while (okuu.Read())
            {
                label4.Text = okuu[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
