using System;
using System.IO;

public class Journal
{
    public List<Entries> _entrylist = new List<Entries>();
    
    public string _fileName;

    public string Responds()
    {
       string _entries = Console.ReadLine();
       return _entries;
    }

    public string CurrentDateTime()
    {
        DateTime currentDateTime = DateTime.Now;
        string _date = currentDateTime.ToShortDateString();
        return _date;
    }

    public string PromptGenerator()
    {
        // Creating an instance of the PromptGen class.
        PromptGen prompts = new PromptGen();
        // Calling the Prompt method
        string promptings = prompts.Prompt();
        return promptings;
    }
    
    public void JournalDisplay()
    {
        int i = 0; 
        foreach (Entries jentry in _entrylist)
        {
            i ++;
            Console.Write($"{i}. ");
            jentry.Display();
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the file name?");
        Console.Write(">");
        _fileName = Console.ReadLine();
        if (File.Exists(_fileName))
        {
            _entrylist.Clear();

            string[] fileLines = File.ReadAllLines(_fileName);
            foreach (string line in fileLines)
            {
                string[] parts = line.Split("<>");
                string _date = parts[0];
                string _prompts = parts[1];
                string _response = parts[2];
                Entries fileEntry = new Entries();
                fileEntry._currentDate = _date;
                fileEntry._prompt = _prompts;
                fileEntry._respond = _response;
                _entrylist.Add(fileEntry);

            }
            Console.WriteLine();
            Console.WriteLine($"Your journal has been loaded from {_fileName} file.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Oops! This file dose not exist.");
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the file name?");
        Console.Write(">");
        _fileName = Console.ReadLine();
        using (StreamWriter journalFile = new StreamWriter(_fileName))
        {
            foreach (Entries records in _entrylist)
            {
                string theDate = records._currentDate;
                string thePrompt = records._prompt;
                string theRespond = records._respond;

                journalFile.WriteLine($"{theDate}<>{thePrompt}<>{theRespond}");
            }
            Console.WriteLine();
            Console.WriteLine($"Your journal has been saved to {_fileName} file.");
            Console.WriteLine();
        }
    }

    public void Edit()
    {
        Load();
        JournalDisplay();
        Console.Write("Enter the entry number you want to edit: ");
        string singleEntry = Console.ReadLine();
        int editingNumber = int.Parse(singleEntry);
        int theIndex = editingNumber - 1;
        Entries theEntry = _entrylist[theIndex];
        string date = theEntry._currentDate;
        string prom = theEntry._prompt;
        string oldrespond = theEntry._respond;
        Console.WriteLine($"Date: {date}. Prompt: {prom}.");
        Console.WriteLine(oldrespond);
        Console.WriteLine();
        Console.WriteLine("Enter your new respond");
        Console.Write(">");
        string theNewRespond = Console.ReadLine();
        Entries editEntry = new Entries();
        editEntry._currentDate = date;
        editEntry._prompt = prom;
        editEntry._respond = theNewRespond;
        _entrylist[theIndex] = editEntry;
        Console.WriteLine();
        Console.WriteLine("Your file has been updated.");
        Console.WriteLine();

    }

    public string Menu()
    {
        // Here I'm creating the menu for the user to select a choice.
        Console.WriteLine("1. Write on your journal.");
        Console.WriteLine("2. Display.");
        Console.WriteLine("3. Load Journal.");
        Console.WriteLine("4. Save to Journal.");
        Console.WriteLine("5. Edit Journal");
        Console.WriteLine("6. Quit program");
        Console.Write("What would you like to do?: ");
        // Collecting the user response
        string menu = Console.ReadLine();
        // Printing blank line.
        Console.WriteLine();
        
        return menu;
    }
    
}