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
    public partial class MusteriRezervasyon : Form
    {
        public MusteriRezervasyon()
        {
            InitializeComponent();
        }
        public string tc,adsoyad;

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void MüsteriRezervasyon_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTC.Text = tc;
            lblAdSoyad.Text = adsoyad;

            SqlCommand komutt = new SqlCommand("Select MusteriAd,MusteriSoyad From Müsteri where MusteriTC=@p1", bgl.baglanti());
            komutt.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader okuu = komutt.ExecuteReader();
            while (okuu.Read())
            {
                lblAdSoyad.Text = okuu[0] + " " + okuu[1];
            }

            //Boş odaların listelenme komutu
            SqlCommand komuttt = new SqlCommand("Select OdaNumarası From Odalar where OdaKapasite!=OdaAktif", bgl.baglanti());
            SqlDataReader okuuu = komuttt.ExecuteReader();
            while (okuuu.Read())
            {
                comboBoxMusteriOdaNo.Items.Add(okuuu[0].ToString());
            }
            bgl.baglanti().Close();

            // 101
            SqlCommand komut = new SqlCommand("select * from Oda101", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                button101.Text = oku["OdaMusteriAd"].ToString() + "" + oku["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button101.Text != "101")
            {
                button101.BackColor = Color.SkyBlue;
            }
            //102
            SqlCommand komut1 = new SqlCommand("select * from Oda102", bgl.baglanti());
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button102.Text = oku1["OdaMusteriAd"].ToString() + "" + oku1["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button102.Text != "102")
            {
                button102.BackColor = Color.SkyBlue;
            }
            //103
            SqlCommand komut2 = new SqlCommand("select * from Oda103", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button103.Text = oku2["OdaMusteriAd"].ToString() + "" + oku2["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button103.Text != "103")
            {
                button103.BackColor = Color.SkyBlue;
            }
            //104
            SqlCommand komut3 = new SqlCommand("select * from Oda104", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button104.Text = oku3["OdaMusteriAd"].ToString() + "" + oku3["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button104.Text != "104")
            {
                button104.BackColor = Color.SkyBlue;
            }
            //105
            SqlCommand komut4 = new SqlCommand("select * from Oda105", bgl.baglanti());
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button105.Text = oku4["OdaMusteriAd"].ToString() + "" + oku4["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button105.Text != "105")
            {
                button105.BackColor = Color.SkyBlue;
            }
            //106
            SqlCommand komut5 = new SqlCommand("select * from Oda106", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button106.Text = oku5["OdaMusteriAd"].ToString() + "" + oku5["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button106.Text != "106")
            {
                button106.BackColor = Color.SkyBlue;
            }
            //107
            SqlCommand komut6 = new SqlCommand("select * from Oda107", bgl.baglanti());
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button107.Text = oku6["OdaMusteriAd"].ToString() + "" + oku6["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button107.Text != "107")
            {
                button107.BackColor = Color.SkyBlue;
            }
            //108
            SqlCommand komut7 = new SqlCommand("select * from Oda108", bgl.baglanti());
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                button108.Text = oku7["OdaMusteriAd"].ToString() + "" + oku7["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button108.Text != "108")
            {
                button108.BackColor = Color.SkyBlue;
            }
            //109
            SqlCommand komut8 = new SqlCommand("select * from Oda109", bgl.baglanti());
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                button109.Text = oku8["OdaMusteriAd"].ToString() + "" + oku8["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button109.Text != "109")
            {
                button109.BackColor = Color.SkyBlue;
            }
            //201
            SqlCommand komut9 = new SqlCommand("select * from Oda201", bgl.baglanti());
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                button201.Text = oku9["OdaMusteriAd"].ToString() + "" + oku9["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button201.Text != "201")
            {
                button201.BackColor = Color.SkyBlue;
            }
            //202
            SqlCommand komut10 = new SqlCommand("select * from Oda202", bgl.baglanti());
            SqlDataReader oku10 = komut10.ExecuteReader();
            while (oku10.Read())
            {
                button202.Text = oku10["OdaMusteriAd"].ToString() + "" + oku10["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button202.Text != "202")
            {
                button202.BackColor = Color.SkyBlue;
            }
            //203
            SqlCommand komut11 = new SqlCommand("select * from Oda203", bgl.baglanti());
            SqlDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                button203.Text = oku11["OdaMusteriAd"].ToString() + "" + oku11["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button203.Text != "203")
            {
                button203.BackColor = Color.SkyBlue;
            }
            //204
            SqlCommand komut12 = new SqlCommand("select * from Oda204", bgl.baglanti());
            SqlDataReader oku12 = komut12.ExecuteReader();
            while (oku12.Read())
            {
                button204.Text = oku12["OdaMusteriAd"].ToString() + "" + oku12["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button204.Text != "204")
            {
                button204.BackColor = Color.SkyBlue;
            }
            //205
            SqlCommand komut13 = new SqlCommand("select * from Oda205", bgl.baglanti());
            SqlDataReader oku13 = komut13.ExecuteReader();
            while (oku13.Read())
            {
                button205.Text = oku13["OdaMusteriAd"].ToString() + "" + oku13["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button205.Text != "205")
            {
                button205.BackColor = Color.SkyBlue;
            }
            //206
            SqlCommand komut14 = new SqlCommand("select * from Oda206", bgl.baglanti());
            SqlDataReader oku14 = komut14.ExecuteReader();
            while (oku14.Read())
            {
                button203.Text = oku14["OdaMusteriAd"].ToString() + "" + oku14["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button206.Text != "206")
            {
                button206.BackColor = Color.SkyBlue;
            }
            //207
            SqlCommand komut15 = new SqlCommand("select * from Oda207", bgl.baglanti());
            SqlDataReader oku15 = komut15.ExecuteReader();
            while (oku15.Read())
            {
                button207.Text = oku15["OdaMusteriAd"].ToString() + "" + oku15["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button207.Text != "207")
            {
                button207.BackColor = Color.SkyBlue;
            }
            //208
            SqlCommand komut16 = new SqlCommand("select * from Oda208", bgl.baglanti());
            SqlDataReader oku16 = komut16.ExecuteReader();
            while (oku16.Read())
            {
                button208.Text = oku16["OdaMusteriAd"].ToString() + "" + oku16["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button208.Text != "208")
            {
                button208.BackColor = Color.SkyBlue;
            }
            //209
            SqlCommand komut17 = new SqlCommand("select * from Oda209", bgl.baglanti());
            SqlDataReader oku17 = komut17.ExecuteReader();
            while (oku17.Read())
            {
                button209.Text = oku17["OdaMusteriAd"].ToString() + "" + oku17["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button209.Text != "209")
            {
                button209.BackColor = Color.SkyBlue;
            }
            //301
            SqlCommand komut18 = new SqlCommand("select * from Oda301", bgl.baglanti());
            SqlDataReader oku18 = komut18.ExecuteReader();
            while (oku18.Read())
            {
                button301.Text = oku18["OdaMusteriAd"].ToString() + "" + oku18["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button301.Text != "301")
            {
                button301.BackColor = Color.SkyBlue;
            }
            //302
            SqlCommand komut19 = new SqlCommand("select * from Oda302", bgl.baglanti());
            SqlDataReader oku19 = komut19.ExecuteReader();
            while (oku19.Read())
            {
                button302.Text = oku19["OdaMusteriAd"].ToString() + "" + oku19["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button302.Text != "302")
            {
                button302.BackColor = Color.SkyBlue;
            }
            //303
            SqlCommand komut20 = new SqlCommand("select * from Oda303", bgl.baglanti());
            SqlDataReader oku20 = komut20.ExecuteReader();
            while (oku20.Read())
            {
                button303.Text = oku20["OdaMusteriAd"].ToString() + "" + oku20["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button303.Text != "303")
            {
                button303.BackColor = Color.SkyBlue;
            }
            //304
            SqlCommand komut21 = new SqlCommand("select * from Oda304", bgl.baglanti());
            SqlDataReader oku21 = komut21.ExecuteReader();
            while (oku21.Read())
            {
                button304.Text = oku21["OdaMusteriAd"].ToString() + "" + oku21["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button304.Text != "304")
            {
                button304.BackColor = Color.SkyBlue;
            }
            //305
            SqlCommand komut22 = new SqlCommand("select * from Oda305", bgl.baglanti());
            SqlDataReader oku22 = komut22.ExecuteReader();
            while (oku22.Read())
            {
                button305.Text = oku22["OdaMusteriAd"].ToString() + "" + oku22["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button305.Text != "305")
            {
                button305.BackColor = Color.SkyBlue;
            }
            //306
            SqlCommand komut23 = new SqlCommand("select * from Oda306", bgl.baglanti());
            SqlDataReader oku23 = komut23.ExecuteReader();
            while (oku23.Read())
            {
                button306.Text = oku23["OdaMusteriAd"].ToString() + "" + oku23["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button306.Text != "306")
            {
                button306.BackColor = Color.SkyBlue;
            }
            //307
            SqlCommand komut24 = new SqlCommand("select * from Oda307", bgl.baglanti());
            SqlDataReader oku24 = komut24.ExecuteReader();
            while (oku24.Read())
            {
                button307.Text = oku24["OdaMusteriAd"].ToString() + "" + oku24["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button307.Text != "307")
            {
                button307.BackColor = Color.SkyBlue;
            }
            //308
            SqlCommand komut25 = new SqlCommand("select * from Oda308", bgl.baglanti());
            SqlDataReader oku25 = komut25.ExecuteReader();
            while (oku25.Read())
            {
                button308.Text = oku25["OdaMusteriAd"].ToString() + "" + oku25["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button308.Text != "308")
            {
                button308.BackColor = Color.SkyBlue;
            }
            //309
            SqlCommand komut26 = new SqlCommand("select * from Oda309", bgl.baglanti());
            SqlDataReader oku26 = komut26.ExecuteReader();
            while (oku26.Read())
            {
                button309.Text = oku26["OdaMusteriAd"].ToString() + "" + oku26["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button309.Text != "309")
            {
                button309.BackColor = Color.SkyBlue;
            }
            //401
            SqlCommand komut27 = new SqlCommand("select * from Oda401", bgl.baglanti());
            SqlDataReader oku27 = komut27.ExecuteReader();
            while (oku27.Read())
            {
                button401.Text = oku27["OdaMusteriAd"].ToString() + "" + oku27["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button401.Text != "401")
            {
                button401.BackColor = Color.SkyBlue;
            }
            //402
            SqlCommand komut28 = new SqlCommand("select * from Oda402", bgl.baglanti());
            SqlDataReader oku28 = komut28.ExecuteReader();
            while (oku28.Read())
            {
                button402.Text = oku28["OdaMusteriAd"].ToString() + "" + oku28["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button402.Text != "402")
            {
                button402.BackColor = Color.SkyBlue;
            }
            //403
            SqlCommand komut29 = new SqlCommand("select * from Oda403", bgl.baglanti());
            SqlDataReader oku29 = komut29.ExecuteReader();
            while (oku29.Read())
            {
                button403.Text = oku29["OdaMusteriAd"].ToString() + "" + oku29["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button403.Text != "403")
            {
                button403.BackColor = Color.SkyBlue;
            }
            //404
            SqlCommand komut30 = new SqlCommand("select * from Oda404", bgl.baglanti());
            SqlDataReader oku30 = komut30.ExecuteReader();
            while (oku30.Read())
            {
                button404.Text = oku30["OdaMusteriAd"].ToString() + "" + oku30["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button404.Text != "404")
            {
                button404.BackColor = Color.SkyBlue;
            }
            //405
            SqlCommand komut31 = new SqlCommand("select * from Oda405", bgl.baglanti());
            SqlDataReader oku31 = komut31.ExecuteReader();
            while (oku31.Read())
            {
                button405.Text = oku31["OdaMusteriAd"].ToString() + "" + oku31["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button405.Text != "405")
            {
                button405.BackColor = Color.SkyBlue;
            }
            //406
            SqlCommand komut32 = new SqlCommand("select * from Oda406", bgl.baglanti());
            SqlDataReader oku32 = komut32.ExecuteReader();
            while (oku32.Read())
            {
                button406.Text = oku32["OdaMusteriAd"].ToString() + "" + oku32["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button406.Text != "406")
            {
                button406.BackColor = Color.SkyBlue;
            }
            //407
            SqlCommand komut33 = new SqlCommand("select * from Oda407", bgl.baglanti());
            SqlDataReader oku33 = komut33.ExecuteReader();
            while (oku33.Read())
            {
                button407.Text = oku33["OdaMusteriAd"].ToString() + "" + oku33["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button407.Text != "407")
            {
                button407.BackColor = Color.SkyBlue;
            }
            //408
            SqlCommand komut34 = new SqlCommand("select * from Oda408", bgl.baglanti());
            SqlDataReader oku34 = komut34.ExecuteReader();
            while (oku34.Read())
            {
                button408.Text = oku34["OdaMusteriAd"].ToString() + "" + oku34["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button408.Text != "408")
            {
                button408.BackColor = Color.SkyBlue;
            }
            //409
            SqlCommand komut35 = new SqlCommand("select * from Oda409", bgl.baglanti());
            SqlDataReader oku35 = komut35.ExecuteReader();
            while (oku35.Read())
            {
                button409.Text = oku35["OdaMusteriAd"].ToString() + "" + oku35["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button409.Text != "409")
            {
                button409.BackColor = Color.SkyBlue;
            }
            //501
            SqlCommand komut36 = new SqlCommand("select * from Oda501", bgl.baglanti());
            SqlDataReader oku36 = komut36.ExecuteReader();
            while (oku36.Read())
            {
                button501.Text = oku36["OdaMusteriAd"].ToString() + "" + oku36["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button501.Text != "501")
            {
                button501.BackColor = Color.SkyBlue;
            }
            //502
            SqlCommand komut37 = new SqlCommand("select * from Oda502", bgl.baglanti());
            SqlDataReader oku37 = komut37.ExecuteReader();
            while (oku37.Read())
            {
                button502.Text = oku37["OdaMusteriAd"].ToString() + "" + oku37["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button502.Text != "502")
            {
                button502.BackColor = Color.SkyBlue;
            }
            //503
            SqlCommand komut38 = new SqlCommand("select * from Oda503", bgl.baglanti());
            SqlDataReader oku38 = komut38.ExecuteReader();
            while (oku38.Read())
            {
                button503.Text = oku38["OdaMusteriAd"].ToString() + "" + oku38["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button503.Text != "503")
            {
                button503.BackColor = Color.SkyBlue;
            }
            //504
            SqlCommand komut39 = new SqlCommand("select * from Oda504", bgl.baglanti());
            SqlDataReader oku39 = komut39.ExecuteReader();
            while (oku39.Read())
            {
                button504.Text = oku39["OdaMusteriAd"].ToString() + "" + oku39["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button504.Text != "504")
            {
                button504.BackColor = Color.SkyBlue;
            }
            //505
            SqlCommand komut40 = new SqlCommand("select * from Oda505", bgl.baglanti());
            SqlDataReader oku40 = komut40.ExecuteReader();
            while (oku40.Read())
            {
                button505.Text = oku40["OdaMusteriAd"].ToString() + "" + oku40["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button505.Text != "505")
            {
                button505.BackColor = Color.SkyBlue;
            }
            //506
            SqlCommand komut41 = new SqlCommand("select * from Oda506", bgl.baglanti());
            SqlDataReader oku41 = komut41.ExecuteReader();
            while (oku41.Read())
            {
                button506.Text = oku41["OdaMusteriAd"].ToString() + "" + oku41["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button506.Text != "506")
            {
                button506.BackColor = Color.SkyBlue;
            }
            //507
            SqlCommand komut42 = new SqlCommand("select * from Oda507", bgl.baglanti());
            SqlDataReader oku42 = komut42.ExecuteReader();
            while (oku42.Read())
            {
                button507.Text = oku42["OdaMusteriAd"].ToString() + "" + oku42["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button507.Text != "507")
            {
                button507.BackColor = Color.SkyBlue;
            }
            //508
            SqlCommand komut43 = new SqlCommand("select * from Oda508", bgl.baglanti());
            SqlDataReader oku43 = komut43.ExecuteReader();
            while (oku43.Read())
            {
                button508.Text = oku43["OdaMusteriAd"].ToString() + "" + oku43["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button508.Text != "508")
            {
                button508.BackColor = Color.SkyBlue;
            }
            //509
            SqlCommand komut44 = new SqlCommand("select * from Oda509", bgl.baglanti());
            SqlDataReader oku44 = komut44.ExecuteReader();
            while (oku44.Read())
            {
                button509.Text = oku44["OdaMusteriAd"].ToString() + "" + oku44["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button509.Text != "509")
            {
                button509.BackColor = Color.SkyBlue;
            }
            //601
            SqlCommand komut45 = new SqlCommand("select * from Oda601", bgl.baglanti());
            SqlDataReader oku45 = komut45.ExecuteReader();
            while (oku45.Read())
            {
                button601.Text = oku45["OdaMusteriAd"].ToString() + "" + oku45["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button601.Text != "601")
            {
                button601.BackColor = Color.SkyBlue;
            }
            //602
            SqlCommand komut46 = new SqlCommand("select * from Oda602", bgl.baglanti());
            SqlDataReader oku46 = komut46.ExecuteReader();
            while (oku46.Read())
            {
                button602.Text = oku46["OdaMusteriAd"].ToString() + "" + oku46["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button602.Text != "602")
            {
                button602.BackColor = Color.SkyBlue;
            }
            //603
            SqlCommand komut47 = new SqlCommand("select * from Oda603", bgl.baglanti());
            SqlDataReader oku47 = komut47.ExecuteReader();
            while (oku47.Read())
            {
                button603.Text = oku47["OdaMusteriAd"].ToString() + "" + oku47["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button603.Text != "603")
            {
                button603.BackColor = Color.SkyBlue;
            }
            //604
            SqlCommand komut48 = new SqlCommand("select * from Oda604", bgl.baglanti());
            SqlDataReader oku48 = komut48.ExecuteReader();
            while (oku48.Read())
            {
                button604.Text = oku48["OdaMusteriAd"].ToString() + "" + oku48["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button604.Text != "604")
            {
                button604.BackColor = Color.SkyBlue;
            }
            //605
            SqlCommand komut49 = new SqlCommand("select * from Oda605", bgl.baglanti());
            SqlDataReader oku49 = komut49.ExecuteReader();
            while (oku49.Read())
            {
                button605.Text = oku49["OdaMusteriAd"].ToString() + "" + oku49["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button605.Text != "605")
            {
                button605.BackColor = Color.SkyBlue;
            }
            //606
            SqlCommand komut50 = new SqlCommand("select * from Oda606", bgl.baglanti());
            SqlDataReader oku50 = komut50.ExecuteReader();
            while (oku50.Read())
            {
                button606.Text = oku50["OdaMusteriAd"].ToString() + "" + oku50["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button606.Text != "606")
            {
                button606.BackColor = Color.SkyBlue;
            }
            //607
            SqlCommand komut51 = new SqlCommand("select * from Oda607", bgl.baglanti());
            SqlDataReader oku51 = komut51.ExecuteReader();
            while (oku51.Read())
            {
                button607.Text = oku51["OdaMusteriAd"].ToString() + "" + oku51["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button607.Text != "607")
            {
                button607.BackColor = Color.SkyBlue;
            }
            //608
            SqlCommand komut52 = new SqlCommand("select * from Oda608", bgl.baglanti());
            SqlDataReader oku52 = komut52.ExecuteReader();
            while (oku52.Read())
            {
                button608.Text = oku52["OdaMusteriAd"].ToString() + "" + oku52["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button608.Text != "608")
            {
                button608.BackColor = Color.SkyBlue;
            }
            //609
            SqlCommand komut53 = new SqlCommand("select * from Oda609", bgl.baglanti());
            SqlDataReader oku53 = komut53.ExecuteReader();
            while (oku53.Read())
            {
                button609.Text = oku53["OdaMusteriAd"].ToString() + "" + oku53["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button609.Text != "609")
            {
                button609.BackColor = Color.SkyBlue;
            }
            //701
            SqlCommand komut54 = new SqlCommand("select * from Oda701", bgl.baglanti());
            SqlDataReader oku54 = komut54.ExecuteReader();
            while (oku54.Read())
            {
                button701.Text = oku54["OdaMusteriAd"].ToString() + "" + oku54["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button701.Text != "701")
            {
                button701.BackColor = Color.SkyBlue;
            }
            //702
            SqlCommand komut55 = new SqlCommand("select * from Oda702", bgl.baglanti());
            SqlDataReader oku55 = komut55.ExecuteReader();
            while (oku55.Read())
            {
                button702.Text = oku55["OdaMusteriAd"].ToString() + "" + oku55["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button702.Text != "702")
            {
                button702.BackColor = Color.SkyBlue;
            }
            //703
            SqlCommand komut56 = new SqlCommand("select * from Oda703", bgl.baglanti());
            SqlDataReader oku56 = komut56.ExecuteReader();
            while (oku56.Read())
            {
                button703.Text = oku56["OdaMusteriAd"].ToString() + "" + oku56["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button703.Text != "703")
            {
                button703.BackColor = Color.SkyBlue;
            }
            //704
            SqlCommand komut57 = new SqlCommand("select * from Oda704", bgl.baglanti());
            SqlDataReader oku57 = komut57.ExecuteReader();
            while (oku57.Read())
            {
                button704.Text = oku57["OdaMusteriAd"].ToString() + "" + oku57["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button704.Text != "704")
            {
                button704.BackColor = Color.SkyBlue;
            }
            //705
            SqlCommand komut58 = new SqlCommand("select * from Oda705", bgl.baglanti());
            SqlDataReader oku58 = komut58.ExecuteReader();
            while (oku58.Read())
            {
                button705.Text = oku58["OdaMusteriAd"].ToString() + "" + oku58["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button705.Text != "705")
            {
                button705.BackColor = Color.SkyBlue;
            }
            //706
            SqlCommand komut59 = new SqlCommand("select * from Oda706", bgl.baglanti());
            SqlDataReader oku59 = komut59.ExecuteReader();
            while (oku59.Read())
            {
                button706.Text = oku59["OdaMusteriAd"].ToString() + "" + oku59["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button706.Text != "706")
            {
                button706.BackColor = Color.SkyBlue;
            }
            //707
            SqlCommand komut60 = new SqlCommand("select * from Oda707", bgl.baglanti());
            SqlDataReader oku60 = komut60.ExecuteReader();
            while (oku60.Read())
            {
                button707.Text = oku60["OdaMusteriAd"].ToString() + "" + oku60["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button707.Text != "707")
            {
                button707.BackColor = Color.SkyBlue;
            }
            //708
            SqlCommand komut61 = new SqlCommand("select * from Oda708", bgl.baglanti());
            SqlDataReader oku61 = komut61.ExecuteReader();
            while (oku61.Read())
            {
                button708.Text = oku61["OdaMusteriAd"].ToString() + "" + oku61["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button708.Text != "708")
            {
                button708.BackColor = Color.SkyBlue;
            }
            //709
            SqlCommand komut62 = new SqlCommand("select * from Oda709", bgl.baglanti());
            SqlDataReader oku62 = komut62.ExecuteReader();
            while (oku62.Read())
            {
                button709.Text = oku62["OdaMusteriAd"].ToString() + "" + oku62["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button709.Text != "709")
            {
                button709.BackColor = Color.SkyBlue;
            }
            //801
            SqlCommand komut63 = new SqlCommand("select * from Oda801", bgl.baglanti());
            SqlDataReader oku63 = komut63.ExecuteReader();
            while (oku63.Read())
            {
                button801.Text = oku63["OdaMusteriAd"].ToString() + "" + oku63["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button801.Text != "801")
            {
                button801.BackColor = Color.SkyBlue;
            }
            //802
            SqlCommand komut64 = new SqlCommand("select * from Oda802", bgl.baglanti());
            SqlDataReader oku64 = komut64.ExecuteReader();
            while (oku64.Read())
            {
                button802.Text = oku64["OdaMusteriAd"].ToString() + "" + oku64["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button802.Text != "802")
            {
                button802.BackColor = Color.SkyBlue;
            }
            //803
            SqlCommand komut65 = new SqlCommand("select * from Oda803", bgl.baglanti());
            SqlDataReader oku65 = komut65.ExecuteReader();
            while (oku65.Read())
            {
                button803.Text = oku65["OdaMusteriAd"].ToString() + "" + oku65["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button803.Text != "803")
            {
                button803.BackColor = Color.SkyBlue;
            }
            //804
            SqlCommand komut66 = new SqlCommand("select * from Oda804", bgl.baglanti());
            SqlDataReader oku66 = komut66.ExecuteReader();
            while (oku66.Read())
            {
                button804.Text = oku66["OdaMusteriAd"].ToString() + "" + oku66["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button804.Text != "804")
            {
                button804.BackColor = Color.SkyBlue;
            }
            //805
            SqlCommand komut67 = new SqlCommand("select * from Oda805", bgl.baglanti());
            SqlDataReader oku67 = komut67.ExecuteReader();
            while (oku67.Read())
            {
                button805.Text = oku67["OdaMusteriAd"].ToString() + "" + oku67["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button805.Text != "805")
            {
                button805.BackColor = Color.SkyBlue;
            }
            //806
            SqlCommand komut68 = new SqlCommand("select * from Oda806", bgl.baglanti());
            SqlDataReader oku68 = komut68.ExecuteReader();
            while (oku68.Read())
            {
                button806.Text = oku68["OdaMusteriAd"].ToString() + "" + oku68["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button806.Text != "806")
            {
                button806.BackColor = Color.SkyBlue;
            }
            //807
            SqlCommand komut69 = new SqlCommand("select * from Oda807", bgl.baglanti());
            SqlDataReader oku69 = komut69.ExecuteReader();
            while (oku69.Read())
            {
                button807.Text = oku69["OdaMusteriAd"].ToString() + "" + oku69["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button807.Text != "807")
            {
                button807.BackColor = Color.SkyBlue;
            }
            //808
            SqlCommand komut70 = new SqlCommand("select * from Oda808", bgl.baglanti());
            SqlDataReader oku70 = komut70.ExecuteReader();
            while (oku70.Read())
            {
                button808.Text = oku70["OdaMusteriAd"].ToString() + "" + oku70["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button808.Text != "808")
            {
                button808.BackColor = Color.SkyBlue;
            }
            //809
            SqlCommand komut71 = new SqlCommand("select * from Oda809", bgl.baglanti());
            SqlDataReader oku71 = komut71.ExecuteReader();
            while (oku71.Read())
            {
                button809.Text = oku71["OdaMusteriAd"].ToString() + "" + oku71["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button809.Text != "809")
            {
                button809.BackColor = Color.SkyBlue;
            }
            //901
            SqlCommand komut72 = new SqlCommand("select * from Oda901", bgl.baglanti());
            SqlDataReader oku72 = komut72.ExecuteReader();
            while (oku72.Read())
            {
                button901.Text = oku72["OdaMusteriAd"].ToString() + "" + oku72["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button901.Text != "901")
            {
                button901.BackColor = Color.SkyBlue;
            }
            //902
            SqlCommand komut73 = new SqlCommand("select * from Oda902", bgl.baglanti());
            SqlDataReader oku73 = komut73.ExecuteReader();
            while (oku73.Read())
            {
                button902.Text = oku73["OdaMusteriAd"].ToString() + "" + oku73["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button902.Text != "902")
            {
                button902.BackColor = Color.SkyBlue;
            }
            //903
            SqlCommand komut74 = new SqlCommand("select * from Oda903", bgl.baglanti());
            SqlDataReader oku74 = komut74.ExecuteReader();
            while (oku74.Read())
            {
                button903.Text = oku74["OdaMusteriAd"].ToString() + "" + oku74["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button903.Text != "903")
            {
                button903.BackColor = Color.SkyBlue;
            }
            //904
            SqlCommand komut75 = new SqlCommand("select * from Oda904", bgl.baglanti());
            SqlDataReader oku75 = komut75.ExecuteReader();
            while (oku75.Read())
            {
                button904.Text = oku75["OdaMusteriAd"].ToString() + "" + oku75["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button904.Text != "904")
            {
                button904.BackColor = Color.SkyBlue;
            }
            //905
            SqlCommand komut76 = new SqlCommand("select * from Oda905", bgl.baglanti());
            SqlDataReader oku76 = komut76.ExecuteReader();
            while (oku76.Read())
            {
                button905.Text = oku76["OdaMusteriAd"].ToString() + "" + oku76["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button905.Text != "905")
            {
                button905.BackColor = Color.SkyBlue;
            }
            //906
            SqlCommand komut77 = new SqlCommand("select * from Oda906", bgl.baglanti());
            SqlDataReader oku77 = komut77.ExecuteReader();
            while (oku77.Read())
            {
                button906.Text = oku77["OdaMusteriAd"].ToString() + "" + oku77["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button906.Text != "906")
            {
                button906.BackColor = Color.SkyBlue;
            }
            //907
            SqlCommand komut78 = new SqlCommand("select * from Oda907", bgl.baglanti());
            SqlDataReader oku78 = komut78.ExecuteReader();
            while (oku78.Read())
            {
                button907.Text = oku78["OdaMusteriAd"].ToString() + "" + oku78["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button907.Text != "907")
            {
                button907.BackColor = Color.SkyBlue;
            }
            //908
            SqlCommand komut79 = new SqlCommand("select * from Oda908", bgl.baglanti());
            SqlDataReader oku79 = komut79.ExecuteReader();
            while (oku79.Read())
            {
                button908.Text = oku79["OdaMusteriAd"].ToString() + "" + oku79["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button908.Text != "908")
            {
                button908.BackColor = Color.SkyBlue;
            }
            //909
            SqlCommand komut80 = new SqlCommand("select * from Oda909", bgl.baglanti());
            SqlDataReader oku80 = komut80.ExecuteReader();
            while (oku80.Read())
            {
                button909.Text = oku80["OdaMusteriAd"].ToString() + "" + oku80["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button909.Text != "909")
            {
                button909.BackColor = Color.SkyBlue;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlCommand kmdkaydet = new SqlCommand("insert into Rezervasyon(RezervasyonSahibiTC,RezervasyonSahibiAd,RezervasyonSahibiSoyad,RezervasyonSahibiMail,RezervasyonSahibiTelefon,RezervasyonOdaNo,RezervasyonBaslangicTarihi,RezervasyonBitisTarihi,Odeme) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9)", bgl.baglanti());
            kmdkaydet.Parameters.AddWithValue("@s1", maskedTextBoxMusteriTc.Text);
            kmdkaydet.Parameters.AddWithValue("@s2", textBoxMusteriAd.Text);
            kmdkaydet.Parameters.AddWithValue("@s3", textBoxMusteriSoyad.Text);
            kmdkaydet.Parameters.AddWithValue("@s4", textBoxMusteriMail.Text);
            kmdkaydet.Parameters.AddWithValue("@s5", maskedTextBoxMusteriTelefon.Text);
            kmdkaydet.Parameters.AddWithValue("@s6", comboBoxMusteriOdaNo.Text);
            kmdkaydet.Parameters.AddWithValue("@s7", dateTimePickerBaslangic.Text);
            kmdkaydet.Parameters.AddWithValue("@s8", dateTimePickerBitis.Text);
            kmdkaydet.Parameters.AddWithValue("@s9", textBoxOdenecekTutar.Text);
            kmdkaydet.ExecuteNonQuery();

            bgl.baglanti().Close();

            //Kredi borc alanı oluşturma
            SqlCommand komut = new SqlCommand("insert into OdemeKredi (MusteriTC,MusteriAd,MusteriSoyad,Odeme) values (@a1,@a2,@a3,@a4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", maskedTextBoxMusteriTc.Text);
            komut.Parameters.AddWithValue("@a2", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@a3", textBoxMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@a4", textBoxOdenecekTutar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rezervasyonunuz Kaydedilmiştir");

            //Nakit borç alanı oluşturma
            SqlCommand komutnakit = new SqlCommand("insert into OdemeNakit (MusteriID,MusteriAd,MusteriSoyad,OdenecekTutar) values (@b1,@b2,@b3,@b4)", bgl.baglanti());
            komutnakit.Parameters.AddWithValue("@b1", textBoxRezervasyonID.Text);
            komutnakit.Parameters.AddWithValue("@b2", textBoxMusteriAd.Text);
            komutnakit.Parameters.AddWithValue("@b3", textBoxMusteriSoyad.Text);
            komutnakit.Parameters.AddWithValue("@b4", textBoxOdenecekTutar.Text);
            komutnakit.ExecuteNonQuery();
            bgl.baglanti().Close();


            //Oda Kontenjanı Azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNumarası=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", comboBoxMusteriOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

            //  Rezervasyon ID textboxa Çekilmesi
            SqlCommand komutıd = new SqlCommand("select RezervasyonID from Rezervasyon", bgl.baglanti());
            SqlDataReader okuıd = komutıd.ExecuteReader();
            while (okuıd.Read())
            {
                textBoxRezervasyonID.Text = okuıd[0].ToString();
            }
            bgl.baglanti().Close();

        }

        private void dateTimePickerBitis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePickerBaslangic.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePickerBitis.Text);

            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;

            label2.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label2.Text) * 750;//Buraya odalar tablosundan fiyat okuması eklenecek.!!
            textBoxOdenecekTutar.Text = ucret.ToString();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ÖdemeKredi fs = new ÖdemeKredi();
            fs.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBoxRezervasyonID.Clear();
            maskedTextBoxMusteriTc.Clear();
            textBoxMusteriAd.Clear();
            textBoxMusteriSoyad.Clear();
            textBoxMusteriMail.Clear();
            maskedTextBoxMusteriTelefon.Clear();
            dateTimePickerBaslangic.Text = "";
            dateTimePickerBitis.Text = "";

        }


        private void button101_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "101";

            SqlCommand komut101 = new SqlCommand("insert into Oda101(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut101.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut101.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut101.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void button102_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "102";

            SqlCommand komut102 = new SqlCommand("insert into Oda102(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut102.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut102.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut102.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "103";

            SqlCommand komut103 = new SqlCommand("insert into Oda103(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut103.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut103.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut103.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "104";

            SqlCommand komut104 = new SqlCommand("insert into Oda104(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut104.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut104.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut104.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "105";

            SqlCommand komut105 = new SqlCommand("insert into Oda105(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut105.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut105.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut105.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "106";

            SqlCommand komut106 = new SqlCommand("insert into Oda106(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut106.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut106.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut106.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button107_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "107";

            SqlCommand komut107 = new SqlCommand("insert into Oda107(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut107.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut107.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut107.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "108";

            SqlCommand komut108 = new SqlCommand("insert into Oda108(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut108.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut108.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut108.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "109";

            SqlCommand komut109 = new SqlCommand("insert into Oda109(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut109.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut109.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut109.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button201_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "201";
            SqlCommand komut201 = new SqlCommand("insert into Oda201(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut201.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut201.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut201.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button202_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "202";

            SqlCommand komut202 = new SqlCommand("insert into Oda202(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut202.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut202.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut202.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button203_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "203";

            SqlCommand komut203 = new SqlCommand("insert into Oda203(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut203.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut203.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut203.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button204_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "204";

            SqlCommand komut204 = new SqlCommand("insert into Oda204(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut204.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut204.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut204.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button205_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "205";
            SqlCommand komut205 = new SqlCommand("insert into Oda205(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut205.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut205.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut205.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button206_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "206";

            SqlCommand komut206 = new SqlCommand("insert into Oda206(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut206.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut206.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut206.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button207_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "207";

            SqlCommand komut207 = new SqlCommand("insert into Oda207(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut207.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut207.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut207.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button208_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "208";

            SqlCommand komut208 = new SqlCommand("insert into Oda208(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut208.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut208.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut208.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button209_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "209";
            SqlCommand komut209 = new SqlCommand("insert into Oda209(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut209.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut209.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut209.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button301_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "301";
            SqlCommand komut301 = new SqlCommand("insert into Oda301(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut301.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut301.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut301.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void button302_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "302";

            SqlCommand komut302 = new SqlCommand("insert into Oda302(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut302.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut302.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut302.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button303_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "303";
            SqlCommand komut303 = new SqlCommand("insert into Oda303(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut303.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut303.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut303.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button304_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "304";
            SqlCommand komut304 = new SqlCommand("insert into Oda304(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut304.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut304.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut304.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button305_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "305";
            SqlCommand komut305 = new SqlCommand("insert into Oda305(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut305.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut305.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut305.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button306_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "306";

            SqlCommand komut306 = new SqlCommand("insert into Oda306(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut306.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut306.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut306.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button307_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "307";

            SqlCommand komut307 = new SqlCommand("insert into Oda307(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut307.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut307.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut307.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button308_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "308";

            SqlCommand komut308 = new SqlCommand("insert into Oda308(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut308.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut308.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut308.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button309_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "309";
            SqlCommand komut309 = new SqlCommand("insert into Oda309(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut309.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut309.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut309.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button401_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "401";
            SqlCommand komut401 = new SqlCommand("insert into Oda401(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut401.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut401.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut401.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button402_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "402";
            SqlCommand komut402 = new SqlCommand("insert into Oda402(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut402.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut402.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut402.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button403_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "403";
            SqlCommand komut403 = new SqlCommand("insert into Oda403(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut403.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut403.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut403.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button404_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "404";
            SqlCommand komut404 = new SqlCommand("insert into Oda404(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut404.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut404.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut404.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button405_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "405";
            SqlCommand komut405 = new SqlCommand("insert into Oda405(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut405.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut405.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut405.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button406_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "406";
            SqlCommand komut406 = new SqlCommand("insert into Oda406(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut406.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut406.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut406.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "407";
            SqlCommand komut407 = new SqlCommand("insert into Oda407(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut407.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut407.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut407.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button408_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "408";
            SqlCommand komut408 = new SqlCommand("insert into Oda408(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut408.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut408.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut408.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button409_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "409";
            SqlCommand komut409 = new SqlCommand("insert into Oda409(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut409.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut409.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut409.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button501_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "501";
            SqlCommand komut501 = new SqlCommand("insert into Oda501(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut501.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut501.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut501.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button502_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "502";
            SqlCommand komut502 = new SqlCommand("insert into Oda502(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut502.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut502.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut502.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button503_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "503";
            SqlCommand komut503 = new SqlCommand("insert into Oda50(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut503.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut503.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut503.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button504_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "504";
            SqlCommand komut504 = new SqlCommand("insert into Oda504(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut504.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut504.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut504.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button505_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "505";
            SqlCommand komut505 = new SqlCommand("insert into Oda505(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut505.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut505.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut505.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button506_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "506";
            SqlCommand komut506 = new SqlCommand("insert into Oda506(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut506.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut506.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut506.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button507_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "507";
            SqlCommand komut507 = new SqlCommand("insert into Oda507(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut507.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut507.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut507.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button508_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "508";
            SqlCommand komut508 = new SqlCommand("insert into Oda508(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut508.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut508.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut508.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button509_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "509";
            SqlCommand komut509= new SqlCommand("insert into Oda509(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut509.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut509.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut509.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button601_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "601";
            SqlCommand komut601 = new SqlCommand("insert into Oda601(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut601.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut601.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut601.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button602_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "602";
            SqlCommand komut602 = new SqlCommand("insert into Oda602(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut602.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut602.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut602.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button603_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "603";
            SqlCommand komut603 = new SqlCommand("insert into Oda603(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut603.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut603.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut603.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button604_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "604";
            SqlCommand komut604= new SqlCommand("insert into Oda604(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut604.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut604.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut604.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button605_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "605";
            SqlCommand komut605 = new SqlCommand("insert into Oda605(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut605.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut605.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut605.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button606_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "606";
            SqlCommand komut606 = new SqlCommand("insert into Oda606(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut606.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut606.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut606.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button607_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "607";
            SqlCommand komut607 = new SqlCommand("insert into Oda607(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut607.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut607.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut607.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button608_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "608";
            SqlCommand komut608 = new SqlCommand("insert into Oda608(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut608.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut608.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut608.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button609_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "609";
            SqlCommand komut609 = new SqlCommand("insert into Oda609(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut609.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut609.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut609.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button701_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "701";
            SqlCommand komut701 = new SqlCommand("insert into Oda701(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut701.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut701.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut701.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button702_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "702";
            SqlCommand komut702 = new SqlCommand("insert into Oda702(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut702.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut702.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut702.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button703_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "703";
            SqlCommand komut703 = new SqlCommand("insert into Oda703(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut703.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut703.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut703.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button704_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "704";
            SqlCommand komut704 = new SqlCommand("insert into Oda704(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut704.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut704.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut704.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button705_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "705";
            SqlCommand komut705 = new SqlCommand("insert into Oda705(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut705.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut705.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut705.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button706_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "706";
            SqlCommand komut706 = new SqlCommand("insert into Oda706(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut706.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut706.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut706.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button707_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "707";
            SqlCommand komut707 = new SqlCommand("insert into Oda707(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut707.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut707.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut707.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button708_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "708";
            SqlCommand komut708 = new SqlCommand("insert into Oda708(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut708.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut708.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut708.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button709_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "709";
            SqlCommand komut709 = new SqlCommand("insert into Oda709(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut709.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut709.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut709.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button801_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "801";
            SqlCommand komut801 = new SqlCommand("insert into Oda801(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut801.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut801.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut801.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button802_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "802";
            SqlCommand komut802 = new SqlCommand("insert into Oda802(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut802.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut802.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut802.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button803_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "803";
            SqlCommand komut803 = new SqlCommand("insert into Oda803(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut803.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut803.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut803.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button804_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "804";
            SqlCommand komut804 = new SqlCommand("insert into Oda804(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut804.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut804.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut804.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button805_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "805";
            SqlCommand komut805 = new SqlCommand("insert into Oda805(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut805.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut805.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut805.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button806_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "806";
            SqlCommand komut806 = new SqlCommand("insert into Oda806(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut806.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut806.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut806.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button807_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "807";
            SqlCommand komut807 = new SqlCommand("insert into Oda807(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut807.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut807.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut807.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void button808_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "808";
            SqlCommand komut808 = new SqlCommand("insert into Oda808(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut808.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut808.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut808.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button809_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "809";
            SqlCommand komut809 = new SqlCommand("insert into Oda809(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut809.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut809.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut809.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button901_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "901";
            SqlCommand komut901 = new SqlCommand("insert into Oda901(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut901.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut901.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut901.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button902_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "902";
            SqlCommand komut902 = new SqlCommand("insert into Oda902(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut902.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut902.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut902.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button903_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "903";
            SqlCommand komut903 = new SqlCommand("insert into Oda903(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut903.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut903.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut903.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button904_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "904";
            SqlCommand komut904 = new SqlCommand("insert into Oda904(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut904.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut904.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut904.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button905_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "905";
            SqlCommand komut905 = new SqlCommand("insert into Oda905(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut905.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut905.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut905.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button906_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "906";
            SqlCommand komut906 = new SqlCommand("insert into Oda906(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut906.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut906.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut906.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button907_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "907";
            SqlCommand komut907 = new SqlCommand("insert into Oda907(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut907.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut907.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut907.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button908_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "908";
            SqlCommand komut908 = new SqlCommand("insert into Oda908(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut908.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut908.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut908.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button909_Click(object sender, EventArgs e)
        {
            comboBoxMusteriOdaNo.Text = "909";
            SqlCommand komut909 = new SqlCommand("insert into Oda909(OdaMusteriAd,OdaMusteriSoyad) values (@h1,@h2)", bgl.baglanti());
            komut909.Parameters.AddWithValue("@h1", textBoxMusteriAd.Text);
            komut909.Parameters.AddWithValue("@h2", textBoxMusteriSoyad.Text);
            komut909.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ÖdemeNakit fx = new ÖdemeNakit();
            fx.Show();

        }

        
    }
}
