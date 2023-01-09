using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid3_OpenClosed.Before
{
    public class EskenarUcgen
    {
        public int Taban { get; set; }
        public int Yükseklik { get; set; }
        public EskenarUcgen(int kenar, int yükseklik)
        {
            Taban = kenar;
            Yükseklik = yükseklik;
        }
        public override double AlanHesapla()
        {

            return Math.Pow(Kenar, 2);
        }
    }
}
