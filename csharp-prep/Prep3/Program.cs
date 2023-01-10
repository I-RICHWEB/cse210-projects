using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Welcome to the number gussing game.");
        string playAgain = "";
        int countPlayTimes = 0;

        while (playAgain != "no")
        {
            countPlayTimes += 1;
            Random magicNum = new Random();
            int magicNumber = magicNum.Next(1, 101); 
            int guess = 0;
            int count = 0;

            while (guess != magicNumber)
            {
                count += 1;
                Console.Write("Guess the number: ");
                string guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);
                if (guess > magicNumber)
                {
                    Console.WriteLine("Guess lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Guess higher");
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                    Console.WriteLine($"You guess {count} times. ");
                }
            }
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        
        Console.WriteLine($"You played {countPlayTimes} times.");
        Console.WriteLine("Thanks for playing, bye!");
    }
}