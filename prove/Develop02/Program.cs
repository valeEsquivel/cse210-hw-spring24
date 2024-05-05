using System;

class Program
{
    static void Main(string[] args)
    {
        string menuSelection = "0";
        Journal journal = new Journal();

        //here we will fill up the List of prompts
        Prompt prompt = new Prompt();

        // change of colors of the different displays messages
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nWelcome to your journal!");

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load from file");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuSelection = Console.ReadLine();


            switch (menuSelection)
            {
                case "1":
                    string randomPrompt = prompt.GetRandomPrompt();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{randomPrompt}");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    //addition of the time to the entry
                    string hourText = theCurrentTime.ToShortTimeString();

                    Entry entry = new Entry(randomPrompt, response, dateText, hourText);
                    journal.AddEntry(entry);

                    menuSelection = "0";
                    break;

                case "2":
                    journal.DisplayAll();
                    menuSelection = "0";
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Enter the filename to load: ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    string filenameLoad = Console.ReadLine();
                    journal.LoadFromFile(filenameLoad);
                    menuSelection = "0";
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Enter the filename to save (.txt permitted): ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    string filenameSave = Console.ReadLine();

                    // Verify if the file extension is .txt
                    if (!filenameSave.EndsWith(".txt"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid file extension. Please try again.");
                        menuSelection = "0";
                        break;
                    }

                    journal.SaveToFile(filenameSave);
                    menuSelection = "0";
                    break;

                case "5":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Have a nice day!");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Invalid selection. Please try again.");
                    menuSelection = "0";
                    break;
            }
        } while (menuSelection != "5");

        Console.ForegroundColor = ConsoleColor.White;
    }
}