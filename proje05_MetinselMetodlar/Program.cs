namespace proje05_MetinselMetodlar;
class Program
{
    static void Main(string[] args)
    {
        // bu proje de metinsel işlemlere dair metotlar öğreneceğiz.
        //değişkeninuzunluğunu bulur
        // toLower küçük harfe çevirir. toUpper büyükharfe dönüştürür
        //compare karşılaştırmada kullanılır. büyük küçük harf duyarlıdır.
        // concat metinleri birleştirir.


        // string metin = "wissen akademie";
        //int uzunluk = metin.Length;
        //Console.WriteLine($"uzunluk:{uzunluk}");
        //Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");

        //string metin = "WİSSEN";
        //string kucukMetın = metin.ToLower();
        //Console.WriteLine(kucukMetın);
        //string BuyukMetın = metin.ToUpper();
        //Console.WriteLine(BuyukMetın);

        //string m1 = "wissen";
        //string m2 = "wissen akademie";
        //int sonuc=String.Compare(m1, m2);
        //Console.WriteLine(m1);
        //Console.WriteLine(m2);
        //Console.WriteLine(sonuc);

        /* Console.Write("1.Metni giriniz:");
         string m1 = Console.ReadLine();
         Console.Write("2.Metni giriniz:");
         string m2 = Console.ReadLine();
         int sonuc=String.Compare(m1, m2);
         if (sonuc==0)
         {
             Console.WriteLine("Girilen iki metin birbirine eşittir");

         }
         else
         {
             Console.WriteLine("girilen iki metin birbirinden farklıdır");
         }
        */
        // string m1 = "wissen";
        // string m2 = "wissen akademie";
        // string m3 = "işkur eğitimi";

        // string sonuc = String.Concat( m1, m2, m3);
        // Console.WriteLine(sonuc);



        // string ad = "zeynep";
        // int yas = 23;
        // string okul = " BAU";
        // BENİM ADIM ZEYNEP 23 YAŞINDAYIM CÜMLESİNİ + OPERATÖRÜ, CONCAT VE $ İLE YAPINIZ

        //Console.WriteLine($"benim adım {ad} yaşım {yas} okuduğum okul {okul}");

        //string sonuc1="Benim adım" + ad + "." + yas "yaşındayım. okuduğum okul" + okul;

        //string sonuc2=String.Concat("benim adım", ad.)


       // string metin = "Merhaba. Bu hafta eğitime başladık";
        //bool sonuc = metin.Contains("wissen");   // wissen geçiyor mu cümlede
        //Console.WriteLine(sonuc);

        string adres = "Selami ali mah. can sk. no:6 kadıköy/istanbul";
        //  bool sonuc = adres.EndsWith("istanbul");
        // bool sonuc2 = adres.StartsWith("istanbul");
        //Console.WriteLine(sonuc);
        //Console.WriteLine(sonuc2);

        // adres satırındaki c harfi kaçıncı sıradadır
        // string aranacakifade = "c";

        //int siraNo = adres.ToLower().IndexOf(aranacakifade.ToLower()); // adresi küçü harflere çevirip öyle aradılar.
        //Console.WriteLine($"c harfi {adres}içinde, {siraNo}.sıradadır.");



        //string metin = "Wissen Akademie";
        //Console.WriteLine($"metnin ilk hali: {metin}");
        //Console.WriteLine($"Akademie ifadesi silindikten sonraki hali: {metin.Remove(7)}");
        //Console.WriteLine($"Aka ifadesisilindikten sonraki hali: {metin.Remove(7,3)}");

        string urunAd = "Iphone 13 Pro";
        //iphone-13-pro haline getirelim. replace komutuyla yapılır.
        //string sonuc = (urunAd.Replace( " ","-")).ToLower(); //i harfi küçük oldu
        string sonuc = urunAd.ToLower().Replace(" ", "-"); 
        Console.WriteLine(sonuc);
        string sonuc2 = urunAd.Replace("Iphone", "Samsung");
        Console.WriteLine(sonuc2);



    }
}
