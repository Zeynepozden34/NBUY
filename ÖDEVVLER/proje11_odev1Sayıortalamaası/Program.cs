namespace proje11_odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplam = 0;
            int sayı = 100;
           
            for (int i = 1; i <=sayı; i++)
            {
                toplam = toplam + i;                
               
            }
            double ort = toplam / sayı;
             
            Console.WriteLine($"Sayıların ortalaması: {ort}");



      









        }
    }
}