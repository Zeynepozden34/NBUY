namespace proje14_ValueReferaceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;
            Random rnd = new Random();
            Kişi Kişi1 = new Kişi();
            Kişi1.Ad = "Zeynep";
            Kişi1.Yas = 23;
            Kişi1.Meslek = "Software Developer";

            Kişi Kişi2 = new Kişi();
            Kişi2.Ad = "Saliha";
            Kişi2.Yas = 25;
            Kişi2.Meslek = "Eğitmen";

            Kişi Kişi3 = new Kişi();
            Kişi3.Ad = "Merve";
            Kişi3.Yas = 27;
            Kişi3.Meslek = "Şair";


            Araba araba1 = new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "Siyah";

            DateTime bugun = DateTime.Now;
            Random rnd2 = new Random();

        }
        class Kişi  //bir classın içinde bir nesne belirtirip özelliklerinden bahsedeceksek property deriz.
        {
            public string? Ad { get; set; } // ad ın yeşil çizgisini siler. yeşil çizgi ad'ın boş olduğunu uyarıyor.
            public int Yas { get; set; }
            public string Meslek { get; set; }
            //*********** yukarıdaki bilgiyi tutmaz. bu bir şablondur. yeni bir nesne oluşturmamıza yardımcı olur bunu new komutuyla yapar 
        }

        class Araba  // class sınıfında public dışardan bilgiye erişebilmeye yarar. private ise dışardan erişilemezler.
        {
            public string Marka { get; set; }
            public string Renk { get; set; }
            string VitesTuru { get; set; } // Erişim belirleyici: Bir propertini dışarıdan yani içince bulunduğu classın dışından erişi seviyesini belirleyen anahtar sözcüklere denir. Herhangi bir erişim belirleyici kullanılmadıysa (default) ise erişim belirleyicisi private'dir.
            // Erişim Belirliyeciler
            //    1)public
            //    2)private
            //    3)internal
            //    4)protected




        }


    }
}