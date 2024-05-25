using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest!");

        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}