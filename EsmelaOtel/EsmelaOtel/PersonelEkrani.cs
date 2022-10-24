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
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }

        private void PersonelEkrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBOtelOtomasyonDataSet3.Müsteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsteriTableAdapter1.Fill(this.dBOtelOtomasyonDataSet3.Müsteri);


        }

        private void buttonPersonelDüzenle_Click(object sender, EventArgs e)
        {
            PersonelKayit pr=new PersonelKayit();
            pr.Show();
        }

        private void buttonMüsteriDüzenle_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme ms=new MusteriGuncelleme();
            ms.Show();

        }

        private void buttonOdaDüzenle_Click(object sender, EventArgs e)
        {
            Odalar od=new Odalar();
            od.Show();
        }

        private void buttonOtelDüzenle_Click(object sender, EventArgs e)
        {
            OtelBilgisi ot=new OtelBilgisi();
            ot.Show();
        }

        private void buttonOdemeBilgileri_Click(object sender, EventArgs e)
        {
            ÖdemeKredi öd=new ÖdemeKredi(); 
            öd.Show();
        }

        private void buttonGiderBilgileri_Click(object sender, EventArgs e)
        {
            Giderler gd=new Giderler();
            gd.Show();
        }
    }
}
