using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Video and comments for video 1
        Video video1 = new Video("C# Tutorial", "Alexander Rivas", 10);
        video1._comments.Add(new Comment("Alice", "Great video!"));
        video1._comments.Add(new Comment("Bob", "I don't understand this part."));
        video1._comments.Add(new Comment("Charlie", "Thanks for the video!"));
        video1.DisplayInfo();

        // Video and comments for video 2
        Video video2 = new Video("Python Tutorial", "Karen Ocampo", 15);
        video2._comments.Add(new Comment("David", "This is awesome!"));
        video2._comments.Add(new Comment("Eve", "I'm learning a lot."));
        video2._comments.Add(new Comment("Frank", "I'm confused."));
        video2._comments.Add(new Comment("Grace", "I love this video!"));
        video2.DisplayInfo();

        // Video and comments for video 3
        Video video3 = new Video("Java Tutorial", "Walter Canizalez", 20);
        video3._comments.Add(new Comment("Hank", "I'm not sure about this."));
        video3._comments.Add(new Comment("Ivy", "This is helpful."));
        video3._comments.Add(new Comment("Jack", "Great explanation."));
        video3.DisplayInfo();

    }
}