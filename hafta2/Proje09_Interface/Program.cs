namespace Proje09_Interface
{
    //Interface'ler için belirtilmediğinde default erişim belirleyici public'tir.
    // Interface'ler protected, privated yada static olarak işaretlenemezler.
    //Interdace'ler içinde çalışan kod olmaz.yani metotların sadece imzası olur.
    // Bir interface bir yada daha fazla interfaceedn miras alabilir.,
    //Bir interface bir classtan miras alamaz.
    //Eğer bir class bir interfacden miras alıyorsa miras aldığı interface'daki tüm metetları implemente etmek zorundadır. (Implemente: miras alınan interface de imzası bulunan metotların içi dolu hallerini bize verir.)
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
    public class Program
    {
        static void Main(string[] args)
        {
            //Bir abstract class da miras alan class da
            //Eğer base class da abstract metotlar varsa mutlaka override edilmeli.
            //Eğer base class da abstract olmayan metotlar varsa olduğu gibi kullanlır 
            //Ancak bazen miras alınan clastaki her metoton içinin dolu hallerini yazmak zorunlu olsun isteriz.
            //Yani hepsi abstract olsun isteriz. Bunu yapmak yerine miras alınan classı class değil interface şeklinde tanımlarız.



            //IPersonel personel = new IPersonel(); //Hatalı Kullanım
            //Yönetici yönetici1 = new Yönetici();
            //Yönetici yönetici2 = new Yönetici("Alex de Souza","Rio de Jenerio", "5000", "Fotbol");
            //Console.WriteLine(yönetici2.Maas);
            //Console.ReadLine();



            Product product1 = new Product()
            {
                Id = 1,
                Name = "IPhone 13",
                Price = 5000,
                Properties = "8 gb Ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now,

            };
            Console.WriteLine($" Product Name: {product1.Name}(Büyük Harf: {product1.NameToUpper(product1.Name)}) )Properties: {product1.Properties}");

            Category category1 = new Category()
            {
                Id = 1,
                Name = "IPhone 13",
                CreatedDate = DateTime.Now,
                Description = "Bu kategori telefonşar içindir."
            };
            Console.WriteLine($" Product Name: {category1.Name}(Büyük Harf: {category1.NameToUpper(category1.Name)})Description: {category1.Description} Created: {category1.CreatedDate})");
        }
       




    }
}