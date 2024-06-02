using System;

public class Comment
{
    public string _personName;
    public string _comment;

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;
    }

    public void Display()
    {
        Console.WriteLine($"- {_personName}: {_comment}");
    }
}