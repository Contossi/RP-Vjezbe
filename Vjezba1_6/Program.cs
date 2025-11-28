using System;
class Pravokutnik
{
    private double sirina;
    private double visina;

    public Pravokutnik(double s, double v)

    {
        sirina = s;
        visina = v;
    }

    public double Povrsina()
    {
        return sirina*visina;
    }

    public double Opseg()
    {
        return 2*(sirina + visina);
    }
}
class Program
{
    static void Main()
    {
        Pravokutnik p1= new Pravokutnik(3,4);
        Pravokutnik p2= new Pravokutnik(5.5,2);
        Pravokutnik p3= new Pravokutnik(10,1.2);

        Console.WriteLine("P1:povrsina= " + p1.Povrsina()+", opseg = " + p1.Opseg());
        Console.WriteLine("P2:povrsina= " + p2.Povrsina()+", opseg = " + p2.Opseg());
        Console.WriteLine("P3:povrsina= " + p3.Povrsina()+", opseg = " + p3.Opseg());
    }
}