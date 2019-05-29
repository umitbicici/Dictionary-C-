using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace d_like
{
    public partial class KelimeEkle : DevExpress.XtraEditors.XtraForm
    {
        public static string t3;
        public KelimeEkle()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string time;
            t3 = KullanıcıArayüz.t2;
            kelimekaydet nesne = new kelimekaydet();
            time = DateTime.Now.ToString();
            int yuzde = 0;
            nesne.KelimeKaydet(time, t3, turkce.Text, ingilizce.Text, anlam.Text, tur.Text, ornek_cumle.Text, yuzde);
            MessageBox.Show("Kelime Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}