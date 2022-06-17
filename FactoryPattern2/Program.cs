using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAnother = true;


            while (accessAnother == true) 
            {
                Console.WriteLine("Which database would you like to use: list, SQL, or mongo?");
                var response = Console.ReadLine();
                Console.WriteLine();

                IDataAccess database = DataAccessFactory.GetDataAccessType(response);
                List<Product> products = database.LoadData();

                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                }

                Console.WriteLine();
                Console.WriteLine("When finished, press \'Return\'");
                Console.ReadLine();
                database.SaveData();

                Console.WriteLine("Would you like to access another database?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "y")
                {
                    accessAnother = true;
                    Console.WriteLine();
                }
                else
                {
                    accessAnother = false;
                }

            }

            Console.WriteLine("Finished accessing databases.");
            Console.ReadLine();
        }

        
    }
}

