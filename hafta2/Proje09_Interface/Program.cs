namespace Proje09_Interface
{
    interface IPersonel
    {
        public string Departman { get; set; }

    }
    interface IKisi  // ınterface olduğunu anlamak için başına "I" yazdık.
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
      
        public string Maas { get; set; }
        public void Bilgi(); //Interface içindeki metotlarda sadece imza bulunur "(public int Bilgi())" metotun gövdesi"(süslü parantez)" olmaz. Metotun gövdesi bu interfaceyi miras alan class içinde doldurulur.. Bir class birden fazla interfaceden miras alabilir. ama bir class birden fazla classtan miras alamaz. Interface new yapılamaz!!
    }
    class Yönetici : IKisi, IPersonel
       
    {
        /// <summary>
        /// Bumetot bir yönetici bilgisi girmededn yönetici oluşturur.
        /// </summary>
        public Yönetici()
        {
            // Kimi zaman AdSoyad, Adres, Maas, Departman bilgisi vermeden yönetici çalıştırmak istediğimizde çalışır.
        }
        /// <summary>
        ///  Bu metot, AdSoyad, Adres, Maas ve Departman bilgileri girilerek Yonetici oluşturur.
        /// </summary>
        /// <param name="adSoyad"></param>
        /// <param name="adres"></param>
        /// <param name="maas"></param>
        /// <param name="departman"></param>
        public Yönetici(string adSoyad, string adres, string maas, string departman)
        {
            
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }
        public void Bilgi()
        {
            Console.WriteLine($"Ad Soyad: {AdSoyad}  Departman: {Departman}");
        }

        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; }

        

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir abstract class da miras alan class da
            //Eğer base class da abstract metotlar varsa mutlaka override edilmeli.
            //Eğer base class da abstract olmayan metotlar varsa olduğu gibi kullanlır 
            //Ancak bazen miras alınan clastaki her metoton içinin dolu hallerini yazmak zorunlu olsun isteriz.
            //Yani hepsi abstract olsun isteriz. Bunu yapmak yerine miras alınan classı class değil interface şeklinde tanımlarız.



            //IPersonel personel = new IPersonel(); //Hatalı Kullanım
            Yönetici yönetici1 = new Yönetici();
            Yönetici yönetici2 = new Yönetici("Alex de sozu","Rio de Jenerio", "500", "Fotbol");
            Console.WriteLine($"{yönetici2}");
            Console.ReadLine();
        }
    }
}