using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace d_like
{
    class kelimekaydet
    {
        public void KelimeKaydet(string zaman, string dosyadı, string türkçe, string ingilizce, string anlamı, string tür, string örnek,int yuzde)
        {
            StreamWriter olustur = File.AppendText("C:\\Users\\umt_m\\Desktop\\repos\\d-like\\kelimeler\\"+ dosyadı + ".txt");

            olustur.Write(zaman + "_");
            olustur.Write(türkçe + "_");
            olustur.Write(ingilizce + "_");
            olustur.Write(anlamı + "_");
            olustur.Write(tür + "_");
            olustur.Write(örnek + "_");
            olustur.WriteLine("%" + yuzde);
            olustur.Close();

        }
    }
}
