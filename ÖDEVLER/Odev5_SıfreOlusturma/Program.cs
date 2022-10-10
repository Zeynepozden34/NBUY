using System;
using System.Reflection.Emit;
using System.Text;

namespace Odev5_SıfreOlusturma
{
    internal class Program   //İçinde Türkçe karakterler hariç tüm küçük harfler, 0 - 9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız

    {
        static void Main(string[] args)

        {

            //string karakterler = "abcçdefghıijklmnopqrstuüvwxyz0123456789+-.,";

            //Random random = new Random();
            //string sifre = "";
            //for (int i = 0; i < 6; i++)
            //{
            //    sifre += karakterler[random.Next(karakterler.Length)];
            //}

            //Console.WriteLine("Oluşturulan Şifre: " + sifre);



            

        }
        public class Rastgele
        {
            Random rnd;
            public Rastgele()
            {
                rnd = new Random();
            }

            // rastgele sayı üret 
               
            public int RastgeleSayi(int min, int max)
            {
                return rnd.Next(min, max);
            }
            public int SembolUret(int min, int max)
            {
                return rnd.Next(min, max);
            }

            //rastgele harf üretme
            public string RasteleHarf(int boyut, bool kucukHarf)
            {
                string harfler = "";
                int sayi, min = 65;
                char harf;

                if (kucukHarf)
                {
                    min = 90;
                }

                for (int i = 0; i < boyut; i++)
                {
                    sayi = rnd.Next(min, min + 37); //sayi değişkenine rastgele bir sayı atar.
                    harf = Convert.ToChar(sayi);//rastgele bir harf üretir
                    harfler += harf;
                }
                return harfler;

                
            }

            //şifre üretme
            public string sifreUret()
            {
                

                Random rnd = new Random();
                return rnd.Next(1, 6).ToString();
                //StringBuilder builder = new StringBuilder();
                //builder.Append(RasteleHarf(3, true));
                //builder.Append(rnd.Next(100, 999));
                //builder.Append(RasteleHarf(2, false));
                //return builder.ToString();
                Console.WriteLine($"{RasteleHarf(2, true)},{rnd.Next(0, 9)},{SembolUret(43, 46)}");
            }
           
        }
       
    }
}