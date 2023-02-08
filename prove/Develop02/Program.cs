using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Your Journal Program!");
        Console.WriteLine("Select the number of what you would like to do.");

        Journal writting = new Journal();
        
        
        string menu = "";
        // Initiating the while loop.
        while (menu != "6")
        {
            menu = writting.Menu();
            
            if (menu == "1")
            {
                Entries entry = new Entries();
                string prompt = writting.PromptGenerator();
                Console.WriteLine(prompt);
                entry._prompt = prompt;
                string resp = writting.Responds();
                entry._respond = resp;
                entry._currentDate = writting.CurrentDateTime();
                writting._entrylist.Add(entry);
            }
        
            else if (menu == "2")
            {
                Console.WriteLine();
                writting.JournalDisplay(); // This one diplay from a file
            }

            else if (menu == "3")
            {
                writting.Load(); // A menthod that load the entry from a file.
            }

            else if (menu == "4")
            {
                writting.Save(); // A menthod that saves the entry into a file.
            }

            else if (menu == "5") // This is my creativity. 
            {                     //I am really sorry for the lateness, a little mistake just knocked me of.
                writting.Edit(); // A menthod that edit a single entry in the journal file.
            }                    // Maybe you want to change what you had written and saved before with the date and
        }                        // prompt still the same.
        
        // I really like to put comments along with my code, but it 1:09 am here right now and I have had church history
        // training all day and I will be resuming later today (I'm pretty sure I will be nodding my head all through.), 
        // so I want to submit this program and get done with it. 
        // I am sorry for the poor commenting. 
    }
}