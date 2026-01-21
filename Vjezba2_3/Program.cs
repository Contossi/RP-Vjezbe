using System;

class Program{
    static void Main(){
        Console.Write("Unesi prvi broj: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Unesi drugi broj: ");
        int b = int.Parse(Console.ReadLine()!);

        if (a<b)
            Console.WriteLine("Veci je: "+b+", manji je: "+a);
        else if (b<a)
            Console.WriteLine("Veci je: "+a+", manji je: "+b);
        else if (b==a)
            Console.WriteLine("Oba broja su ista.");
    }
}