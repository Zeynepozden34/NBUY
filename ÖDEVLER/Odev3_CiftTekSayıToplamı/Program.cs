namespace Odev3_CiftTekSayıToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TekToplam = 0;
            int CiftToplam = 0;
            int BesinKatıToplam = 0;
            int sayı = 100;
            int TekSayıadet = 0;
            int CiftSayıadet = 0;
            int BesinKatıSayıadet = 0;

            for (int i = 0; i <=sayı; i++)
            {
                if (i%5==0)
                {
                    BesinKatıToplam += i;
                    BesinKatıSayıadet++;
                    
                }
                if (i%2==0)
                {
                    CiftToplam += i;
                    CiftSayıadet++;
                }
                else
                {
                    TekToplam += i;
                    TekSayıadet++;
                }

               
            }
            
            Console.WriteLine($"Tek Sayıların Toplamı: {TekToplam}, Adedi: {TekSayıadet}\nÇift Sayıların Toplamı: {CiftToplam}, Adedi: {CiftSayıadet}\nBeşin katı Sayıların Toplamı: {BesinKatıToplam}, Adedi: {BesinKatıSayıadet}");
        }
    }
}