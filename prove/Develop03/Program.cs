using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the scripture memorizer program!");
        Console.WriteLine("This program will help you to memorize scriptures by hidding words at random.");
        Console.WriteLine();

        Reference R1 = new Reference();
        R1.Menu();
        string start = R1._respond;
        while (start != "4")
        {
           
            if (start == "1")
            {
                Scripture a1 = new Scripture();
                a1.AddPersonalScripture();
            }
            else if (start == "2")
            {

                Scripture matt1 = new Scripture();
                matt1.Matthew();
                matt1.RandomScripture();
            }
            else if (start == "3")
            {
                Scripture load1 = new Scripture();
                load1.Load();
               
            }
            R1.Menu();
            start = R1._respond;
        }
    }
}