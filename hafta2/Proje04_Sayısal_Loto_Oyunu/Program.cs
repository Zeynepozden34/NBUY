using System.Collections;

namespace Proje04_Sayısal_Loto_Oyunu
{
    internal class Program
    {
        static int[] SayiUret()
        {
            Random rnd = new Random();
            int[] loto = new int[6];
            int sayi;
            for (int i = 0; i < 6; i++)
            {
                sayi = 0;
                do
                {

                    sayi = rnd.Next(1, 50);


                } while (loto.Contains(sayi));
                loto[i] = sayi;
            }
            return loto;
        }
       
        static void Hile(int[] loto)
        {
            Console.WriteLine("Hile");
            Console.WriteLine("*****");
            foreach (var SıradakiSayi in loto)
            {
                Console.WriteLine(SıradakiSayi);


            }

            static int TahminYap(int TahminSiraNo)
            {
                int tahmin;
                Console.WriteLine($"{TahminSiraNo}. tahmininizi giriniz: ");
                tahmin = int.Parse(Console.ReadLine());
                return tahmin;
            }
            static void Main(string[] args)
            {
                #region Açıklama
                // Sistemde 6 sayı üretelim(1-49)
                // Kullanıcıdan 6 tahmin isteyelim.
                //sonuc olarak kullancının kaç dogru tahmin yaptığını, tahminleriyle beraber yazdıralım.
                // not: hiç dıpgru tahmin yapmazsa kaybettin yazsın
                #endregion
                int tahmin;
                int[] loto = SayiUret();
                int[] tahminler = new int[6];
                Hile(loto);
                for (int i = 0; i < 6; i++)
                {
                    do
                    {
                        tahmin = TahminYap(i + 1);
                    } while (tahmin < 0 || tahmin > 49);

                    tahminler[i] = tahmin;
                }
                ArrayList bilinenler = new ArrayList();// arraylistlerde kaç eleamnlı olacağı söylenmez. içinde her bir eleman istenilen tipte değer tutabilir. int, string,char vb
                foreach (var sıradakiTahmin in tahminler)
                {
                    if (loto.Contains(sıradakiTahmin))
                    {
                        bilinenler.Add(sıradakiTahmin);
                    }
                }

            

            Console.ReadLine();
        }
    }
}