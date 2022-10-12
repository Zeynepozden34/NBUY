namespace Proje12_OOP_Work01_Tekrar
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }


    }
    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrencı> Ogrenciler { get; set; }

    }
    class Ogrencı : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }


    }
    internal class Program
    {
        static string GirisYap(string baslık)
        {
            Console.WriteLine(baslık);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i < 2; i++)
            {
                Bolum bolum=new Bolum();
                Console.Write($"{i+1}.Bölüm Id Giriniz: ");
                bolum.Id = int.Parse(Console.ReadLine());
                Console.Write($"{i+1}.Bölümün Adı: ");
                bolum.Ad = Console.ReadLine();
                Console.Write($"{i + 1}.Bölümün Açıklaması: ");
                bolum.Aciklama = Console.ReadLine();
                bolumler.Add(bolum);
                List<Ogrencı> ogrenciler = new List<Ogrencı>();
                for (int j = 0; j < 3; j++)
                {
                    Ogrencı ogrencı = new Ogrencı();
                    Console.Write($"{j+1}.Ogrenci ıd: ");
                    ogrencı.Id = int.Parse(Console.ReadLine());
                    Console.Write($"{j + 1}.Ogrenci Ad: ");
                    ogrencı.Ad = Console.ReadLine();
                    Console.Write($"{j + 1}.Ogrenci Soyad: ");
                    ogrencı.Soyad= Console.ReadLine();
                    Console.Write($"{j + 1}.Ogrenci Numara: ");
                    ogrencı.OgrNo = int.Parse(Console.ReadLine());
                    Console.Write($"{j + 1}.Ogrenci yas: ");                    
                    ogrencı.Yas = int.Parse(Console.ReadLine());
                    ogrenciler.Add(ogrencı);
                    
                }
                bolum.Ogrenciler=ogrenciler;
                bolumler.Add(bolum);

            }
            foreach (var bolum in bolumler)
            {
                Console.Write($"Bölüm Id: {bolum.Id}, Bölüm Adı: {bolum.Ad}, bölüm Açıklama: {bolum.Aciklama}");
                foreach (var ogrencı in bolum.Ogrenciler)
                {
                    Console.Write($"Ogrencı Id: {ogrencı.Id}, ogrencı Adı: {ogrencı.Ad}, ogrencı soyad: {ogrencı.Soyad} ogrenci nu: {ogrencı.OgrNo}, ogrenci yaşı: {ogrencı.Yas}");
                }
            }

            Console.ReadLine();

        }
        
    }
}