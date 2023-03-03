using System;
using System.IO;
public class Words
{
    private List<string> _wordslist = new List<string>();
    public string _bookName;
    public string _chapter;
    public string _verseStart;
    public string _text;
    private string[] part;
    private List<string> _pick = new List<string>();
   
    public void DisplaySingleVerse()
    {
        Console.Clear();
        Console.WriteLine($"\n{_bookName} {_chapter}:{_verseStart} {_text}\n");
    }

    // public void Process()
    // {
    //     File.Create(file).Close();
    //     using (StreamWriter word = new StreamWriter(file))
    //     {
    //         word.WriteLine(_text);
    //         Console.WriteLine(_text);
    //         Console.WriteLine(_text);
    //         Console.WriteLine(_text);
            
    //     }
    // }
    public void HideScripture()
    {
        _pick.Clear();
        _wordslist.Clear();
        part = _text.Split(" ");
        foreach (string item in part)
        {
            _wordslist.Add(item);
        }
        string hide = "p";
        while (hide != "quit")
        {

            int wordCt = _wordslist.Count();
            int replacedCt = _pick.Count();
            
            Console.Write("Click enter to hide some words or type (quit) to exit: ");
            hide = Console.ReadLine();
            if (hide == "")
            {
               
                for (int i = 0; i < 3; i++)
                {
                    
                    Random remove = new Random();
                    int indx = _wordslist.Count();
                    int num = remove.Next(indx);
                    string wordCheck = _wordslist[num];
                    if (wordCheck != "___")
                    {
                        _pick.Add(wordCheck);
                    }
                    else if (wordCheck == "___")
                    {
                        num = remove.Next(indx);
                        if (wordCheck == "___")
                        {
                            break;
                        }
                    }
                    
                    _wordslist.RemoveAt(num);
                    _wordslist.Insert(num, "___");
                             
                }
                if (wordCt == replacedCt)
                {
                    break;
                }
                _text = string.Join(" ", _wordslist.ToArray());
                
                DisplaySingleVerse();
            }
        }

        
        // foreach (string word in words)
        // {
        //     wordslist.Add(word);
        //     Console.Write(word);
        // }

    }
}  