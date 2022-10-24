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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            //101
            SqlCommand komut = new SqlCommand("select * from Oda101",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                button101.Text = oku["OdaMusteriAd"].ToString() + " " + oku["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button101.Text != "101")
            {
                button101.BackColor = Color.SkyBlue;
                button101.Enabled = false;
            }
            //102
            SqlCommand komut1 = new SqlCommand("select * from Oda102", bgl.baglanti());
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button102.Text = oku1["OdaMusteriAd"].ToString() + " " + oku1["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button102.Text != "102")
            {
                button102.BackColor = Color.SkyBlue;
                button102.Enabled = false;
            }
            //103
            SqlCommand komut2 = new SqlCommand("select * from Oda103", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button103.Text = oku2["OdaMusteriAd"].ToString() + " " + oku2["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button103.Text != "103")
            {
                button103.BackColor = Color.SkyBlue;
                button103.Enabled = false;
            }
            //104
            SqlCommand komut3 = new SqlCommand("select * from Oda104", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button104.Text = oku3["OdaMusteriAd"].ToString() + " " + oku3["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button104.Text != "104")
            {
                button104.BackColor = Color.SkyBlue;
                button104.Enabled = false;
            }
            //105
            SqlCommand komut4 = new SqlCommand("select * from Oda105", bgl.baglanti());
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button105.Text = oku4["OdaMusteriAd"].ToString() + " " + oku4["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button105.Text != "105")
            {
                button105.BackColor = Color.SkyBlue;
                button105.Enabled = false;

            }
            //106
            SqlCommand komut5 = new SqlCommand("select * from Oda106", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button106.Text = oku5["OdaMusteriAd"].ToString() + " " + oku5["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button106.Text != "106")
            {
                button106.BackColor = Color.SkyBlue;
                button106.Enabled = false;
            }
            //107
            SqlCommand komut6 = new SqlCommand("select * from Oda107", bgl.baglanti());
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button107.Text = oku6["OdaMusteriAd"].ToString() + " " + oku6["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button107.Text != "107")
            {
                button107.BackColor = Color.SkyBlue;
                button107.Enabled = false;
            }
            //108
            SqlCommand komut7 = new SqlCommand("select * from Oda108", bgl.baglanti());
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                button108.Text = oku7["OdaMusteriAd"].ToString() + " " + oku7["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button108.Text != "108")
            {
                button108.BackColor = Color.SkyBlue;
                button108.Enabled = false;
            }
            //109
            SqlCommand komut8 = new SqlCommand("select * from Oda109", bgl.baglanti());
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                button109.Text = oku8["OdaMusteriAd"].ToString() + " " + oku8["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button109.Text != "109")
            {
                button109.BackColor = Color.SkyBlue;
                button109.Enabled = false;
            }
            //201
            SqlCommand komut9 = new SqlCommand("select * from Oda201", bgl.baglanti());
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                button201.Text = oku9["OdaMusteriAd"].ToString() + " " + oku9["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button201.Text != "201")
            {
                button201.BackColor = Color.SkyBlue;
                button201.Enabled = false;
            }
            //202
            SqlCommand komut10 = new SqlCommand("select * from Oda202", bgl.baglanti());
            SqlDataReader oku10 = komut10.ExecuteReader();
            while (oku10.Read())
            {
                button202.Text = oku10["OdaMusteriAd"].ToString() + " " + oku10["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button202.Text != "202")
            {
                button202.BackColor = Color.SkyBlue;
                button202.Enabled = false;
            }
            //203
            SqlCommand komut11 = new SqlCommand("select * from Oda203", bgl.baglanti());
            SqlDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                button203.Text = oku11["OdaMusteriAd"].ToString() + " " + oku11["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button203.Text != "203")
            {
                button203.BackColor = Color.SkyBlue;
                button203.Enabled = false;
            }
            //204
            SqlCommand komut12 = new SqlCommand("select * from Oda204", bgl.baglanti());
            SqlDataReader oku12 = komut12.ExecuteReader();
            while (oku12.Read())
            {
                button204.Text = oku12["OdaMusteriAd"].ToString() + " " + oku12["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button204.Text != "204")
            {
                button204.BackColor = Color.SkyBlue;
                button204.Enabled = false;
            }
            //205
            SqlCommand komut13 = new SqlCommand("select * from Oda205", bgl.baglanti());
            SqlDataReader oku13 = komut13.ExecuteReader();
            while (oku13.Read())
            {
                button205.Text = oku13["OdaMusteriAd"].ToString() + " " + oku13["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button205.Text != "205")
            {
                button205.BackColor = Color.SkyBlue;
                button205.Enabled = false;
            }
            //206
            SqlCommand komut14 = new SqlCommand("select * from Oda206", bgl.baglanti());
            SqlDataReader oku14 = komut14.ExecuteReader();
            while (oku14.Read())
            {
                button203.Text = oku14["OdaMusteriAd"].ToString() + " " + oku14["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button206.Text != "206")
            {
                button206.BackColor = Color.SkyBlue;
                button206.Enabled = false;
            }
            //207
            SqlCommand komut15 = new SqlCommand("select * from Oda207", bgl.baglanti());
            SqlDataReader oku15 = komut15.ExecuteReader();
            while (oku15.Read())
            {
                button207.Text = oku15["OdaMusteriAd"].ToString() + " " + oku15["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button207.Text != "207")
            {
                button207.BackColor = Color.SkyBlue;
                button207.Enabled = false;
            }
            //208
            SqlCommand komut16 = new SqlCommand("select * from Oda208", bgl.baglanti());
            SqlDataReader oku16 = komut16.ExecuteReader();
            while (oku16.Read())
            {
                button208.Text = oku16["OdaMusteriAd"].ToString() + " " + oku16["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button208.Text != "208")
            {
                button208.BackColor = Color.SkyBlue;
                button208.Enabled = false;
            }
            //209
            SqlCommand komut17 = new SqlCommand("select * from Oda209", bgl.baglanti());
            SqlDataReader oku17 = komut17.ExecuteReader();
            while (oku17.Read())
            {
                button209.Text = oku17["OdaMusteriAd"].ToString() + " " + oku17["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button209.Text != "209")
            {
                button209.BackColor = Color.SkyBlue;
                button209.Enabled = false;

            }
            //301
            SqlCommand komut18 = new SqlCommand("select * from Oda301", bgl.baglanti());
            SqlDataReader oku18 = komut18.ExecuteReader();
            while (oku18.Read())
            {
                button301.Text = oku18["OdaMusteriAd"].ToString() + " " + oku18["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button301.Text != "301")
            {
                button301.BackColor = Color.SkyBlue;
                button301.Enabled = false;
            }
            //302
            SqlCommand komut19 = new SqlCommand("select * from Oda302", bgl.baglanti());
            SqlDataReader oku19 = komut19.ExecuteReader();
            while (oku19.Read())
            {
                button302.Text = oku19["OdaMusteriAd"].ToString() + " " + oku19["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button302.Text != "302")
            {
                button302.BackColor = Color.SkyBlue;
                button302.Enabled = false;
            }
            //303
            SqlCommand komut20 = new SqlCommand("select * from Oda303", bgl.baglanti());
            SqlDataReader oku20 = komut20.ExecuteReader();
            while (oku20.Read())
            {
                button303.Text = oku20["OdaMusteriAd"].ToString() + " " + oku20["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button303.Text != "303")
            {
                button303.BackColor = Color.SkyBlue;
                button303.Enabled = false;
            }
            //304
            SqlCommand komut21 = new SqlCommand("select * from Oda304", bgl.baglanti());
            SqlDataReader oku21 = komut21.ExecuteReader();
            while (oku21.Read())
            {
                button304.Text = oku21["OdaMusteriAd"].ToString() + " " + oku21["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button304.Text != "304")
            {
                button304.BackColor = Color.SkyBlue;
                button304.Enabled = false;
            }
            //305
            SqlCommand komut22 = new SqlCommand("select * from Oda305", bgl.baglanti());
            SqlDataReader oku22 = komut22.ExecuteReader();
            while (oku22.Read())
            {
                button305.Text = oku22["OdaMusteriAd"].ToString() + " " + oku22["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button305.Text != "305")
            {
                button305.BackColor = Color.SkyBlue;
                button305.Enabled = false;
            }
            //306
            SqlCommand komut23 = new SqlCommand("select * from Oda306", bgl.baglanti());
            SqlDataReader oku23 = komut23.ExecuteReader();
            while (oku23.Read())
            {
                button306.Text = oku23["OdaMusteriAd"].ToString() + " " + oku23["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button306.Text != "306")
            {
                button306.BackColor = Color.SkyBlue;
                button306.Enabled = false;
            }
            //307
            SqlCommand komut24 = new SqlCommand("select * from Oda307", bgl.baglanti());
            SqlDataReader oku24 = komut24.ExecuteReader();
            while (oku24.Read())
            {
                button307.Text = oku24["OdaMusteriAd"].ToString() + " " + oku24["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button307.Text != "307")
            {
                button307.BackColor = Color.SkyBlue;
                button307.Enabled = false;
            }
            //308
            SqlCommand komut25 = new SqlCommand("select * from Oda308", bgl.baglanti());
            SqlDataReader oku25 = komut25.ExecuteReader();
            while (oku25.Read())
            {
                button308.Text = oku25["OdaMusteriAd"].ToString() + " " + oku25["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button308.Text != "308")
            {
                button308.BackColor = Color.SkyBlue;
                button308.Enabled = false;
            }
            //309
            SqlCommand komut26 = new SqlCommand("select * from Oda309", bgl.baglanti());
            SqlDataReader oku26 = komut26.ExecuteReader();
            while (oku26.Read())
            {
                button309.Text = oku26["OdaMusteriAd"].ToString() + " " + oku26["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button309.Text != "309")
            {
                button309.BackColor = Color.SkyBlue;
                button309.Enabled = false;
            }
            //401
            SqlCommand komut27 = new SqlCommand("select * from Oda401", bgl.baglanti());
            SqlDataReader oku27 = komut27.ExecuteReader();
            while (oku27.Read())
            {
                button401.Text = oku27["OdaMusteriAd"].ToString() + " " + oku27["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button401.Text != "401")
            {
                button401.BackColor = Color.SkyBlue;
                button401.Enabled = false;
            }
            //402
            SqlCommand komut28 = new SqlCommand("select * from Oda402", bgl.baglanti());
            SqlDataReader oku28 = komut28.ExecuteReader();
            while (oku28.Read())
            {
                button402.Text = oku28["OdaMusteriAd"].ToString() + " " + oku28["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button402.Text != "402")
            {
                button402.BackColor = Color.SkyBlue;
                button402.Enabled = false;
            }
            //403
            SqlCommand komut29 = new SqlCommand("select * from Oda403", bgl.baglanti());
            SqlDataReader oku29 = komut29.ExecuteReader();
            while (oku29.Read())
            {
                button403.Text = oku29["OdaMusteriAd"].ToString() + " " + oku29["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button403.Text != "403")
            {
                button403.BackColor = Color.SkyBlue;
                button403.Enabled = false;
            }
            //404
            SqlCommand komut30 = new SqlCommand("select * from Oda404", bgl.baglanti());
            SqlDataReader oku30 = komut30.ExecuteReader();
            while (oku30.Read())
            {
                button404.Text = oku30["OdaMusteriAd"].ToString() + " " + oku30["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button404.Text != "404")
            {
                button404.BackColor = Color.SkyBlue;
                button404.Enabled = false;
            }
            //405
            SqlCommand komut31 = new SqlCommand("select * from Oda405", bgl.baglanti());
            SqlDataReader oku31 = komut31.ExecuteReader();
            while (oku31.Read())
            {
                button405.Text = oku31["OdaMusteriAd"].ToString() + " " + oku31["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button405.Text != "405")
            {
                button405.BackColor = Color.SkyBlue;
                button405.Enabled = false;
            }
            //406
            SqlCommand komut32 = new SqlCommand("select * from Oda406", bgl.baglanti());
            SqlDataReader oku32 = komut32.ExecuteReader();
            while (oku32.Read())
            {
                button406.Text = oku32["OdaMusteriAd"].ToString() + " " + oku32["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button406.Text != "406")
            {
                button406.BackColor = Color.SkyBlue;
                button406.Enabled = false;
            }
            //407
            SqlCommand komut33 = new SqlCommand("select * from Oda407", bgl.baglanti());
            SqlDataReader oku33 = komut33.ExecuteReader();
            while (oku33.Read())
            {
                button407.Text = oku33["OdaMusteriAd"].ToString() + " " + oku33["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button407.Text != "407")
            {
                button407.BackColor = Color.SkyBlue;
                button407.Enabled = false;
            }
            //408
            SqlCommand komut34 = new SqlCommand("select * from Oda408", bgl.baglanti());
            SqlDataReader oku34 = komut34.ExecuteReader();
            while (oku34.Read())
            {
                button408.Text = oku34["OdaMusteriAd"].ToString() + " " + oku34["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button408.Text != "408")
            {
                button408.BackColor = Color.SkyBlue;
                button408.Enabled = false;
            }
            //409
            SqlCommand komut35 = new SqlCommand("select * from Oda409", bgl.baglanti());
            SqlDataReader oku35 = komut35.ExecuteReader();
            while (oku35.Read())
            {
                button409.Text = oku35["OdaMusteriAd"].ToString() + " " + oku35["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button409.Text != "409")
            {
                button409.BackColor = Color.SkyBlue;
                button409.Enabled = false;
            }
            //501
            SqlCommand komut36 = new SqlCommand("select * from Oda501", bgl.baglanti());
            SqlDataReader oku36 = komut36.ExecuteReader();
            while (oku36.Read())
            {
                button501.Text = oku36["OdaMusteriAd"].ToString() + " " + oku36["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button501.Text != "501")
            {
                button501.BackColor = Color.SkyBlue;
                button501.Enabled = false;
            }
            //502
            SqlCommand komut37 = new SqlCommand("select * from Oda502", bgl.baglanti());
            SqlDataReader oku37 = komut37.ExecuteReader();
            while (oku37.Read())
            {
                button502.Text = oku37["OdaMusteriAd"].ToString() + " " + oku37["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button502.Text != "502")
            {
                button502.BackColor = Color.SkyBlue;
                button502.Enabled = false;
            }
            //503
            SqlCommand komut38 = new SqlCommand("select * from Oda503", bgl.baglanti());
            SqlDataReader oku38 = komut38.ExecuteReader();
            while (oku38.Read())
            {
                button503.Text = oku38["OdaMusteriAd"].ToString() + " " + oku38["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button503.Text != "503")
            {
                button503.BackColor = Color.SkyBlue;
                button503.Enabled = false;
            }
            //504
            SqlCommand komut39 = new SqlCommand("select * from Oda504", bgl.baglanti());
            SqlDataReader oku39 = komut39.ExecuteReader();
            while (oku39.Read())
            {
                button504.Text = oku39["OdaMusteriAd"].ToString() + " " + oku39["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button504.Text != "504")
            {
                button504.BackColor = Color.SkyBlue;
                button504.Enabled = false;
            }
            //505
            SqlCommand komut40 = new SqlCommand("select * from Oda505", bgl.baglanti());
            SqlDataReader oku40 = komut40.ExecuteReader();
            while (oku40.Read())
            {
                button505.Text = oku40["OdaMusteriAd"].ToString() + " " + oku40["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button505.Text != "505")
            {
                button505.BackColor = Color.SkyBlue;
                button505.Enabled = false;
            }
            //506
            SqlCommand komut41 = new SqlCommand("select * from Oda506", bgl.baglanti());
            SqlDataReader oku41 = komut41.ExecuteReader();
            while (oku41.Read())
            {
                button506.Text = oku41["OdaMusteriAd"].ToString() + " " + oku41["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button506.Text != "506")
            {
                button506.BackColor = Color.SkyBlue;
                button506.Enabled = false;
            }
            //507
            SqlCommand komut42 = new SqlCommand("select * from Oda507", bgl.baglanti());
            SqlDataReader oku42 = komut42.ExecuteReader();
            while (oku42.Read())
            {
                button507.Text = oku42["OdaMusteriAd"].ToString() + " " + oku42["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button507.Text != "507")
            {
                button507.BackColor = Color.SkyBlue;
                button507.Enabled = false;
            }
            //508
            SqlCommand komut43 = new SqlCommand("select * from Oda508", bgl.baglanti());
            SqlDataReader oku43 = komut43.ExecuteReader();
            while (oku43.Read())
            {
                button508.Text = oku43["OdaMusteriAd"].ToString() + " " + oku43["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button508.Text != "508")
            {
                button508.BackColor = Color.SkyBlue;
                button508.Enabled = false;

            }
            //509
            SqlCommand komut44 = new SqlCommand("select * from Oda509", bgl.baglanti());
            SqlDataReader oku44 = komut44.ExecuteReader();
            while (oku44.Read())
            {
                button509.Text = oku44["OdaMusteriAd"].ToString() + " " + oku44["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button509.Text != "509")
            {
                button509.BackColor = Color.SkyBlue;
                button509.Enabled = false;
            }
            //601
            SqlCommand komut45 = new SqlCommand("select * from Oda601", bgl.baglanti());
            SqlDataReader oku45 = komut45.ExecuteReader();
            while (oku45.Read())
            {
                button601.Text = oku45["OdaMusteriAd"].ToString() + " " + oku45["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button601.Text != "601")
            {
                button601.BackColor = Color.SkyBlue;
                button601.Enabled = false;
            }
            //602
            SqlCommand komut46 = new SqlCommand("select * from Oda602", bgl.baglanti());
            SqlDataReader oku46 = komut46.ExecuteReader();
            while (oku46.Read())
            {
                button602.Text = oku46["OdaMusteriAd"].ToString() + " " + oku46["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button602.Text != "602")
            {
                button602.BackColor = Color.SkyBlue;
                button602.Enabled = false;
            }
            //603
            SqlCommand komut47 = new SqlCommand("select * from Oda603", bgl.baglanti());
            SqlDataReader oku47 = komut47.ExecuteReader();
            while (oku47.Read())
            {
                button603.Text = oku47["OdaMusteriAd"].ToString() + " " + oku47["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button603.Text != "603")
            {
                button603.BackColor = Color.SkyBlue;
                button603.Enabled = false;
            }
            //604
            SqlCommand komut48 = new SqlCommand("select * from Oda604", bgl.baglanti());
            SqlDataReader oku48 = komut48.ExecuteReader();
            while (oku48.Read())
            {
                button604.Text = oku48["OdaMusteriAd"].ToString() + " " + oku48["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button604.Text != "604")
            {
                button604.BackColor = Color.SkyBlue;
                button604.Enabled = false;
            }
            //605
            SqlCommand komut49 = new SqlCommand("select * from Oda605", bgl.baglanti());
            SqlDataReader oku49 = komut49.ExecuteReader();
            while (oku49.Read())
            {
                button605.Text = oku49["OdaMusteriAd"].ToString() + " " + oku49["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button605.Text != "605")
            {
                button605.BackColor = Color.SkyBlue;
                button605.Enabled = false;
            }
            //606
            SqlCommand komut50 = new SqlCommand("select * from Oda606", bgl.baglanti());
            SqlDataReader oku50 = komut50.ExecuteReader();
            while (oku50.Read())
            {
                button606.Text = oku50["OdaMusteriAd"].ToString() + " " + oku50["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button606.Text != "606")
            {
                button606.BackColor = Color.SkyBlue;
                button606.Enabled = false;
            }
            //607
            SqlCommand komut51 = new SqlCommand("select * from Oda607", bgl.baglanti());
            SqlDataReader oku51 = komut51.ExecuteReader();
            while (oku51.Read())
            {
                button607.Text = oku51["OdaMusteriAd"].ToString() + " " + oku51["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button607.Text != "607")
            {
                button607.BackColor = Color.SkyBlue;
                button607.Enabled = false;
            }
            //608
            SqlCommand komut52 = new SqlCommand("select * from Oda608", bgl.baglanti());
            SqlDataReader oku52 = komut52.ExecuteReader();
            while (oku52.Read())
            {
                button608.Text = oku52["OdaMusteriAd"].ToString() + " " + oku52["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button608.Text != "608")
            {
                button608.BackColor = Color.SkyBlue;
                button608.Enabled = false;
            }
            //609
            SqlCommand komut53 = new SqlCommand("select * from Oda609", bgl.baglanti());
            SqlDataReader oku53 = komut53.ExecuteReader();
            while (oku53.Read())
            {
                button609.Text = oku53["OdaMusteriAd"].ToString() + " " + oku53["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button609.Text != "609")
            {
                button609.BackColor = Color.SkyBlue;
                button609.Enabled = false;
            }
            //701
            SqlCommand komut54 = new SqlCommand("select * from Oda701", bgl.baglanti());
            SqlDataReader oku54 = komut54.ExecuteReader();
            while (oku54.Read())
            {
                button701.Text = oku54["OdaMusteriAd"].ToString() + " " + oku54["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button701.Text != "701")
            {
                button701.BackColor = Color.SkyBlue;
                button701.Enabled = false;
            }
            //702
            SqlCommand komut55 = new SqlCommand("select * from Oda702", bgl.baglanti());
            SqlDataReader oku55 = komut55.ExecuteReader();
            while (oku55.Read())
            {
                button702.Text = oku55["OdaMusteriAd"].ToString() + " " + oku55["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button702.Text != "702")
            {
                button702.BackColor = Color.SkyBlue;
                button702.Enabled = false;
            }
            //703
            SqlCommand komut56 = new SqlCommand("select * from Oda703", bgl.baglanti());
            SqlDataReader oku56 = komut56.ExecuteReader();
            while (oku56.Read())
            {
                button703.Text = oku56["OdaMusteriAd"].ToString() + " " + oku56["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button703.Text != "703")
            {
                button703.BackColor = Color.SkyBlue;
                button703.Enabled = false;
            }
            //704
            SqlCommand komut57 = new SqlCommand("select * from Oda704", bgl.baglanti());
            SqlDataReader oku57 = komut57.ExecuteReader();
            while (oku57.Read())
            {
                button704.Text = oku57["OdaMusteriAd"].ToString() + " " + oku57["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button704.Text != "704")
            {
                button704.BackColor = Color.SkyBlue;
                button704.Enabled = false;
            }
            //705
            SqlCommand komut58 = new SqlCommand("select * from Oda705", bgl.baglanti());
            SqlDataReader oku58 = komut58.ExecuteReader();
            while (oku58.Read())
            {
                button705.Text = oku58["OdaMusteriAd"].ToString() + " " + oku58["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button705.Text != "705")
            {
                button705.BackColor = Color.SkyBlue;
                button705.Enabled = false;
            }
            //706
            SqlCommand komut59 = new SqlCommand("select * from Oda706", bgl.baglanti());
            SqlDataReader oku59 = komut59.ExecuteReader();
            while (oku59.Read())
            {
                button706.Text = oku59["OdaMusteriAd"].ToString() + " " + oku59["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button706.Text != "706")
            {
                button706.BackColor = Color.SkyBlue;
                button706.Enabled = false;
            }
            //707
            SqlCommand komut60 = new SqlCommand("select * from Oda707", bgl.baglanti());
            SqlDataReader oku60 = komut60.ExecuteReader();
            while (oku60.Read())
            {
                button707.Text = oku60["OdaMusteriAd"].ToString() + " " + oku60["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button707.Text != "707")
            {
                button707.BackColor = Color.SkyBlue;
                button707.Enabled = false;
            }
            //708
            SqlCommand komut61 = new SqlCommand("select * from Oda708", bgl.baglanti());
            SqlDataReader oku61 = komut61.ExecuteReader();
            while (oku61.Read())
            {
                button708.Text = oku61["OdaMusteriAd"].ToString() + " " + oku61["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button708.Text != "708")
            {
                button708.BackColor = Color.SkyBlue;
                button708.Enabled = false;
            }
            //709
            SqlCommand komut62 = new SqlCommand("select * from Oda709", bgl.baglanti());
            SqlDataReader oku62 = komut62.ExecuteReader();
            while (oku62.Read())
            {
                button709.Text = oku62["OdaMusteriAd"].ToString() + " " + oku62["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button709.Text != "709")
            {
                button709.BackColor = Color.SkyBlue;
                button709.Enabled = false;
            }
            //801
            SqlCommand komut63 = new SqlCommand("select * from Oda801", bgl.baglanti());
            SqlDataReader oku63 = komut63.ExecuteReader();
            while (oku63.Read())
            {
                button801.Text = oku63["OdaMusteriAd"].ToString() + " " + oku63["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button801.Text != "801")
            {
                button801.BackColor = Color.SkyBlue;
                button801.Enabled = false;
            }
            //802
            SqlCommand komut64 = new SqlCommand("select * from Oda802", bgl.baglanti());
            SqlDataReader oku64 = komut64.ExecuteReader();
            while (oku64.Read())
            {
                button802.Text = oku64["OdaMusteriAd"].ToString() + " " + oku64["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button802.Text != "802")
            {
                button802.BackColor = Color.SkyBlue;
                button802.Enabled = false;
            }
            //803
            SqlCommand komut65 = new SqlCommand("select * from Oda803", bgl.baglanti());
            SqlDataReader oku65 = komut65.ExecuteReader();
            while (oku65.Read())
            {
                button803.Text = oku65["OdaMusteriAd"].ToString() + " " + oku65["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button803.Text != "803")
            {
                button803.BackColor = Color.SkyBlue;
                button803.Enabled = false;
            }
            //804
            SqlCommand komut66 = new SqlCommand("select * from Oda804", bgl.baglanti());
            SqlDataReader oku66 = komut66.ExecuteReader();
            while (oku66.Read())
            {
                button804.Text = oku66["OdaMusteriAd"].ToString() + " " + oku66["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button804.Text != "804")
            {
                button804.BackColor = Color.SkyBlue;
                button804.Enabled = false;
            }
            //805
            SqlCommand komut67 = new SqlCommand("select * from Oda805", bgl.baglanti());
            SqlDataReader oku67 = komut67.ExecuteReader();
            while (oku67.Read())
            {
                button805.Text = oku67["OdaMusteriAd"].ToString() + " " + oku67["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button805.Text != "805")
            {
                button805.BackColor = Color.SkyBlue;
                button805.Enabled = false;
            }
            //806
            SqlCommand komut68 = new SqlCommand("select * from Oda806", bgl.baglanti());
            SqlDataReader oku68 = komut68.ExecuteReader();
            while (oku68.Read())
            {
                button806.Text = oku68["OdaMusteriAd"].ToString() + " " + oku68["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button806.Text != "806")
            {
                button806.BackColor = Color.SkyBlue;
                button806.Enabled = false;
            }
            //807
            SqlCommand komut69 = new SqlCommand("select * from Oda807", bgl.baglanti());
            SqlDataReader oku69 = komut69.ExecuteReader();
            while (oku69.Read())
            {
                button807.Text = oku69["OdaMusteriAd"].ToString() + " " + oku69["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button807.Text != "807")
            {
                button807.BackColor = Color.SkyBlue;
                button807.Enabled = false;
            }
            //808
            SqlCommand komut70 = new SqlCommand("select * from Oda808", bgl.baglanti());
            SqlDataReader oku70 = komut70.ExecuteReader();
            while (oku70.Read())
            {
                button808.Text = oku70["OdaMusteriAd"].ToString() + " " + oku70["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button808.Text != "808")
            {
                button808.BackColor = Color.SkyBlue;
                button808.Enabled = false;
            }
            //809
            SqlCommand komut71 = new SqlCommand("select * from Oda809", bgl.baglanti());
            SqlDataReader oku71 = komut71.ExecuteReader();
            while (oku71.Read())
            {
                button809.Text = oku71["OdaMusteriAd"].ToString() + " " + oku71["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button809.Text != "809")
            {
                button809.BackColor = Color.SkyBlue;
                button809.Enabled = false;
            }
            //901
            SqlCommand komut72 = new SqlCommand("select * from Oda901", bgl.baglanti());
            SqlDataReader oku72 = komut72.ExecuteReader();
            while (oku72.Read())
            {
                button901.Text = oku72["OdaMusteriAd"].ToString() + " " + oku72["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button901.Text != "901")
            {
                button901.BackColor = Color.SkyBlue;
                button901.Enabled = false;
            }
            //902
            SqlCommand komut73 = new SqlCommand("select * from Oda902", bgl.baglanti());
            SqlDataReader oku73 = komut73.ExecuteReader();
            while (oku73.Read())
            {
                button902.Text = oku73["OdaMusteriAd"].ToString() + " " + oku73["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button902.Text != "902")
            {
                button902.BackColor = Color.SkyBlue;
                button902.Enabled = false;
            }
            //903
            SqlCommand komut74 = new SqlCommand("select * from Oda903", bgl.baglanti());
            SqlDataReader oku74 = komut74.ExecuteReader();
            while (oku74.Read())
            {
                button903.Text = oku74["OdaMusteriAd"].ToString() + " " + oku74["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button903.Text != "903")
            {
                button903.BackColor = Color.SkyBlue;
                button903.Enabled = false;
            }
            //904
            SqlCommand komut75 = new SqlCommand("select * from Oda904", bgl.baglanti());
            SqlDataReader oku75 = komut75.ExecuteReader();
            while (oku75.Read())
            {
                button904.Text = oku75["OdaMusteriAd"].ToString() + " " + oku75["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button904.Text != "904")
            {
                button904.BackColor = Color.SkyBlue;
                button904.Enabled = false;
            }
            //905
            SqlCommand komut76 = new SqlCommand("select * from Oda905", bgl.baglanti());
            SqlDataReader oku76 = komut76.ExecuteReader();
            while (oku76.Read())
            {
                button905.Text = oku76["OdaMusteriAd"].ToString() + " " + oku76["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button905.Text != "905")
            {
                button905.BackColor = Color.SkyBlue;
                button905.Enabled = false;
            }
            //906
            SqlCommand komut77 = new SqlCommand("select * from Oda906", bgl.baglanti());
            SqlDataReader oku77 = komut77.ExecuteReader();
            while (oku77.Read())
            {
                button906.Text = oku77["OdaMusteriAd"].ToString() + " " + oku77["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button906.Text != "906")
            {
                button906.BackColor = Color.SkyBlue;
                button906.Enabled = false;
            }
            //907
            SqlCommand komut78 = new SqlCommand("select * from Oda907", bgl.baglanti());
            SqlDataReader oku78 = komut78.ExecuteReader();
            while (oku78.Read())
            {
                button907.Text = oku78["OdaMusteriAd"].ToString() + " " + oku78["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button907.Text != "907")
            {
                button907.BackColor = Color.SkyBlue;
                button907.Enabled = false;
            }
            //908
            SqlCommand komut79 = new SqlCommand("select * from Oda908", bgl.baglanti());
            SqlDataReader oku79 = komut79.ExecuteReader();
            while (oku79.Read())
            {
                button908.Text = oku79["OdaMusteriAd"].ToString() + " " + oku79["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button908.Text != "908")
            {
                button908.BackColor = Color.SkyBlue;
                button908.Enabled = false;
            }
            //909
            SqlCommand komut80 = new SqlCommand("select * from Oda909", bgl.baglanti());
            SqlDataReader oku80 = komut80.ExecuteReader();
            while (oku80.Read())
            {
                button909.Text = oku80["OdaMusteriAd"].ToString() + " " + oku80["OdaMusteriSoyad"].ToString();
            }
            bgl.baglanti().Close();
            if (button909.Text != "909")
            {
                button909.BackColor = Color.SkyBlue;
                button909.Enabled = false;
            }
        }
    }
}
