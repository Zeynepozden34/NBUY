using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid3_OpenClosed.Before
{
    public class Hesapla
    {
        // Bu metot kendisine gelen şekillerin alanlarının toplamını bulacak.
       
        public double AlanlariTopla(object[] sekiller)
        {
            double alanToplami = 0;
            foreach (var sekil in sekiller)
            {
                if (sekil is Kare)
                {
                    alanToplami += Math.Pow(((Kare)sekil).Kenar, 2);
                }
                else if(sekil is Daire)
                {
                    alanToplami += Math.PI * Math.Pow(((Daire)sekil).Yaricap, 2);
                }
                else
                {
                    alanToplami +=((EskenarUcgen)sekil).Taban * ((EskenarUcgen)sekil).Yükseklik) / 2;
                }
            }
            return alanToplami;
            
        }
    }
}
