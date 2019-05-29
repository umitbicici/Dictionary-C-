using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace d_like
{
    class KBOkuma
    {
        string basarılı;
        public string oku(string KAdı, string Sifre)
        {
            StreamReader okuyucu = File.OpenText("C:\\Users\\umt_m\\Desktop\\repos\\d-like\\KullanıcıBilgileri.txt");
            string okunansatır = okuyucu.ReadLine();
            while (okunansatır != null)
            {
                string[] parca = okunansatır.Split('_');

                if (KAdı == parca[0] && Sifre == parca[3])
                {
                  
                    basarılı = "true";
                    break;

                }
                else basarılı = "false";
                okunansatır = okuyucu.ReadLine();

            }
            okuyucu.Close();
            return basarılı;
        }


    }
}
