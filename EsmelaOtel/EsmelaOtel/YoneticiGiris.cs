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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void YöneticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void buttonYoneticiGiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * From Yonetici where YoneticiTC=@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxYoneticiSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                YoneticiEkrani fr = new YoneticiEkrani();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C Kimlik Numarası veya Şifre !!");
                maskedTextBoxTC.Clear();
                textBoxYoneticiSifre.Clear();
            }

            bgl.baglanti().Close();
        }
    }
}
