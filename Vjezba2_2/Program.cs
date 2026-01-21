using System;

class Program{
    static void Main() {
        Console.Write("Unesi realni broj x: ");
        double x = double.Parse(Console.ReadLine()!);

        double y;

        if (x >= 1 && x <= 100)
            y = x*5;
        else if (x >= -100 && x <= -1)
            y= x+5;
        else if (x >= 150 && x <= 200)
            y = x/5;
        else
            y=0;

        Console.WriteLine("y= " +y);    
    }
}