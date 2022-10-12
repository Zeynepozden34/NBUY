namespace Proje12_OOP_Work_01
{
    interface Iclass
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public class Ogrenci : Iclass
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrenciNo { get; set; }
        public int Yas { get; set; }
    }
    public class Bolum : Iclass
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }

        public string Acıklama { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("id giriniz: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ad giriniz: ");
            s

            2 kere bölüm
                3 öğrenci

                for (int i = 0; i < 2; i++)
            {
                //bölüm al
                // öğrenci listesi oluştur
                for (int i = 0; i < 3; i++)
                {

                }
            }   

            List<Bolum> OgrencıBılgısı = new List<Bolum>()
            {
               

                new Bolum()
                {
                    Id = id,
                    Ad = Console.ReadLine(),
                    Ogrenci = new List<Ogrenci>(),
                    Acıklama=Console.ReadLine()                     
                    
                }
            };
            new Bolum()
            {
                Id = 10,
                Ad = "Mat",
                Ogrenci = new List<Ogrenci>() { new Ogrenci() { Ad = "Defne", Id = 145, OgrenciNo = 154, Soyad = "Dile", Yas = 20 } }
            };
            new Bolum()
            {
                Id = 10,
                Ad = "Mat",
                Ogrenci = new List<Ogrenci>() { new Ogrenci() { Ad = "Sinan", Id = 15, OgrenciNo = 14, Soyad = "Dilem", Yas = 25 } }
            };


            
            Console.ReadLine();
        }
    }
}