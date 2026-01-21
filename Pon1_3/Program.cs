using System;
using System.Collections.Generic;

class Books
{
    public string Naslov {get; set;}
    public int Quantity {get; set;}
}

class Program
{
    static void Main()
    {
        List<Books> books  = new List<Books>
        {
            new Books { Naslov = "Knjiga1", Quantity = 5},
            new Books { Naslov = "Knjiga2", Quantity = 8},
            new Books { Naslov = "Knjiga3", Quantity = 2},
            new Books { Naslov = "Knjiga4", Quantity = 3},
            new Books { Naslov = "Knjiga5", Quantity = 6}
        };

        while(true)
        {
            Console.WriteLine("\nOpcije:");
            Console.WriteLine("1. Pregled stanja knjiga");
            Console.WriteLine("2. Posudba knjige");
            Console.WriteLine("3. Vraćanje knjige");
            Console.WriteLine("4. Izlaz");
            Console.Write("Odaberi opciju: ");
            string choice = Console.ReadLine()!;

            if (choice == "1")
            {
                Console.WriteLine("Stanje knjiga:");
                foreach (var b in books)
                Console.WriteLine($"{b.Naslov}-{b.Quantity} kom");
            }
            else if (choice == "2")
            {
                Console.Write("Koju knjigu zelis posuditi? ");
                string bookname = Console.ReadLine();
                Books b = books.Find(x => x.Naslov == bookname);
                if (b != null && b.Quantity > 0)
                {
                    b.Quantity--;
                    Console.WriteLine("Knjiga posuđena.");
                }
                else Console.WriteLine("Knjiga nije dostupna.");
            }
            else if (choice == "3")
            {
                Console.Write("Koju knjigu vracas? ");
                string bookName = Console.ReadLine();
                Books b = books.Find(x => x.Naslov == bookName);
                if (b != null)
                {
                    b.Quantity++;
                    Console.WriteLine("Knjiga vracena.");
                }
                else
                    Console.WriteLine("Takva knjiga ne postoji.");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Izlazak iz programa....");
                break;
            }
            else
                Console.WriteLine("Neispravan odabir.");
            
        }
    }
}