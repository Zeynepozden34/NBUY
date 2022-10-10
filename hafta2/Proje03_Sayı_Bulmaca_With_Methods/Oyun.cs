using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje03_Sayı_Bulmaca_With_Methods
{
    static class Oyun
    {
       public static int SayiUret()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 101);
            return sayi;
        }

        public static int TahminGir(int TahminSıraNo)
        {
            Console.WriteLine($"{TahminSıraNo}. Tahmininizi Giriniz: ");
            return int.Parse(Console.ReadLine());

        }
        public static string TespitEt(int tahmin, int sayı)
        {
            if (tahmin>sayı)
            {

            }

        }



    }
}
