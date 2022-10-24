using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EsmelaOtel
{
    public partial class StandartOda : Form
    {
        public StandartOda()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void StandartOda_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa1 an=new AnaSayfa1();
            an.Show();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
