using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public string _hour;

    public Entry(string prompt, string response, string date, string hour)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
        _hour = hour;
    }

    public void Display() {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nDate: {_date} {_hour} - Prompt: {_prompt}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"  {_response}");
    }
}