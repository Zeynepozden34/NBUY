using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje04_VerilerinErisimSınıfı
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }  

    }
     public class Customer
    {
        public string Id { get; set; } 
        public string CompanyName { get; set; }
       
        public string City { get; set; }
        public string Country { get; set; }
    }
}