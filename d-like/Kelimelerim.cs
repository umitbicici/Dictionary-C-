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
    public partial class Kelimelerim : DevExpress.XtraEditors.XtraForm
    {
        public static string t3;
        public Kelimelerim()
        {
            InitializeComponent();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            listBoxKelimeler.Items.Clear();
            string line;
            var dosya = new System.IO.StreamReader("C:\\Users\\umt_m\\Desktop\\repos\\d-like\\kelimeler\\" + t3 + ".txt");
            while ((line = dosya.ReadLine()) != null)
            {
                listBoxKelimeler.Items.Add(line);
            }
            dosya.Close();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxKelimeler.Items.Count; i++)
            {
                if (listBoxKelimeler.Items[i].ToString().ToLower().Contains(aranacak_kelime.Text.ToLower()))
                {
                    listBoxKelimeler.SetSelected(i, true);
                }
            }
        }

        private void aranacak_kelime_Click(object sender, EventArgs e)
        {
            aranacak_kelime.Clear();
        }

        private void Kelimelerim_Load(object sender, EventArgs e)
        {
            t3 = KullanıcıArayüz.t2;
        }
    }
}
