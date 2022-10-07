namespace Proje15_ClassPropertyField
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Ogrenci Ogrenci1=new Ogrenci();
            Ogrenci1.OgrNo = 11;
            Ogrenci1.Ad = "Ahmet";
            Ogrenci1.Sinif = "9A";

            Ogrenci Ogrenci2 = new Ogrenci();
            Ogrenci2.OgrNo = 12;
            Ogrenci2.Ad = "Selim";
            Ogrenci2.Sinif = "10B";

            Ogrenci Ogrenci3 = new Ogrenci()
            {
                OgrNo = 15,
                Ad = "Umay",
                Sinif = "10C"
            };

            Ogrenci[] ogrenciler = {Ogrenci1,Ogrenci2,Ogrenci3};
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($"Ad: {ogrenciler[i].Ad},\tSınıf: {ogrenciler[i].Sinif}");
            //}

            foreach (var sıradakiOgrenci in ogrenciler)
            {
                Console.WriteLine(sıradakiOgrenci.Ad + "," + sıradakiOgrenci.Sinif);
            }


            //int[] sayılar = { 32, 54, 33 };
            //foreach (var sıradakiSayı in sayılar)
            //{
            //    Console.WriteLine(sıradakiSayı*sıradakiSayı);
            //}


        }
        class Ogrenci
        {
           
            private int ogrNo;

            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }

            private string ad;

            public string Ad
            {
                get { return ad.ToUpper(); }
                set { ad = value; }
            }

            public string Sinif { get; set; }

        }
    }
}