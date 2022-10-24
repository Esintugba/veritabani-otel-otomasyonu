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
    public partial class Otelfoto1 : Form
    {
        public Otelfoto1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OtelFoto2 ft = new OtelFoto2();
            ft.Show();
            this.Hide();
        }

        private void Otelfoto1_Load(object sender, EventArgs e)
        {

        }
    }
}
