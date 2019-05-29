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
    public partial class KullanıcıArayüz : DevExpress.XtraEditors.XtraForm
    {
        public static string t2;
        public KullanıcıArayüz()
        {
            InitializeComponent();
        }

        private void kelime_ekle_Click_1(object sender, EventArgs e)
        {
            t2 = KullanıcıGirisi.t1;
            KelimeEkle kaydet = new KelimeEkle();
            kaydet.Show();
        }

        private void kelimelerim_Click_1(object sender, EventArgs e)
        {
            t2 = KullanıcıGirisi.t1;
            Kelimelerim kelimeler = new Kelimelerim();
            kelimeler.Show();
        }

        private void ogrenme_Click(object sender, EventArgs e)
        {
            OgrenmeMerkezi ogrenme_merkezi = new OgrenmeMerkezi();
            ogrenme_merkezi.Show();
        }
    }
}