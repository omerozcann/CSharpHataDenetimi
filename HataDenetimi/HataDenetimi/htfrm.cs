using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HataDenetimi
{
    public partial class htfrm : Form
    {
        int sayi1, sayi2,sonuc;
        String islem = "";

        private void birbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "1";
        }

        private void ikibtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "2";
        }

        private void ucbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "3";
        }

        private void dortbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "4";
        }

        private void besbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "5";
        }

        private void altibtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "6";
        }

        private void yedibtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "7";
        }

        private void sekizbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "8";
        }

        private void dokuzbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "9";
        }

        private void bolmebtn_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(gostergetxt.Text);
            islem = "bolme";
            gostergetxt.Text = "";
        }

        private void sifirbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = gostergetxt.Text + "0";
        }

        private void carpmabtn_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(gostergetxt.Text);
            islem = "carpma";
            gostergetxt.Text = "";
        }

        private void cikarbtn_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(gostergetxt.Text);
            islem = "cikarma";
            gostergetxt.Text = "";
        }

        private void toplabtn_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(gostergetxt.Text);
            islem = "toplama";
            gostergetxt.Text = "";
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            gostergetxt.Text = "";
            islem = "";
        }

        private void esitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                sayi2 = Convert.ToInt32(gostergetxt.Text);
                if (islem == "bolme")
                {
                    sonuc = sayi1 / sayi2;
                }
                if (islem == "carpma")
                {
                    sonuc = sayi1 * sayi2;
                }
                if (islem == "cikarma")
                {
                    sonuc = sayi1 - sayi2;
                }
                if (islem == "toplama")
                {
                    sonuc = sayi1 / sayi2;
                }

                gostergetxt.Text = sonuc.ToString();
            }catch(Exception err)
            {
                StreamWriter sw = new StreamWriter("log.txt", true);
                sw.WriteLine(err.Message);
                sw.Close();
            }
            finally
            {
                StreamWriter sw = new StreamWriter("islemler.txt", true);
                sw.WriteLine("Hesaplama Tarihi:"+DateTime.Now.ToString());
                sw.Close();
            }
        }

        public htfrm()
        {
            InitializeComponent();
        }
    }
}
