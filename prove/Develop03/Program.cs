using System;

class Program
{
    static void Main(string[] args)
    {
        string finish = "";

        // With only one verse
        // string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        // string book = "1 Nephi";
        // int chapter = 3;
        // int verse = 7;
        // int endVerse = 7;
        // Scripture scripture = new Scripture(new Reference(book, chapter, verse), text);
        
        // With more than one verse
        string text = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.";
        string book = "Moroni";
        int chapter = 10;
        int verse = 4;
        int endVerse = 5;
        Scripture scripture = new Scripture(new Reference(book, chapter, verse, endVerse), text);

        do
        {
            Console.Clear();
            Console.Write(scripture.GetDisplayText());

            Console.WriteLine("\n\nPress enter to continue or type 'quit' to exit");
            finish = Console.ReadLine();

            if (finish != "quit")
            {
                scripture.HideRandomWords(2);
            }
            else
            {
                finish = "quit";
            }
        }
        while (!scripture.IsComplete() || finish != "quit");
    }
}