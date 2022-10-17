namespace Proje01_Hello_World
{
    internal class Program // Ana scop başlangıç noktası
    {
        static void Main(string[] args) // ilk çalışacak metot
        {
            // değişkene isim verilirken;
            //1) alfanümerik karakterler kullanılmaz "_" hariç.
            //2) türkçe karakter kullanılmaz.(zorunlu değil)
            //3)özel yada ayrılmış sözcükler kullanılmaz.
            // değişken isimleri küçük veyabüyük harf duyarlıdır.
            // 5)"  /* ve */ arası yorum satırıdır. (comment satırı)
            /*
            string adSoyad;
            adSoyad = "Alex de Souza";
            Console.WriteLine(adSoyad); 
            */
            /*
            int yas;
            yas = 19;
            Console.WriteLine(yas);

            string adSoyad = "Ahmet Candan";
            Console.WriteLine(adSoyad);

            Console.WriteLine("adı:" +adSoyad + " yaş:"+ yas) ;
            */

            //tam sayı
            // Console.WriteLine(byte.MinValue + "-" + byte.MaxValue);
                    byte sayi2 = 255;
                    int sayi1 = 45;
                    long sayi3 = 1521444889964;

            //ondalıklı sayılarda floata değer atarken ondalıklı sayının yanına "f" yazılmalıdır. ondalıklı sayıların hassasiuetinde kullanılır.
            //ondalıklı sayılarda decimale değer atarken ondalıklı sayının yanına "m" yazılmalıdır. parasal değerlerde kullanılır.

                    float a =10.5f;
                   double b = 20.2;
                   decimal c = 100.65m;

            // KARAKTER, char tipine tek bir karakter ataması yapılır.

            char cinsiyet = 'K';


            // MANTIKSAL, true yada false durumlarında bool tipi kullanılır.
            bool evliMi = true;

        }
    }
}
