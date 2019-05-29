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
    public partial class KullanıcıKayıt : DevExpress.XtraEditors.XtraForm
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Sifre.PasswordChar = '\0';
            }
            else
                Sifre.PasswordChar = '◎';
        }

        private void kaydol_Click(object sender, EventArgs e)
        {
            KBYazma yazıyor = new KBYazma();
            yazıyor.KByazma(KAdı.Text, Ad.Text, Soyad.Text, Sifre.Text);
            string dosyadı;

            dosyadı = "C:\\Users\\umt_m\\Desktop\\repos\\d-like\\KullanıcıBilgileri.txt";
            StreamWriter kayıtlar = File.AppendText(dosyadı);
            kayıtlar.Close();

            foreach (Control check in this.Controls)
            {
                if (check is TextBox)
                {
                    (check as TextBox).Clear();
                }
            }
            KAdı.Focus();
            MessageBox.Show("Kullanıcı Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KAdı_Click(object sender, EventArgs e)
        {
            KAdı.Clear();
        }

        private void Ad_Click(object sender, EventArgs e)
        {
            Ad.Clear();
        }

        private void Soyad_Click(object sender, EventArgs e)
        {
            Soyad.Clear();
        }

        private void Sifre_Click(object sender, EventArgs e)
        {
            Sifre.Clear();
            Sifre.PasswordChar= '◎';
        }
    }
}