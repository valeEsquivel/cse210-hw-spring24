using System;
public class Prompt
{
    public List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("What was the most interesting thing I learned today?");
        _prompts.Add("Who had the biggest positive impact today?");
        _prompts.Add("What could I have done better today?");
        _prompts.Add("What was the most challenging part of my day?");
        _prompts.Add("If you have to describe your day in one word, what would it be?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}