namespace Odev2_SayılarınOrtalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sonuc = 0;
            int sayı = 100;
            for (int i = 0; i <= sayı; i++)
            {
                toplam += i;

            }
            sonuc = toplam / sayı;
            Console.WriteLine(sonuc);
        }
    }
}