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
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }  

        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlCommand cmdkaydet = new SqlCommand("insert into Müsteri(MusteriTC,MusteriAd,MusteriSoyad,MusteriDogumYeri," +
                "MusteriDOgumTarihi,MusteriUyruk,MusteriKanGrubu,MusteriTelefon,MusteriMail,MusteriAdres) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            cmdkaydet.Parameters.AddWithValue("@p1", maskedTextBoxMusteriTc.Text);
            cmdkaydet.Parameters.AddWithValue("@p2", textBoxMusteriAd.Text);
            cmdkaydet.Parameters.AddWithValue("@p3", textBoxMusteriSoyad.Text);
            cmdkaydet.Parameters.AddWithValue("@p4", textBoxMusteriDogumYeri.Text);
            cmdkaydet.Parameters.AddWithValue("@p5", dateTimePickerDogumTarihi.Text);
            cmdkaydet.Parameters.AddWithValue("@p6", textBoxMusteriUyruk.Text);
            cmdkaydet.Parameters.AddWithValue("@p7", textBoxMusteriKanGrubu.Text);
            cmdkaydet.Parameters.AddWithValue("@p8", maskedTextBoxMusteriTelefon.Text);
            cmdkaydet.Parameters.AddWithValue("@p9", textBoxMusteriMail.Text);
            cmdkaydet.Parameters.AddWithValue("@p10", richTextBoxMusteriAdres.Text);
            cmdkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarı İle Oluşturuldu.");


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            maskedTextBoxMusteriTc.Clear();
            textBoxMusteriAd.Clear();
            textBoxMusteriSoyad.Clear();
            textBoxMusteriDogumYeri.Clear();
            dateTimePickerDogumTarihi.Text = "";
            textBoxMusteriUyruk.Clear();
            textBoxMusteriKanGrubu.Clear();
            maskedTextBoxMusteriTelefon.Clear();
            textBoxMusteriMail.Clear();
            richTextBoxMusteriAdres.Clear();

        }

        private void richTextBoxMusteriAdres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
