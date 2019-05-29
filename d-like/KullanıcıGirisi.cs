using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace d_like
{
    public partial class KullanıcıGirisi : DevExpress.XtraEditors.XtraForm
    {
        public static string t1;
        public KullanıcıGirisi()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Clear();
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
            password.PasswordChar = '◎';
        }

        private void giris_Click_1(object sender, EventArgs e)
        {
            string durum;
            KBOkuma okuma = new KBOkuma();
            durum = okuma.oku(username.Text, password.Text);

            if (durum == "true")
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t1 = username.Text;
                KullanıcıArayüz KA = new KullanıcıArayüz();
                KA.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                username.Text = null;
                password.Text = null;
            }
        }

        private void k_ekle_Click(object sender, EventArgs e)
        {
            KullanıcıKayıt kaydol = new KullanıcıKayıt();
            kaydol.Show();
        }
    }
}
