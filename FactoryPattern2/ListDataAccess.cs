using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "10lb Dog Kibble", Price = 12.99m},
            new Product() { Name = "20lb Dog Kibble", Price = 19.99m},
            new Product() { Name = "100z Bacon Treats", Price = 8.49m},
            new Product() { Name = "Jumbo Tug Rope", Price = 9.99m},
            new Product() { Name = "Kong Ball", Price = 12.99m}

        };

        public void SaveData()
        {
            Console.WriteLine("Saving data to your List Database.");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("Loading your list database:");
            return Products;
        }
    }
}

