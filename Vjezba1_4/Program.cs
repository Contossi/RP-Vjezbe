using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesi n: ");
        int n =int.Parse(Console.ReadLine()!);

        int a = 0,b = 1;

        for (int i=0; i<n; i++)
        {
            Console.WriteLine(a);
            int sljedeci = a+b;
            a=b;
            b = sljedeci;
        }
    }
}