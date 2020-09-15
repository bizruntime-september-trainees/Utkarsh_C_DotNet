using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SerializeCollection
{

    class Product
    {
        public String Name { set; get; }
        public Double Price { set; get; }
        public DateTime ExpiryTime { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product
            {
                Name = "Product 1",
                Price = 99.95,
                ExpiryTime = new DateTime(2000, 12, 29, 0, 0, 0, DateTimeKind.Utc),
            };
            Product p2 = new Product
            {
                Name = "Product 2",
                Price = 12.50,
                ExpiryTime = new DateTime(2009, 7, 31, 0, 0, 0, DateTimeKind.Utc),
            };

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            Console.ReadKey();
        }
    }
}
