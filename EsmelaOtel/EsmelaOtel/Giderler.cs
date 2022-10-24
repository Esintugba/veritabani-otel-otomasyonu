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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Giderler_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (GiderAy,GiderAd,Telefon,İnternet,Elektrik,Su,Dogalgaz,TemizlikMalzemeleri,MutfakMasraflari,PersonelMaasları,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",comboBoxGiderAy.Text);
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
                MessageBox.Show("Giderler eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GiderGuncelle gd=new GiderGuncelle();
            gd.Show();
            this.Hide();
        }

        private void lblGiderAd_Click(object sender, EventArgs e)
        {

        }
    }
}
