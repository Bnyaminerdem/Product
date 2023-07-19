using System;

namespace Product
{
    internal class Program
    {
        class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
        }

        static void Main(string[] args)
        {
            Product[] products = new Product[3];

            products[0] = new Product
            {
                ProductName = "t-shirt",
                Price = 200,
                Description = "Black t-shirt"
            };

            products[1] = new Product
            {
                ProductName = "pants",
                Price = 300,
                Description = "White denim pants"
            };

            products[2] = new Product
            {
                ProductName = "cap",
                Price = 89,
                Description = "Black patterned cap"
            };

            Console.WriteLine("Products (Using For Loop):");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product Name: {products[i].ProductName}");
                Console.WriteLine($"Price: {products[i].Price} TL");
                Console.WriteLine($"Description: {products[i].Description}");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Products (Using Foreach Loop):");
            foreach (Product product in products)
            {
                Console.WriteLine($"Product Name: {product.ProductName}");
                Console.WriteLine($"Price: {product.Price} TL");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Products (Using While Loop):");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine($"Product Name: {products[j].ProductName}");
                Console.WriteLine($"Price: {products[j].Price} TL");
                Console.WriteLine($"Description: {products[j].Description}");
                Console.WriteLine();
                j++;
            }
        }
    }
}
