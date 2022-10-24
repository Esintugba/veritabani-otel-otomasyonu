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
    public partial class OtelFoto3 : Form
    {
        public OtelFoto3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OtelFoto4 ft = new OtelFoto4();
            ft.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OtelFoto2 otelFoto2 = new OtelFoto2();
            otelFoto2.Show();
            this.Hide();
        }
    }
}
