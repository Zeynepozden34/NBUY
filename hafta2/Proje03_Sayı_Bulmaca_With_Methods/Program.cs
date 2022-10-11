namespace Proje03_Sayı_Bulmaca_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sayı bulmaca oyununu methods konusu bağlamında hazırlayınız.
            // 5 tercih hakkı olsun
            // puan sistemi olsun(1. tecihinde bildiyse 50, bilmedikçe 10'ar 10'ar düşsün.)
            //Oyun kaybettiğinde ya da kazandığında yeniden oynamak istiyor ise oynayabilsin.


            string tercih;
            do
            {
                Console.Clear();
                Oyun.Oyna();
                do
                {
                   
                    Console.WriteLine("Tekrar Oynamak İster misiniz? [E/H]");
                    tercih = Console.ReadLine().ToUpper();

                } while (tercih != "H" && tercih != "E");
            }while (tercih != "H");
            Console.ReadLine();  







        }
    }
}