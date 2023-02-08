using System;

public class Entries
{
    public string _currentDate;
    public string _prompt;
    public string _respond;

    public void Display()
    {
        Console.WriteLine($"Date: {_currentDate}. Prompt: {_prompt}.");
        Console.WriteLine(_respond);
        Console.WriteLine();
    }

}