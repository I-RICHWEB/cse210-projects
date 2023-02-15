using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fractions f1 = new Fractions();
        f1.DisplayFractions();
        f1.DisplayDecimals();

        Fractions f2 = new Fractions(5);
        f2.DisplayFractions();
        f2.DisplayDecimals();

        Fractions f3 = new Fractions(3,4);
        f3.DisplayFractions();
        f3.DisplayDecimals();

        Fractions fraction = new Fractions();
        fraction.SetTop(1);
        fraction.Setbottom(3);
        fraction.DisplayFractions();
        fraction.DisplayDecimals();
    }
}