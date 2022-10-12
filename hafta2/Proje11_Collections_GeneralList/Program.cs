using System.Collections.Generic;

namespace Proje11_Collections_GeneralList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            //List<int> sayilar = new List<int>();
            //sayilar.Add(12);
            //sayilar.Add(120);
            //sayilar.Add(69);
            //sayilar.Add(28);
            //sayilar.Add(316);

            //List<string> isimler = new List<string>();
            //isimler.Add("Ali");
            //isimler.Add("Begüm");
            //isimler.Add("Defne");
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);

            //}
            //sayilar.Sort();
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            #endregion
            #region FirstSample

            // Product product1 = new Product() { Id = 1, Name = "PC", Price = 5000 };
            // Product product2 = new Product() { Id = 2, Name = "Telefon", Price = 4500 };
            // Product product3 = new Product() { Id = 3, Name = "Masa Sandalye Takımı", Price = 8000 };

            //// List<Product> products = new List<Product>() { product1, product2, product3 }; //  yukardakiyle aynı işlemi görür.

            // List<Product> products = new List<Product>();
            // products.Add(product1);
            // products.Add(product2);
            // products.Add(product3);

            //List<Product> products = new List<Product>()
            //{
            //    new Product() { Id=1, Name="Telefon", Price=19000},
            //    new Product() { Id= 2, Name="PC", Price=1000},
            //    new Product() { Id = 3, Name = "Masa Sandalye", Price = 7500 }
            //};
            ////Yeni bir liste yaratın adı da newProducts olsun yukarıdakiler gibi üç yeni ürün bilgisi girilsin.

            //List<Product> newproducts = new List<Product>()
            //{
            //    new Product() { Id=4, Name="Mouse", Price=100},
            //    new Product() { Id= 5, Name="Monitor", Price=200},
            //    new Product() { Id = 6, Name = "Buzdolabı", Price = 15500 }
            //};

            ////newProductlaru içindeki productları, products içine ekleyelim

            //products.AddRange(newproducts);

            ////products.ForEach(product => {    // "=>" landa foreachda sıadaki anlamına gelir.
            ////    Console.WriteLine($"{product.Name}- {product.Price}");
            ////    Console.WriteLine();

            ////});
            ////int ElemanSayısı = products.Count;
            ////Console.WriteLine(ElemanSayısı);

            //products.Insert(0, new Product() { Id = 21, Name = "gözlük", Price = 1200 });
            //products.InsertRange(3, newproducts);





            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name}- {product.Price}");
            //}
            //List<Product> products = new List<Product>()
            //{
            //    new Product() { Id=1, Name="Telefon", Price=19000},
            //    new Product() { Id= 2, Name="PC", Price=1000},
            //    new Product() { Id = 3, Name = "Masa Sandalye", Price = 7500 }
            //};
            //ProductModel productModel = new ProductModel()
            //{
            //    Id = 1,
            //    CategoryName = "Fİrst Category",
            //    Products = products
            //};
            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine($"\t{product.Name}");
            //}

            #endregion


            // İçinde 3 adet ProductModel tipinde veri barıdıran bir List oluşturu.
            //Her bir productModel içinde Product özelliğine 3 er adetProduct koyun.

            List<ProductModel> prodectModel = new List<ProductModel>()
            {
                new ProductModel()
                {
                    Id=1,
                    CategoryName="Bilgisayarlar",
                    Products=new List<Product>()
                    {
                        new Product(){Id=1, Name="Ürün1", Price=500},
                        new Product(){Id=2, Name="Ürün2", Price=2500},
                        new Product(){Id=3, Name="Ürün3", Price=5200}
                    }
                },
                new ProductModel()
                {
                    Id = 21,
                    CategoryName = "Telefonlar", 
                    Products = new List<Product>()
                    {
                        new Product() { Id = 12, Name = "Ürün15", Price = 5100 },
                        new Product() { Id = 22, Name = "Ürün25", Price = 2400 },
                        new Product() { Id = 32, Name = "Ürün35", Price = 400 }


                    } 
                },
                new ProductModel() 
                { 
                    Id = 31,
                    CategoryName = "Mobilyalar", 
                    Products = new List<Product>()
                    {
                        new Product() { Id = 13, Name = "Ürün18", Price = 7500 },
                        new Product() { Id = 23, Name = "Ürün28", Price = 700 },
                        new Product() { Id = 33, Name = "Ürün38", Price = 200 }


                    } 

                },

            };
            foreach (var productModel in productModel)
            {
                Console.WriteLine($);
            }




            Console.ReadLine();
        }
    }
}