using System;

class Program 
{
    static void Main()
    {
        Console.Write("Upisite  cijeli broj:");
        int broj = int.Parse(Console.ReadLine()!);

       if (broj ==0)
       {
            Console.WriteLine("Broj je nula.");
       }
       else
       {
        if (broj>0)
            Console.WriteLine("Broj je pozitivan.");
        else
            Console.WriteLine("Broj je negativan.");
        
        if (broj % 2 == 0)
            Console.WriteLine("Broj je paran.");
        else
            Console.WriteLine("Broj je neparan.");
       } 

    }
}