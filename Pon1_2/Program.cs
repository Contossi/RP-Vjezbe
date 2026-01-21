using System;
using System.Collections.Generic;

class Product
{
    public string Name {get; set;}
    public double Price {get; set;}
}

class Program
{
    static void DisplayExpensiveProducts(List<Product> products)
    {
        Console.WriteLine("Proizvodi skuplji od 100: ");
        foreach (var p in products)
        {
            if (p.Price > 100)
                Console.WriteLine($"{p.Name}-{p.Price} Eu");
        }
    }

    static void Main()
    {
        List<Product> products = new List<Product>();
        
        for (int i= 0; i<5; i++)
        {
            Product p = new Product();
            Console.Write($"Unesi naziv {i+1}. proizvoda: ");
            p.Name = Console.ReadLine();

            Console.Write($"Unesi cijenu {i+1}. proizvoda: ");
            p.Price = double.Parse(Console.ReadLine());

            products.Add(p);
        }

        DisplayExpensiveProducts(products);
    }
}