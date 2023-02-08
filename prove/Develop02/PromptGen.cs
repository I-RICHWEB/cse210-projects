using System;

public class PromptGen
{
    public List<string> _promptList = new List<string>();
    public string Prompt()
    {
        _promptList.Add("Who was the most interesting person I interacted with today?");
        _promptList.Add("What was the best part of my day?");
        _promptList.Add("How did I see the hand of the Lord in my life today?");
        _promptList.Add("What was the strongest emotion I felt today?");
        _promptList.Add("If I had one thing I could do over today, what would it be?");
        _promptList.Add("Would you consider today a good day? Why?");
        _promptList.Add("Would you consider today a bad day? Why?");
        _promptList.Add("What lessons did you learn today?");
        _promptList.Add("What part of today will you always want to remember?");
        _promptList.Add("Did you feel you helped someone today?");
        _promptList.Add("Who helped you today? What do you think made him or her helped you?");
        _promptList.Add("In what aspect did you increase today?");
        _promptList.Add("What will you say is your emotional state now? What did you think contribute to your emotional state?");
        _promptList.Add("Where you able to do all you plan to do today?");
        _promptList.Add("What are the things you planed to do today that you didn't do? Why didn't you do them?");
        _promptList.Add("What inspired you most today?");

        Random promptRan = new Random();
        int count = _promptList.Count;
        int prompts = promptRan.Next(count);
        string newPrompt = _promptList[prompts]; 
        return newPrompt;
    }

}