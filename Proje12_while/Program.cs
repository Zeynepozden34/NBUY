namespace Proje12_while;
class Program
{
    static void Main(string[] args)
    {
        //int sayac=1;
        //   while (sayac<=5)
        //   {
        //       Console.WriteLine("hello world");
        //       sayac++;
        //   }

        // int toplam=0;
        // string gırılenDeger="";
        // int sayac=1;
        // while (gırılenDeger != "exit")
        // {
        //     Console.Write($"{sayac}.sayıyı giriniz(çıkış için exit)");
        //     gırılenDeger=Console.ReadLine();
        //    // if (gırılenDeger!="exit") toplam+=Convert.ToInt32(gırılenDeger);           
        //            try
        //            {
        //              toplam+=Convert.ToInt32(gırılenDeger);
        //            }
        //            catch (System.Exception)
        //            {

        //             break;
        //            }    

        //          sayac++;
        // }
        //     Console.WriteLine(toplam);


        // klabyeden exit yazılana kadar isim girilmesini isteyen program
        // string isim="";
        // while (isim != "exit")
        // {
        //    Console.WriteLine("isim giriniz");
        //    isim=Console.ReadLine();
        // }

        // Console.WriteLine("program sona erdi...");

        //çözüm2:
        // string isim;
        // do
        // {
        //     Console.Write("isim giriniz: ");
        //       isim=Console.ReadLine();
        // } while (isim != "exit");

        // Console.WriteLine("program sona erdi...");
        // int toplam=0;
        // string gırılenDeger="";
        // int sayac=1;
        // do
        // {

        //      Console.Write($"{sayac}.sayıyı giriniz: (çıkış için exit): ");
        //         gırılenDeger=Console.ReadLine();
        //         if(gırılenDeger!="exit") toplam+=Convert.ToInt32(gırılenDeger);

        // } while (gırılenDeger!="exit");
        //  Console.WriteLine(toplam);

        // Random rastgele=new Random();
        // int rastgeleSayi=rastgele.Next();
        //  Console.WriteLine(rastgeleSayi);
        //  int rastgeleSyı2=rastgele.Next(100); // 0-100 arası rastgele sayı üretir 100 dahil değildir. 0 dahildir.
        //  Console.WriteLine(rastgeleSyı2);
        //  int rastgeleSayı3=rastgele.Next(100, 2000); //100-2000 arası radtgele sayı üretir 100 dahil 2000 dah,l değildir.
        //  System.Console.WriteLine(rastgeleSayı3);



        // oyun: uygulamanın rastgele üreteceği sayıyı kullanıcıdan tahmin etmeini isteyen program.
        // rastgele üretilecek sayı 1- 11 arasıdadır
        //kullanıcı rastgele sayıdan küçükyada büyük sayı girildiinde kullanıcıya mesaj versin 
        // dooğru sayıyı tahmin edene kadar  uygulama çalışsın



        int uretilenSayı = rnd.Next(1, 11);
        int tahminEdilenSayı;

        do
        {
          
     
            System.Console.Write("tahminini giriniz(1-10): ");
            tahminEdilenSayı = Convert.ToInt32(Console.ReadLine());
            if (tahminEdilenSayı > uretilenSayı)
            {
                System.Console.WriteLine("büyük sayı girdini daha küçük sayı giriniz.");
            }
            else if (tahminEdilenSayı < uretilenSayı)
            {
                System.Console.WriteLine("küçük sayı girdini daha büyük sayı giriniz.");

            }
            else
            {
                System.Console.WriteLine("tebrikler bildinz.");
            }
        } while (tahminEdilenSayı != uretilenSayı);















    }
}
