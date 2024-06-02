using System;

public class Video
{
    public string _title;
    public string _author;
    public int _duration;
    
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (minutes): {_duration}");
        Console.WriteLine("Number of comments: " + _comments.Count);
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}