using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.Write(" ");
    }
}