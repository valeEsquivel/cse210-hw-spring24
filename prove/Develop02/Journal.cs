using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string filename)
    {
        // Verify if the file exists and is not empty, return a message to avoid errors in the program
        if (File.Exists(filename) == false || new FileInfo(filename).Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The file is empty or not found. Please try again.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            //solo guardar los datos si hay 4 partes
            if (parts.Length == 4)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                _entries.Add(entry);
            }
        }
    }

    public void SaveToFile(string filename)
    {
        //I was reading and watching some examples to write to a file and I found this one different from the one in the instructions
        List<string> lines = new List<string>();

        // Verify if there are entries to save, return a message to let the user know that there are no entries to save
        if (_entries.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no entries to save.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            string line = $"{entry._prompt}|{entry._response}|{entry._date}|{entry._hour}";
            lines.Add(line);
        }
        File.WriteAllLines(filename, lines);
    }
}