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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void PersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void buttonPersonelGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personel where PersonelTC=@p1 and PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxPersonelSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                PersonelEkrani fr = new PersonelEkrani();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C Kimlik Numarası veya Şifre !!");
                maskedTextBoxTC.Clear();
                textBoxPersonelSifre.Clear();
            }

            bgl.baglanti().Close();
        }
    }
}
