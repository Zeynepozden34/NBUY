namespace Proje06_matematikselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 43;
            //int sayi2 = 51;
            //int minimum = Math.Min(sayi1, sayi2);
            //int maximum = Math.Max(sayi1, sayi2);   
            //Console.WriteLine($"minimum sayı: {minimum} , maximum sayı: {maximum}");


            // int taban = 4;
            // int us = 3;
            //double sonuc=Math.Pow(taban, us);
            // Console.WriteLine(sonuc);

            //Console.Write("Taban:");
            //int taban = Convert.ToInt32(Console.ReadLine());  // READLİNE KOMUTU HER ZAMAN STRİNG KABUL EDİLİR.
            //Console.Write("üs:");
            //int us=int.Parse(Console.ReadLine());
            //double sonuc = Math.Pow(taban, us);
            //Console.WriteLine(sonuc);

            double sayi = 5.493486;
          Console.WriteLine(Math.Ceiling(sayi)); //sayıyı bir büyüğe yuvarlar
        //   Console.WriteLine(Math.Floor(sayi));  // sayıyı bir küçüğe yuvarlar
            Console.WriteLine(Math.Round(sayi,2));
            Console.WriteLine(Math.Round(sayi,0));





        }
    }
}