using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        static void Greetings()
        {
            Console.WriteLine("Welcome to the Program.");
        }
        Greetings();
        static string Username()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        string name = Username();
        static int Number()
        {
            Console.Write("What is your favorite number?  ");
            string nums = Console.ReadLine();
            int num = int.Parse(nums);
            return num;
        }
        int squu = Number();
        static int Sqare(int para)
        {
            int squ = para * para;
            return squ;
        }
        int sq = Sqare(squu);
        Console.WriteLine($"{name}, the square of your number is: {sq} ");

    }        
}