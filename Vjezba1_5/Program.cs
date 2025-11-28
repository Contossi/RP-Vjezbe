using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 2)
        {
            Console.WriteLine("Broj nije prost.");
            return;
        }
        bool prost = true;

        for(int i = 2; i*i <= n; i++)
        {
            if(n%i==0)
            {
                prost = false;
                break;
            }
        }
        
        if (prost)
        {
            Console.WriteLine("Broj je prost.");
        }
        else
        {
            Console.WriteLine("Broj nije prost.");
        }
    }
}