using System;
using System.IO;

public class Scripture
{
    private List<Words> _scripturesList = new List<Words>();
   

    private string _fileName = "Matthew 5.txt";
    private string _userFileName;

    public Scripture()
    {
       
    }
    public void AddPersonalScripture()
    {
        _scripturesList.Clear();
        Words newscript = new Words();
        Console.Write("Enter the book name: ");
        string bk = Console.ReadLine();
        Console.Write("Enter the chapter: ");
        string cp = Console.ReadLine();
        Console.Write("Enter the verse(s): ");
        string fv = Console.ReadLine();
        Console.Write("Enter the verse text: ");
        string tx = Console.ReadLine();
        newscript._bookName = bk;
        newscript._chapter = cp;
        newscript._verseStart = fv;
        newscript._text = tx;
        _scripturesList.Add(newscript);
        RandomScripture();

        Console.Write("Do you want to save this scripture (yes or no)?: ");
        string save = Console.ReadLine();
        if (save == "yes")
        {
            Console.Write("Enter a file name: ");
            _userFileName = Console.ReadLine();
            SaveScripture(bk, cp, fv, tx);
        }
    }

    public void SaveScripture(string bk, string cp, string fv, string tx)
    {
        using (StreamWriter scriptureFile = new StreamWriter(_userFileName))
        {
            scriptureFile.WriteLine($"{bk} # {cp} # {fv} # {tx}");
        }
        
    }
    public void Load()
    {
        Console.Write("Enter a file name: ");
        _userFileName = Console.ReadLine();
        _scripturesList.Clear();
        if (File.Exists(_userFileName))
        {
            string[] lines = File.ReadAllLines(_userFileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("#");
                string bk = parts[0];
                string cp = parts[1];
                string fv = parts[2];
                string tx = parts[3];
                Words load = new Words();
                load._bookName = bk;
                load._chapter = cp;
                load._verseStart = fv;
                load._text = tx;
                _scripturesList.Add(load);
            }
            RandomScripture();
        }
        else
        {
            Console.WriteLine("Oops! It looks like there is no such file");
        }
        
    }
    public void Matthew()
    {
        _scripturesList.Clear();
        string[] mattLines = File.ReadAllLines(_fileName);
        foreach (string line in mattLines)
        {
            string[] mattParts = line.Split("#");
            string bk = mattParts[0];
            string cp = mattParts[1];
            string fv = mattParts[2];
            string tx = mattParts[3];
            Words matt = new Words();
            matt._bookName = bk;
            matt._chapter = cp;
            matt._verseStart = fv;
            matt._text = tx;
            _scripturesList.Add(matt);
        }
    }
    public void RandomScripture()
    {
        int index = _scripturesList.Count;
        Random r1 = new Random();
        int rindex = r1.Next(index);
        Words script = _scripturesList[rindex];
        Words assign = new Words();
        assign._bookName = script._bookName;
        assign._chapter = script._chapter;
        assign._verseStart = script._verseStart;
        assign._text = script._text;
        assign.DisplaySingleVerse();
        assign.HideScripture();


    }

}