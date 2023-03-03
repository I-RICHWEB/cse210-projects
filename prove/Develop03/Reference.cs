using System;

public class Reference
{
    public string _respond;
    public void Menu()
    {
        Console.WriteLine("1. Add a scripture you want to memorize.");
        Console.WriteLine("2. memorize random scripturs from Matthew 5.");
        Console.WriteLine("3. Load from your added scriptures.");
        Console.WriteLine("4. Close the program.");
        Console.Write("Enter an option. >");
        _respond = Console.ReadLine();
    }
}