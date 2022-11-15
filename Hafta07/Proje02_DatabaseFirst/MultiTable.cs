using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje02_DatabaseFirst.efcore;

namespace Proje02_DatabaseFirst
{
    public class MultiTable
    {
        class CustomerModel
        {
            public string? CustomerId { get; set; }
            public string? CompanyName { get; set; }
            public string? ContactName { get; set; }
            public string? City { get; set; }
            public int? OrderCount { get; set; }
            public List<OrderModel>? Orders { get; set; }
        }

        class OrderModel
        {
            public int OrderId { get; set; }
            public DateTime? ShippedDate { get; set; }
            public decimal? Freigh { get; set; }
        }
        //Müşteri sayısı
        public void MusteriSayisi()
        {
            var context = new NorthwindContext();
            var result = context.Customers.Count();
            System.Console.WriteLine($"{result}");
        }

        //satış yapılan müşteri listesi
        public void SatisYapilanMusteriler()
        {
            //gelen listede her customere ait company name contact name ve city listele
            var context = new NorthwindContext();
            var customers = context
                .Customers
                .Where(c => c.Orders.Count() > 0)
                .Select(c => new CustomerModel
                {
                    CustomerId = c.CustomerId,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    City = c.City
                })
                .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"{c.CompanyName} -> {c.ContactName} -> {c.City} -> {c.CustomerId}");
            }
            System.Console.WriteLine($"Satış yapıla müşteri sayısı: {customers.Count()}");
        }

        //Satış yapılmayan müşterileri listeleyin
        public void SatisYapilmayanMusteriler()
        {
            var context = new NorthwindContext();
            var customers = context
                .Customers
                .Where(c => c.Orders.Count() == 0)
                .Select(c => new CustomerModel
                {
                    CustomerId = c.CustomerId,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    City = c.City
                })
                .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"{c.CompanyName} -> {c.ContactName} -> {c.City} -> {c.CustomerId}");
            }
            System.Console.WriteLine($"Satış yapılmayan müşteri sayısı: {customers.Count()}");
        }

        //Her müşterinin satışlarını ve kaç adet olduğnu gösterin.
        public void MusteriSatisListesi()
        {
            var context = new NorthwindContext();
            var customers = context
            .Customers
            .Select(c => new CustomerModel
            {
                CustomerId = c.CustomerId,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                City = c.City,
                OrderCount = c.Orders.Count(),
                Orders = c.Orders.Select(o => new OrderModel()
                {
                    OrderId = o.OrderId,
                    ShippedDate = o.ShippedDate,
                    Freigh = o.Freight
                }).ToList()
            }).ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"Id: {c.CustomerId} - Company Name: {c.CompanyName} - Order Count: {c.OrderCount}");
                foreach (var o in c.Orders)
                {
                    System.Console.WriteLine($"\t{o.OrderId} --> {o.ShippedDate} --> {o.Freigh}");
                }
                System.Console.WriteLine();
            }
        }
    }
}