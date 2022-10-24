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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

       

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void buttonMusteriGiris_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Müsteri where MusteriTC=@p1 and MusteriAd=@p2 and MusteriSoyad=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@p3", textBoxMusteriSoyad.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MusteriRezervasyon fr = new MusteriRezervasyon();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hata!");
                maskedTextBoxTC.Clear();
                textBoxMusteriAd.Clear();
                textBoxMusteriSoyad.Clear();
            }

            bgl.baglanti().Close();
        }

        private void S_Click(object sender, EventArgs e)
        {
            MusteriKayit fk = new MusteriKayit();
            fk.Show();
        }
    }
}
