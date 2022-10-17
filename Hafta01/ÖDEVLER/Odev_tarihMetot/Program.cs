using System;

namespace Odev_tarihMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bugun = DateTime.Now;
            int day = bugun.Day + 2;
            int yıl = bugun.Year;
            DateTime sonuc = new DateTime(yıl, 1, day);
            Console.WriteLine(sonuc.ToLongDateString());
        }
    }
}

