﻿namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        // int sayac = 1;
        // while (sayac <= 5)
        // {
        //     Console.WriteLine("Hello, World!");
        //     sayac++;
        // }

        // int toplam = 0;
        // string girilenDeger = "";
        // int sayac = 1;
        // while (girilenDeger != "exit")
        // {
        //     Console.Write($"{sayac}.sayıyı giriniz(Çıkış için exit): ");
        //     girilenDeger = Console.ReadLine();
        //     // if (girilenDeger!="exit") toplam += Convert.ToInt32(girilenDeger);
        //     try
        //     {
        //         toplam += Convert.ToInt32(girilenDeger);
        //     }
        //     catch (System.Exception)
        //     {
        //         Console.WriteLine(toplam);
        //         break;
        //     }
        //     sayac++;
        // }

        //SORU: Klavyeden exit yazılana kadar isim girilmesini isteyen uygulama.
        //Çözüm-1:
        // string isim = "";
        // while (isim!="exit")
        // {
        //     Console.Write("İsim giriniz: ");
        //     isim = Console.ReadLine();
        // }
        // Console.WriteLine("Program sona erdi...");


        //Çözüm-2:
        // string isim;
        // do
        // {
        //     Console.Write("İsim giriniz: ");
        //     isim=Console.ReadLine();
        // } while (isim!="exit");
        // Console.WriteLine("Program sona erdi...");
<<<<<<< Updated upstream

        //Klavyeden exit yazılana kadar sayı almaya devam eden ve bu sayıların toplamını exit yazılınca ekrana yazan prg.
        //Do-While ile

=======

        //Klavyeden exit yazılana kadar sayı almaya devam eden ve bu sayıların toplamını exit yazılınca ekrana yazan prg.
        //Do-While ile

>>>>>>> Stashed changes
        // string girilenDeger="0";
        // int sayac=1;
        // int toplam = 0;

        // do
        // {
        //     Console.WriteLine($"{sayac}.sayıyı giriniz: ");
        //     girilenDeger = Console.ReadLine();
        //     if(girilenDeger!="exit") toplam += Convert.ToInt32(girilenDeger);
        // } while (girilenDeger!="exit");

        // Random rastgele = new Random();
        // int rastgeleSayi = rastgele.Next();
        // Console.WriteLine(rastgeleSayi);
        // int rastgeleSayi2 = rastgele.Next(100);//0-100 arasında rastgele sayı üretir. 0 dahil, 100 hariçtir.
        // Console.WriteLine(rastgeleSayi2);
        // int rastgeleSayi3 = rastgele.Next(1000,2000);//1000-2000 arasında rastgele sayı üretir. 1000 dahil, 2000 hariçtir.
        // Console.WriteLine(rastgeleSayi3);


        //OYUN: Uygulamanın rastgele üreteceği bir sayıyı kullanıcının tahmin etmesini isteyeceğiz.
        //Rastgele üretilecek olan sayı 1-100 arasında olsun.
        //Kullanıcı rastgele sayıdan küçük ya da büyük bir sayı girdiğinde kullanıcıya uygun bir şekilde mesaj verilsin.
        //Doğru sayıyı tahmin edene kadar uygulama çalışsın. (X)
        //Kullanıcı doğru sayıyı tahmin ettiyse ya da 5 hakkını kullandıysa uygulama sona ersin!

        Random rnd = new Random();
        int uretilenSayi = rnd.Next(1, 101);
        Console.WriteLine($"HİLE: {uretilenSayi}");
        Console.WriteLine("****************");
        int tahminEdilenSayi;
        int hak = 1;//Kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi
        int hakSiniri = 5;//Kullanıcının toplam kaç hakka sahip olduğu bilgisi
        // do
        // {
        //     Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
        //     tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

        //     if (hak == hakSiniri && uretilenSayi!=tahminEdilenSayi)
        //     {
        //         Console.WriteLine("Kaybettiniz");
        //         break;
        //     }

        //     if (tahminEdilenSayi > uretilenSayi)
        //     {
        //         Console.WriteLine("Büyük bir değer girdiniz, daha küçük bir değer girerek yeniden deneyiniz!");
        //     }
        //     else if (tahminEdilenSayi < uretilenSayi)
        //     {
        //         Console.WriteLine("Küçük bir değer girdiniz, daha büyük bir değer girerek yeniden deneyiniz!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Tebrikler!");
        //     }
        //     hak++;

        // } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);

        // doğru tahmin - 3.tahmin
<<<<<<< Updated upstream
=======

        // do
        // {
        //     Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
        //     tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
        //     if (tahminEdilenSayi > uretilenSayi)
        //     {
        //         Console.WriteLine("Büyük girdin");
        //     }
        //     else if (tahminEdilenSayi < uretilenSayi)
        //     {
        //         Console.WriteLine("Küçük girdin");
        //     }
        //     if (tahminEdilenSayi != uretilenSayi)
        //     {
        //         hak++;
        //         if (hak <= hakSiniri)
        //         {
        //             Console.WriteLine("Kaybettin!");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Kazandın!");
        //     }

        // } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);
        //Eğer program bu satıra gelmiş ise ya doğru tahminde bulunulmuştur ya da hak sona ermiştir.

>>>>>>> Stashed changes

        do
        {
            Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
            tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            if (tahminEdilenSayi > uretilenSayi)
            {
                Console.WriteLine("Büyük girdin");
            }
            else if (tahminEdilenSayi < uretilenSayi)
            {
                Console.WriteLine("Küçük girdin");
            }
            if (tahminEdilenSayi != uretilenSayi)
            {
<<<<<<< Updated upstream
                hak++;
                if (hak <= hakSiniri)
=======
                
                if (hak==hakSiniri)
>>>>>>> Stashed changes
                {
                    Console.WriteLine("Kaybettin!");
                }
            }
            else
            {
                Console.WriteLine("Kazandın!");
            }
<<<<<<< Updated upstream
=======
            hak++;

        } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);

























>>>>>>> Stashed changes

        } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);
        //Eğer program bu satıra gelmiş ise ya doğru tahminde bulunulmuştur ya da hak sona ermiştir.
    }
}
