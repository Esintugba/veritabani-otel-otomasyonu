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
    public partial class OtelFoto2 : Form
    {
        public OtelFoto2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OtelFoto3 ft = new OtelFoto3();
            ft.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Otelfoto1 fo = new Otelfoto1();
            fo.Show();
            this.Hide();
        }

        private void OtelFoto2_Load(object sender, EventArgs e)
        {

        }
    }
}
