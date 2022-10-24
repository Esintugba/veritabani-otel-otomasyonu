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
    public partial class Odalargecis : Form
    {
        public Odalargecis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdaBilgi od=new OdaBilgi();
            od.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGiris ps=new PersonelGiris();
            ps.Show();
        }
    }
}
