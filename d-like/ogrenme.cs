using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace d_like
{
    class Ogrenme
    {
        public int Ogren(string dosyadı)
        {
            StreamReader ogren = File.OpenText("C:\\Users\\umt_m\\Desktop\\d-like\\kelimeler\\" + dosyadı + ".txt");
            string okunansatır = ogren.ReadLine();
            int x = 0;

            while (okunansatır != null)
            {
                string[] parca = okunansatır.Split('_');

                string zaman = parca[0];
                DateTime dt = DateTime.Parse(zaman);
                TimeSpan fark = DateTime.Today - dt;
                x = fark.Days;

                break;


            }

            return x;

        }


    }
}
