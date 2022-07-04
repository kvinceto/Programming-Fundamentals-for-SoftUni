using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> listOfProducts = new Dictionary<string, Product>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "buy")
                {
                    break;
                }

                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                Product product = new Product(name, price, quantity);
                if (listOfProducts.ContainsKey(name))
                {
                    Product updatedProduct = listOfProducts[name];
                    updatedProduct.Quantity += quantity;
                    updatedProduct.Price = price;
                    listOfProducts[name] = updatedProduct;
                }
                else
                {
                    listOfProducts.Add(name, product);
                }
            }

            listOfProducts.ToList().ForEach(p =>
                Console.WriteLine($"{p.Key} -> {(p.Value.Price * p.Value.Quantity):f2}"));

        }
    }

    class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
