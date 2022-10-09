using System;
using System.Reflection.Emit;

namespace Odev5_SıfreOlusturma
{
    internal class Program   //İçinde Türkçe karakterler hariç tüm küçük harfler, 0 - 9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız

    {
        static void Main(string[] args)

        {

            string karakterler = "abcçdefghıijklmnopqrstuüvwxyz0123456789+-.,";

            Random random = new Random();
            string sifre="";
            for (int i = 0; i < 6; i++)
            {
                sifre += karakterler[random.Next(karakterler.Length)];
            }

            Console.WriteLine("Oluşturulan Şifre: " + sifre);



        } 
    }
}