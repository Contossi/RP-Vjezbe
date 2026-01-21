using System;
using System.Linq;

class PasswordValidate
{
    public bool Validate(string password)
    {
        if (password.Length < 8) return false;
        if (!password.Any(char.IsUpper)) return false;
        if (!password.Any(char.IsDigit)) return false;
        return true;
    }
}

class Program
{
    static void Main()
    {
        PasswordValidate validator = new PasswordValidate();

        Console.Write("Unesi lozinku: ");
        string lozinka = Console.ReadLine()!;

        if (validator.Validate(lozinka))
            Console.WriteLine("Lozinka je valjana");
        else
            Console.WriteLine("Lozinka nije valjana.");
    }
}