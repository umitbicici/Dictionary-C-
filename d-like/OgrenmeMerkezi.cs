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

namespace d_like
{
    public partial class OgrenmeMerkezi : DevExpress.XtraEditors.XtraForm
    {
        public OgrenmeMerkezi()
        {
            InitializeComponent();
        }

        public string tarih = "";
        public string kelime = "";
        public string ingilizce = "";
        public string anlamı = "";
        public string tür = "";
        public string cumle = "";
        public int j = 30;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KullanıcıArayüz Ka = new KullanıcıArayüz();
            string t2;
            t2 = KullanıcıGirisi.t1;
            Ogrenme ogr = new Ogrenme();
            int i;
            i = ogr.Ogren(t2);


            if (i >= j)
            {

                StreamReader okuyucu = File.OpenText("C:\\Users\\umt_m\\Desktop\\repos\\d-like\\kelimeler\\" + t2 + ".txt");
                string okunansatır = okuyucu.ReadLine();
                while (okunansatır != null)
                {
                    string[] parca = okunansatır.Split('_');
                    tarih = parca[0];
                    kelime = parca[1];
                    ingilizce = parca[2];
                    anlamı = parca[3];
                    tür = parca[4];
                    cumle = parca[5];
                    break;


                }
                okuyucu.Close();


                a.Text = kelime;
                MessageBox.Show("Boş alanları doldurunuz!");

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asdad");
            if (ingilizce == b.Text && anlamı == c.Text && tür == d.Text && cumle == f.Text)
            {
                string t2;
                t2 = KullanıcıGirisi.t1;
                int yuzde = 0;
                tarih = DateTime.Today.ToString();
                MessageBox.Show("asdasd");
                StreamWriter yazıcı = File.AppendText("C:\\Users\\umt_m\\Desktop\\repos\\d-like\\kelimeler\\" + t2 + ".txt");
                yazıcı.Write(tarih + "_");
                yazıcı.Write(kelime + "_");
                yazıcı.Write(ingilizce + "_");
                yazıcı.Write(anlamı + "_");
                yazıcı.Write(tür + "_");
                yazıcı.Write(cumle + "_");
                yazıcı.WriteLine("%" + yuzde);

            }
        }
    }
}
