using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            Console.Write($"{TahminSıraNo}. Tahmininizi Giriniz: ");
            return int.Parse(Console.ReadLine());

        }
        public static string TespitEt(int tahmin, int sayı)
        {
            if (tahmin > sayı)
            {
                return "Daha küçük bir sayı giriniz";

            }
            return "Daha büyük sayı giriniz";
        }
        public static void Oyna()
        {
            int sayi = SayiUret();
            int tahmin = 0;
            int puan = 50;
            string mesaj = "";
            bool sonuc=false;

            Console.WriteLine($"Hile: {sayi}");

            for (int i = 1; i <=5; i++)
            {
                tahmin = TahminGir(i);
                if (tahmin==sayi)
                {
                    sonuc = true;
                    break;
                }
                mesaj = TespitEt(tahmin,sayi);
                if (i != 5) Console.WriteLine(mesaj);
                        puan -=10;
                                
            }
            mesaj = sonuc == true ? $"Kazandınız, Kazandığınız puan: {puan}" : "Kaybettiniz"; 
                Console.WriteLine(mesaj);     

        }


    }
}
