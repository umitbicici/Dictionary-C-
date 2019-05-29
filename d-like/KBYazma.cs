using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace d_like
{
    class KBYazma
    {
        public void KByazma(string KAdı, string ad, string soyad, string sifre)
        {
            StreamWriter UserInfo = File.AppendText("C:\\Users\\umt_m\\Desktop\\repos\\d-like\\KullanıcıBilgileri.txt");
            UserInfo.Write(KAdı + "_");
            UserInfo.Write(ad + "_");
            UserInfo.Write(soyad + "_");
            UserInfo.WriteLine(sifre);
            UserInfo.Close();
        }

    }
}
