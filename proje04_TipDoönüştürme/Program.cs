namespace proje04_TipDoönüştürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sbyte negatif değer de tanımlar byte tanımlamaz.
            //  byte a = 5;
            // short b = 10;
            //sbyte c = 30;
            //int d = a + b + c; // benzer tipleri int'e dönütürmesine Impicit Convert - örtülü dönüştürme
            //Console.WriteLine($"Sonuç(d)= {d}");
            // Convert sayı tiplerinin dönüşümünde kullanılır.
            // string metin = "NBUY";
            //char karakter = 'k';
            //object e = metin + karakter + d;   // object bütün tipleri toplayan tiptir. Implicit Convert
            //Console.WriteLine($"object={e}");

            //byte a = 155;
            //byte b = 101;
           // byte c = Convert.ToByte(a+b); // Explicit Convert- Bilinçli Dönüşüm(hata var)
            //Console.WriteLine($"sonuc(c)={c}");


           // byte d =(byte)(a + b);  // Unboxing
           // Console.WriteLine($"sonuc(d)={d}");

            //int a = 310;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            byte a = 155;
            byte b = 111;
            int c = a + b;
            Console.WriteLine($"sonuc(c)={c}");





        }
    }
}