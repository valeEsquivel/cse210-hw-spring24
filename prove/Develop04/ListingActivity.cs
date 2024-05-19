using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are some of your favorite things to do?");
        _prompts.Add("What are some of your favorite things to eat?");
    }

    public void Run()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("\n");

        _count = GetListFromUser().Count;

        Console.WriteLine($"\nYou listed {_count} items.");

        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        string response;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Thread.Sleep(1000);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            response = Console.ReadLine();
            list.Add(response);
        }

        return list;
    }

}