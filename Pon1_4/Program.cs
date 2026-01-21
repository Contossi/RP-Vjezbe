using System;
using System.Collections.Generic;

class Student
{
    public string Ime {get; set;}
    public string Prezime {get; set;}
    public int Godine {get; set;}
}

class Kolegij
{
    public string Naziv {get; set;}
    public List<Student> Studenti{get; set;} = new List<Student>();
}

class Program
{
    static void Main()
    {
        List<Kolegij> kolegiji = new List<Kolegij>
        {
            new Kolegij {Naziv = "Matematika", Studenti = new List<Student>
                { new Student{ Ime= "Ana", Prezime = "Ivic", Godine=20},
                  new Student{ Ime= "Marko", Prezime = "Kovac", Godine=21}}},
            new Kolegij {Naziv = "Fizika", Studenti = new List<Student>
                { new Student{ Ime= "Luka", Prezime = "Horvat", Godine=21},
                  new Student{ Ime= "Mia", Prezime = "Babic", Godine=23}}},
            new Kolegij {Naziv = "Kemija", Studenti = new List<Student>
                { new Student{ Ime= "Ivan", Prezime = "Novak", Godine=23},
                  new Student{ Ime= "Sara", Prezime = "Peric", Godine=21}}},
        };
        while (true)
        {
            Console.WriteLine("\nOpcije:");
            Console.WriteLine("1. Pregled kolegija i studenta");
            Console.WriteLine("2. Brisanje studenta");
            Console.WriteLine("3. Upis novog studenta");
            Console.WriteLine("4. Izlaz");
            Console.Write("Odaberi opciju: ");
            string choice = Console.ReadLine()!;

            if (choice == "1")
            {
                foreach (var k in kolegiji)
                {
                    Console.WriteLine($"\n{k.Naziv}:");
                    foreach (var s in k.Studenti)
                        Console.WriteLine($"{s.Ime} {s.Prezime},{s.Godine} godina");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Unesi naziv kolegija: ");
                string naziv = Console.ReadLine()!;
                Kolegij k = kolegiji.Find(x=> x.Naziv == naziv);
                if (k != null)
                {
                    Console.Write("Unesi ime i prezime studenta za brisanje: ");
                    string imePrezime = Console.ReadLine()!;
                    Student s=k.Studenti.Find(x => (x.Ime + " "+ x.Prezime)== imePrezime);
                    if (s!=null)
                    {
                        k.Studenti.Remove(s);
                        Console.WriteLine("Student je obrisan.");
                    }
                    else
                        Console.WriteLine("Student nije pronaden.");
                }
                else
                    Console.WriteLine("Kolegij nije pronaden.");
            }
            else if (choice =="3")
            {
                Console.Write("Unesi naziv kolegija: ");
                string naziv = Console.ReadLine()!;
                Kolegij k = kolegiji.Find(x => x.Naziv == naziv);
                if (k  != null)
                {
                    Student novi = new Student();
                    Console.Write("Ime: ");
                    novi.Ime = Console.ReadLine()!;
                    Console.Write("Prezime: ");
                    novi.Prezime = Console.ReadLine()!;
                    Console.Write("Godine: ");
                    novi.Godine = int.Parse(Console.ReadLine()!);
                    k.Studenti.Add(novi);
                    Console.WriteLine("Student upisan");
                }
                else
                    Console.WriteLine("Kolegij nije pronaden");
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