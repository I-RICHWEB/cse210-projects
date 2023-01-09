using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();
        int grade = int.Parse(gradeFromUser);
        int gradeA = 90;
        int gradeB = 80;
        int gradeC = 70;
        int gradeD = 60;
        string gradeLetter = "";
        string compliment = "";
        string signs = "";
        int positive = 7;
        int negative = 3;

        if (grade >= gradeA)
        {
            gradeLetter = "A";
        }
        else if (grade >= gradeB && grade < gradeA)
        {
            gradeLetter = "B";
        }
        else if (grade >= gradeC && grade < gradeB)
        {
            gradeLetter = "C";
        }
        else if (grade >= gradeD && grade < gradeC)
        {
            gradeLetter = "D";
        }
        else if (grade < gradeD)
        {
            gradeLetter = "F";
        }
        else
        {
            gradeLetter = "That is an incorrect value!";
        }

        if (grade >= gradeC)
        {
            compliment = "Congratulations, you passed the Course!";
        }
        else
        {
            compliment = "Sorry, you failed the Course. Prepare harder next time.";
        }

        int remender = grade % 10;
        if (remender >= positive && gradeLetter != "A" && gradeLetter != "F")
        {
            signs = "+";
        }
        else if (remender <= negative && gradeLetter != "F")
        {
            signs = "-";
        }
        else
        {
            signs = "";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}{signs}");
        Console.WriteLine(compliment);
    }
}