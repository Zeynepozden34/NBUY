namespace proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <5; i++)
            //{

            //    Console.WriteLine($"{i+1} Hello, World!");

            //}
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    //toplam = toplam + i;
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            // 1 ile 10 arasındaki çft ayıların tılamını bulun
            //int toplam = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        toplam = toplam + i;
            //    }      
            //}
            //Console.WriteLine(toplam);




            //int toplam = 0;
            //for (int i = 0; i < 10; i=i+2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);


            //int cifttoplam = 0;
            //int tektoplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        tektoplam += i;
            //    }

            //    else
            //    {
            //        cifttoplam += i;
            //    }



            //}
            //Console.WriteLine($"tek sayılaarın toplamı {tektoplam}, çift sayıların toplamı {cifttoplam}");


            // klavyeden iki sayı girilsin. bu sayıların arasındaki sayıların toplamını ekrana yazdır.

            //Console.Write("birinci sayıyı giriniz: ");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("ikinci sayıyı giriniz: ");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //if (sayı1 < sayı2)
            //{
            //    for (int i = sayı1; i <= sayı2; i++)
            //    {
            //        toplam += i;
            //    }
            //}
            //else
            //{
            //    for (int i = sayı1; i >= sayı2; i--)
            //    {
            //        toplam += i;
            //    }
            //}


            //Console.WriteLine($"Toplam: {toplam}");


            //Console.Write("birinci sayıyı giriniz: ");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("ikinci sayıyı giriniz: ");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min = Math.Min(sayı1, sayı2);
            //int max = Math.Max(sayı1, sayı2);
            //if (sayı1 < sayı2)
            //{
            //    for (int i = min; i >= max; i++)
            //    {
            //        toplam += i;
            //    }

            //}
            //Console.WriteLine($"Toplam: {toplam}");


            //program kullanıcıdan bir sayı girmesini istesin. Ancak kullanıcı sayı girmeye devam ettiçe girilen sayıların toplanmasını sağlayalım.sayı adedi belirsiidir. uygulamanın bitip, ekrana toplamı yazdırailmesi için kullanıcının sayı yerine exit yazmasını kontrol edeceğiz.

            //int toplam = 0;
            //string girilenDeger = "";
            //string sonucMetın = "";

            //for (int i = 1; i < 1000000; i++)
            //{

            //    Console.Write($"{i}. sayıyı giriniz: (çıkış için exit)[Geçerli Toplam: {toplam}] ");
            //    girilenDeger = Console.ReadLine();

            //    if (girilenDeger.ToLower()=="exit") // if büyük, küçük harf duyarlıdır.
            //    {

            //        break; // içinde bulunulan döngünün tamamlanmasını beklemeden istenien bir anda durdurulmasını sağlar
            //    }
            //    sonucMetın = sonucMetın + girilenDeger + "+"; //100+250+500 gibi
            //    toplam+=Convert.ToInt32(girilenDeger);

            //}
            //int alınacakısmınuzunlupu = sonucMetın.Length - 4;
            //sonucMetın = sonucMetın.Substring(0, alınacakısmınuzunlupu);
            //Console.WriteLine($"{sonucMetın} = {toplam}");


            //5*5 lik kare biçiminde içi yıldız olan kareyi yazfıan proram


            //int satır = 5;
            //int sutun = 5;
            //for (int i = 0; i < satır; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            // 5*5 lik içi boş kareyi yapın

            int satır = 5;
            int sutun = 5;
            for (int i = 1; i < satır; i++)
            {
                for (int j = 1; j < sutun; j++)
                {
                    if (i==1 || i==satır)
                         
                    {
                        Console.Write("*");
                    }
                    else if (j==1 || j==sutun)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                   
                }

                Console.WriteLine();


            }

            // üstki içi boş kareyi adım adım çalıştırıp deneyiniz.

            // ödev1 : 1 le 100 arasındaki sayıların ortalamasını bulduan sayı
            // ödec2: 1-100 arasındaki çift tek ve 5in katı olan sayıların adetleri ve toplamlarını ekrana yazdıran program.
            //ödev3: aşağıdakileri yüksekliği 5 tabanı 9 br olan *'lardan oluşan dik üçgeni çizdiren program

          






        }

    }
    }
    
