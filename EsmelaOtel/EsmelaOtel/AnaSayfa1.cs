using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsmelaOtel
{
    public partial class AnaSayfa1 : Form
    {
        public AnaSayfa1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Anasayfa2 fr = new Anasayfa2();
            fr.Show();
            this.Hide();
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OtelBilgisi fp = new OtelBilgisi();
            fp.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Odalargecis gs=new Odalargecis();
            gs.Show();
        }

        private void AnaSayfa1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tr.wikipedia.org/wiki/Van");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Van/@38.547918,42.4663693,8z/data=!3m1!4b1!4m5!3m4!1s0x4012699af06db69f:0x3d90e48a01e79b6!8m2!3d38.3679417!4d43.7182787");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Otelfoto1 otelfoto1 = new Otelfoto1();
            otelfoto1.Show();
            this.Hide();
        }
    }
}
