using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;


var mt= new MultiTable();
mt.MusteriSayisi();
mt.SatisYapilanMusteriler();
mt.SatisYapilmayanMusteriler();
mt.MusteriSatisListesi();





// NorthwindContext context = new NorthwindContext();

//Customer listesi alıyor
// List<Customer> customers = context.Customers.ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// }

//London'da yaşayan Customerların listesi

// List<Customer> customers = context.Customers.Where(c=>c.City=="London").ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }
// Console.WriteLine("Bitti...");

//London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim
// var customers = context
//     .Customers
//     .Select(c=>new {c.CompanyName, c.ContactName, c.City})
//     .Where(c=>c.City=="London")
//     .ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim
//Nesne kullanarak


// List<CustomerModel> customers = context
//     .Customers
//     .Select(c=>new CustomerModel() {
//         CompanyName=c.CompanyName,
//         ContactName=c.ContactName,
//         City=c.City
//         })
//     .Where(c=>c.City=="London")
//     .ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//Beverages kategorisindeki ürünlerin listsi
// var bevaragesProducts = context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages")
//     .ToList();

// foreach (var p in bevaragesProducts)
// {
//     Console.WriteLine(p.ProductName);
// }

//Suppliers tablosundaki Germany'de yaşayanları listeleyin
// var suppliersInGermany = context
//     .Suppliers
//     .Where(s=>s.Country=="Germany")
//     .ToList();
// foreach (var s in suppliersInGermany)
// {
//     Console.WriteLine(s.CompanyName);
// }
//Nancy adlı çalışının yaptığı satışlar
// var ordersOfNancy = context
//     .Orders
//     .Where(o=>o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
//     .ToList();

// foreach (var o in ordersOfNancy)
// {
//     Console.WriteLine(o.OrderId);
// }
// Console.WriteLine($"Toplam satış sayısı: {ordersOfNancy.Count()}");

//Productları id'e göre büyükten küçüğe sıralı bir şekilde listeleyiniz.
// var products =context
// .Products
// .OrderByDescending(p=>p.ProductId)          // OrderByDescending Büyükten küçüğe sıralar. order by küçükten büyüğe sıralar
// .ToList();


// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }


//En son satılan beş ürünü listeleyelim.
// var products =context
// .Products
// .OrderByDescending(p=>p.ProductId)
// .Take(5)                                      //take ilk beş kaydı verir.
// .ToList();


// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }

// Fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim, fiyata göre küçükten büyüğe sıralayalım

// var products=context
// .Products
// .OrderBy(p=>p.UnitPrice)
// .Where(P=>P.UnitPrice>=10 && P.UnitPrice<=20)
// .Select(p=>new {                                            // buradaki new sadece aşağıdaki iki sutunu getirir.
//     p.ProductName,
//     p.UnitPrice
// })
// .ToList();


// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName} --> {p.UnitPrice}");
// }

//BEVERAGES KATEGORSİNDEKİ ORTALAMA FİYATI YAZDIRALIM.
// var ortalama =context
// .Products
// .Where(p=>p.Category.CategoryName=="Beverages")
// .Average(p=>p.UnitPrice); //average to list yapmadan sadece istenileni yazdırır.

// System.Console.WriteLine($"Beverages categori ortalaması: {ortalama}");


// //BEVERAGES KATEGORSİNDEKİ ürün adedi YAZDIRALIM.
// var adet =context
// .Products
// // .Where(p=>p.Category.CategoryName=="Beverages")
///// .Count();
// .Count(p=>p.Category.CategoryName=="Beverages");

// System.Console.WriteLine($"Beverages ürün adedi: {adet}");


//beverages ve condiments categoreilerinde toplam kaç adet ürün vardır

// var adet =context
// .Products
// .Count(p=>p.Category.CategoryName=="Beverages" || p.Category.CategoryName=="Condiments");

// System.Console.WriteLine($"Toplam ürün adedi: {adet}");


//Adının içinde tofu  geçen ürüleri listeleyelim
// var products=context
// .Products
// .Where(p=>p.ProductName.Contains("tofu"))
// .ToList();;

//  foreach (var p in products)
//  {
//      System.Console.WriteLine($"{p.ProductName}");
//  }


//En ucuz ve en pahalı ürün hangisidir.
// var minPrice = context.Products.Min(p=>p.UnitPrice);
// var maxPrice = context.Products.Max(p=>p.UnitPrice);

// var minProduct =context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=> new{
//     p.ProductName,
//     p.UnitPrice
// }).FirstOrDefault(); // FirstOrDefault() Karşısına çıkan ilk bilgiyi alır.

// var maxProduct =context
// .Products
// .Where(alex=>alex.UnitPrice==maxPrice)    // adını değiştirdiğim p'lerin ismi önemli değil sıradaki her bilgiyi getirmek için kullanacağım ismi yazıyorum
// .Select(hooijonk=> new{
//     hooijonk.ProductName,
//     hooijonk.UnitPrice
// }).FirstOrDefault();


// System.Console.WriteLine($"Minumum price: {minPrice} --> product: {minProduct.ProductName}--{minProduct.UnitPrice}");
// System.Console.WriteLine($"Maximum price: {maxPrice} --> product: {maxProduct.ProductName}--{maxProduct.UnitPrice}");


//en düşük fiyatlı veen yüksek fiaytlaı listeleyin
// var minPrice = context.Products.Min(p=>p.UnitPrice);
// var maxPrice = context.Products.Max(p=>p.UnitPrice);

// var MinProducts=context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=> new{
//   p.ProductName
// })
// .ToList();
// System.Console.WriteLine($"En ucuz: {minPrice} Fiyatı en düşük olanlar: ");
//  foreach (var p in MinProducts)
//   {
//       System.Console.WriteLine($"{p.ProductName}");
//   }


// var MaxProducts=context
// .Products
// .Where(p=>p.UnitPrice==maxPrice)
// .Select(p=> new{
//   p.ProductName
// })
// .ToList();

// System.Console.WriteLine($"En Pahalı: {maxPrice} Fiyatı en yüksek olanlar: ");
//  foreach (var p in MaxProducts)
//   {
//       System.Console.WriteLine($"{p.ProductName}");
//   }


// class CustomerModel
// {
//     public string? CompanyName { get; set; }
//     public string? ContactName { get; set; }
//     public string? City { get; set; }
// }


