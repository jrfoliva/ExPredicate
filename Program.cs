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

            //list.RemoveAll(FiltredProduct); // Passado função estática como referência. 

            //list.ForEach(UpdateProduct); // ou, outra forma...
            //list.ForEach(p => p.Price *= 1.1); // usando lambda, ou ...
            Action<Product> act = p => { p.Price *= 1.10; }; // Neste caso necessita o uso de chaves.

            list.ForEach(act) ;
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

        public static void UpdateProduct(Product product)
        {
            product.Price += product.Price * 0.10;
        }
    }
}