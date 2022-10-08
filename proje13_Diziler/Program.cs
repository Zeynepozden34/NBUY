namespace proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ad;
            //ad = "Engin";
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";
            //string[] adlar = new string[7]; // içinde 6 adet string bilgi tutabilecek bir dizi. değerler sonra atnacaksa bu şekilde yazılır.
            //adlar[0] = "Fatih Candan";
            //adlar[1] = "Cemal Gündem";
            //adlar[2] = "Selin Dilci";
            //adlar[3] = "Kemal Kurt";
            //adlar[4] = "Begüm Yanıcı";
            //adlar[5] = "Selma Halıcı";
            //adlar[6] = "Emre Mor";
            ////Console.WriteLine(adlar[0]);

            //for (int i = 0; i <adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}


            //int[] yaslar = new int[3];
            //int[] rakamlar = { 66, 56, 45, 33, 55 };
            //int toplam = 0;
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    toplam += rakamlar[i];
            //}
            //Console.WriteLine(toplam);


            //string okul = "Wissen Akademie"; // stringlrde bir karakter dizisidir. 
            //Console.WriteLine(okul[0]);


            //ÇALIŞMA: klavyeden kullanıcının adını soyadını giresini isteyiniz
            // girilen ad soyadı aşagıya doğru büyük harflerle yazınız.


            //Console.Write("Lütfen isminizi giriniz: ");
            //string kullanıcı = Console.ReadLine().ToUpper();
            //for (int i = 0; i <kullanıcı.Length; i++)
            //{
            //    Console.WriteLine(kullanıcı[i]);
            //}


            //Console.Write("Bir metin giriniz: ");
            //string girilenMetın=Console.ReadLine().ToLower();
            //Console.Write("hangi karakterin sırasını bulmamı istersiniz: ");
            //string karakter = (Console.ReadLine().ToLower());
            //int sıraNo = girilenMetın.IndexOf(karakter)+1;
            //Console.Clear();
            //Console.WriteLine($"Girilen Metin: {girilenMetın}\n Aradığınız karakter: {karakter}\n Aradığınız karakterin Girilen metindeki sırası: {sıraNo}");
            //Console.WriteLine("dizinin orjinalhali");
            //Console.WriteLine("***************");
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Kendimiz en büyük sayıyı bulalım
            //Console.WriteLine($"En küçük:\t{rakamlar.Min()}");
            //Console.WriteLine($"En büyük:\t{rakamlar.Max()}");


            // int[] rakamlar = { 66, 56, 45, 33, 55 };

            //int Enbuyuk = rakamlar[4];

            // if (Enbuyuk < rakamlar[1])
            // {
            //     Enbuyuk = rakamlar[1];                
            // }
            // if (Enbuyuk < rakamlar[2])
            // {
            //     Enbuyuk = rakamlar[2];             
            // }
            // if (Enbuyuk < rakamlar[3])
            // {
            //     Enbuyuk = rakamlar[3];              
            // }
            // if (Enbuyuk < rakamlar[0])
            // {
            //     Enbuyuk = rakamlar[0];

            // }
            //// Console.WriteLine(Enbuyuk);
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };

            //int Enbuyuk = rakamlar[0];
            //int enKucuk = rakamlar[0];


            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i]>Enbuyuk)
            //    {
            //        Enbuyuk = rakamlar[i];
            //    }
            //    if (rakamlar[i]<enKucuk)
            //    {
            //        enKucuk = rakamlar[i];
            //    }

            //}
            //Console.WriteLine(Enbuyuk);
            //Console.WriteLine(enKucuk);

            //ODEV: bu diziyi küçükten büyüğe doğru sıralayınız.

            //Console.WriteLine("Dizinin Ters Çevrilmiş Hali");
            //Console.WriteLine("**************");
            //Array.Reverse(rakamlar);  // Dizinin elemanları ters sıralanır.
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();


            //Console.WriteLine("Dizinin Küçükten büyüğe sıralanmş hali");
            //Console.WriteLine("*******************");
            //Array.Sort(rakamlar);  // Diziyi küçüktn büyüğe sıralanır.
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Dizinin büyükten sıralanmş hali");
            //Console.WriteLine("*******************");
            //Array.Sort(rakamlar);  // Diziyi küçüktn büyüğe sıralanır.
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();




            //ÖRNEKLERR
            //ÖRENK1: Sayıların diisinin ortalamasını bulduran program

            //int[] sayılar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayılar.Sum();
            //Console.WriteLine($"Toplam: {toplam}");

            //Örnek2: çift sayıları yazdıralım

            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    if (sayılar[i]%2==0)
            //    {
            //        Console.WriteLine(sayılar[i]);
            //    }
            //}


            //örnek3: Sayılar dizisindeki sayıları yanlarında pozitif, negatif yada işaretsiz olma bilgileri ile yazdıralım.
            //string tip = "";
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    tip = sayılar[i] < 0 ? "pozitif" :
            //         sayılar[i] < 0 ? "negatif" :
            //                         "işaretsiz";

            //    Console.WriteLine($"{i + 1}.Sayı: {sayılar[i]} - Tipi: {tip}");
            //}


            ////örnek: Kullanıcının gireceği metnin içindeki sesli harf sayısını yazdıralım
            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //int sesliHarfAdedi = 0;
            //Console.Write("Bir Metin Yazınız: ");
            //string girilenMetin=Console.ReadLine().ToLower();

            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i])) // KARAKTERDE OLUP OLMADIĞINI KONTOL EDER.
            //    {
            //        sesliHarfAdedi++;
            //    }
            //}
            //Console.WriteLine(sesliHarfAdedi);


            // Ornek5: Klavyeden girilen bir CÜMLEDEKİ yine klavyeden girilcek bir KELİMENİN kaç kez geçtiğini bulduralım.

            //string ornekMetın = "Engin Niyazi Ergül";
            //string[] sozcukDizisi = ornekMetın.Split(" ");   // değeri parçalar.

            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}


            // ornek 5:


            int sozcukAdedi = 0;
            Console.Write("Cümleyi Giriniz: ");
            string gırılenCumle=Console.ReadLine();
            Console.Write("Adedini girmek istediğiniz sözcüğü giriniz: ");
            string sayılacakSayı=Console.ReadLine();
            string[] girilenCümleninDiziHali = gırılenCumle.Split(" ");
            for (int i = 0; i < girilenCümleninDiziHali.Length; i++)
            {
                if (sayılacakSayı.ToLower() == girilenCümleninDiziHali[i].ToString().ToLower())
                {
                    sozcukAdedi++;
                }
              
            }
            Console.WriteLine($"{gırılenCumle} cümlesli içinde {sayılacakSayı} sözcüğü {sozcukAdedi} kez geçmektedir");




            //Araştırma: Çok boyutlu dizileri araştrınız.
            // PROJE ODEVİ: İçinde türkçe karakterler hariç tüm küçük harfler 0-9 arası rakamlar nokta(.), virgül(,), artı(+), eksi(-) karakterleri bulunabiecek toplam uzunlupu 6 karakter olacak şekilde Rastgele Şifre üreten programı yazınız.











        }
    }
}