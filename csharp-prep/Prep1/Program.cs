using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string lastName;

        Console.Write("What is your first name? ");
        name = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {name} {lastName}.");
    }
}