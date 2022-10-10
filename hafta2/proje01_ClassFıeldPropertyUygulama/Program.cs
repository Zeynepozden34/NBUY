namespace proje01_ClassFıeldPropertyUygulama
{
    class product
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product claasımız olsun içinde name, price ve description 
            //istenildiği kadar product bilgisi girilmesini sağlayalım
            // ka adet product girileceğini kullanıcı belirlesin
            //productlar ekleme işi bitince, eklenmiş productlar listelensin.
            
            
            //Console.Write("Kaç adet ürün gireceksiniz?: ");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products= new Product[adet]; // product sınıfının products dizisine adet kadar ürün girecez 
            //Product product;
            //for (int i = 0; i < adet; i++)
            //{
            //    product = new Product(); // Product sınıfından product ürün değernedeğer atar.
            //    Console.Write("Product Name: "); 
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.Write("Description: ");
            //    product.Description = Console.ReadLine();

            //    products[i] = product;

            //}
            //Console.WriteLine("Product Name\t Price\tDescription" );
            //foreach (var prd in products)
            //{
            //    Console.WriteLine($"{prd.Name}\t {prd.Price}\t{prd.Description}");
            //}

            #region RastgeleDegerUreterek 
            product[] products = new product[5]; // productlar diilerden rastgele gelsin.
            product product;
            String[] nameArray = { "Galaxy A50", "HP Notebook", "Macbook Air M2", "Iphone ", "LG" };
            String[] descriptionArray = { "İyi", "Kötü", "güzel", "HeyecanVerici", "Şaşırtıcı" };
            decimal[] oldPrices = new decimal[5];
            Random random = new Random();
            Console.WriteLine("Yapılacak zam oranını giriniz: ");
            decimal oran = decimal.Parse(Console.ReadLine());
            
            for (int i = 0; i < 5; i++)
            {
                product = new product();
                {
                    product.name = nameArray[random.Next(0, 5)];
                    product.description = descriptionArray[random.Next(0, 5)];
                    product.price = random.Next(1000, 2000);

                }
                oldPrices[i] = product.price;
                product.price = product.price * (1 + (oran / 100));
            }
            //Padleft ilk başta boşluk bırakır
            //yazılacak kelimenin harf sayısınan sonra istenilen kadar boşluk bırakıp yazabilmeni saglar.

            Console.WriteLine("Product Name".PadRight(20)+"Old Price".PadRight(10)+"Price".PadRight(10)+ "Description");
            int j = 0;


            foreach (var prd in products)
            {

                Console.WriteLine($"{prd.name.PadRight(20)}{prd.price.ToString().PadRight(10)}{oldPrices[j].ToString().PadRight(10)}{prd.price.ToString().PadRight(10)} {prd.description}");
            }


            #endregion

        }

    }
}