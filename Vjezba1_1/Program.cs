using System;
class Program
{
    static void Main()
    {
        Console.Write("Unesi prvi broj: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Unesi drugi broj: ");
        int b = int.Parse(Console.ReadLine()!);

        int zbroj = a+b;

        Console.WriteLine("zbroj je: " + zbroj);
    }
}