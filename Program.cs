using System.Collections.Generic;
using ExPredicate.Entities;

namespace ExPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(FiltredProduct); // Passado função estática como referência. 

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // método estático para realizar o filtro
        public static bool FiltredProduct(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}