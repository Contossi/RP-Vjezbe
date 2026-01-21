using System;

class Program {
    static void Main() {
        Console.Write("Unesi znak: ");
        char znak = Console.ReadLine()[0];
       
        if (znak>='0' && znak <= '9')
            Console.WriteLine("Znak je brojka.");
        else if (znak >= 'A' && znak <='Z')
            Console.WriteLine("Znak je veliko slovo.");
        else if (znak >= 'a' && znak <='z')
            Console.WriteLine("Znak je malo slovo.");
        else
            Console.WriteLine("Znak je nesto drugo.");
    }
}