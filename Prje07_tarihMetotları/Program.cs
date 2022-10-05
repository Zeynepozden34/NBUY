namespace Prje07_tarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            //DateTime dogumTarihi = new DateTime(1999, 4, 25);
            //DateTime bugun = DateTime.Now;
            //TimeSpan span = bugun.Subtract(dogumTarihi);  // subtract bugünden ddoğum gününü çıkarır.
            //Console.WriteLine($"toplam {Math.Ceiling(span.TotalDays)}gündür yaşıyorsunuz.");
            
            
            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.ToLongDateString());//5 Ekim 2022 Çarşamba şeklinde yazılır
            //Console.WriteLine(bugun.ToLongTimeString()); // 13:35:57 şeklinde yazılır
            //Console.WriteLine(bugun.ToShortDateString());//  5.10.2022 şeklinde yazılır
            //Console.WriteLine(bugun.ToShortTimeString()); //  13:35 şeklinde yazılır


            //bir sonraki uılın ilk gününün tarihini bulduralım
            //DateTime bugun=DateTime.Now;    
            //int yıl =bugun.Year+1;
            //DateTime sonuc = new DateTime(yıl, 1, 1);
            //Console.WriteLine(sonuc.ToLongDateString());



            // bir sonraki ayın ilk günün trihi
            //DateTime bugun = DateTime.Now;
            //int ay = bugun.Month + 1;
            //int yıl = bugun.Year ;
            //DateTime sonuc = new DateTime(yıl, ay, 1);
            //Console.WriteLine(sonuc.ToLongDateString());



            DateTime bugun = DateTime.Now;
           // Console.WriteLine(bugun+1);
            
            
            //
            // ÖDEVVVVV
            // ertesi günün tarihini bulup ekrana yazdıran program yazdırınız.





        }
    }
}