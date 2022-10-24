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
    public partial class OtelFoto4 : Form
    {
        public OtelFoto4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OtelFoto3 foto = new OtelFoto3();
            foto.Show();
            this.Hide();
        }
    }
}
