using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid3_OpenClosed.After
{
    public abstract class Sekil
    {
        public abstract double AlanHesapla(); // Ne zmn miras alırsa o zmn içi dolsun.
        public void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }

    }
}
