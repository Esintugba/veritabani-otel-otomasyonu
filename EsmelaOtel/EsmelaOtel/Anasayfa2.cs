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
    public partial class Anasayfa2 : Form
    {
        public Anasayfa2()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Anasayfa2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MusteriGiris fr = new MusteriGiris();
            fr.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            YoneticiGiris fr1 = new YoneticiGiris();
            fr1.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PersonelGiris fr2 = new PersonelGiris();
            fr2.Show();
            

        }
    }
}
