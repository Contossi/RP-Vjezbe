using System;
class Program
{
    static void Main()
    {
        Console.Write("Unesi broj: ");
        int broj = int.Parse(Console.ReadLine()!);

        if(broj % 2 == 0)
            Console.WriteLine("Broj je paran");
        else
            Console.WriteLine("Broj je neparan");
    }
}