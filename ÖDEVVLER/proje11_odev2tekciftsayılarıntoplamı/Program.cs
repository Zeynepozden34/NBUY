namespace proje11_odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tekSayıToplam = 0;
            int ciftSayıToplam = 0;
            int besKatıToplam = 0;
            for (int i = 0; i <=100; i++)
            {
                if (i%2==1)
                {
                    tekSayıToplam += i;
                                       
                }
                if (i % 5 == 0)
                {
                    besKatıToplam += i;
                }

                else if (i % 2 == 0)
                {
                    ciftSayıToplam += i;
                                        
                }
              
            }
            Console.WriteLine($"Tek Sayıların Toplamı: {tekSayıToplam}, Çift sayıların Toplamı: {ciftSayıToplam}, Beşin Kayı Sayıların Toplamı: {besKatıToplam}");
        }
    }
}