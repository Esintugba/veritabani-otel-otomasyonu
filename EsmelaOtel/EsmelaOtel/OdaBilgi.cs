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
    public partial class OdaBilgi : Form
    {
        public OdaBilgi()
        {
            InitializeComponent();
        }

        private void OdaBilgi_Load(object sender, EventArgs e)
        {

        }

        private void buttonJuniorSuit_Click(object sender, EventArgs e)
        {
            JuniorSuit js=new JuniorSuit();
            js.Show();
        }

        private void buttonStandartOda_Click(object sender, EventArgs e)
        {
            StandartOda od = new StandartOda();
            od.Show();
            
        }

        private void buttonTwinOda_Click(object sender, EventArgs e)
        {
            TwinOda o=new TwinOda();
            o.Show();
        }

        private void buttonJuniorSuiteKingBed_Click(object sender, EventArgs e)
        {
            JuniorSuiteKingBed jb = new JuniorSuiteKingBed();
            jb.Show();
        }

        private void buttonSuiteKingBed_Click(object sender, EventArgs e)
        {
            SuiteKingBed sb=new SuiteKingBed();
            sb.Show();
        }
    }
}
