using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int option = 0; // to manage the user's option

        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        } while (option != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\nYou have {_score} points.");
        Console.ResetColor();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{index}. {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        int type; // to manage the type of goal
        string shortName; // to manage the short name of the goal
        string description; // to manage the description of the goal
        string points; // to manage the points of the goal
        int target; // to manage the target of the goal
        int bonus; // to manage the bonus of the goal

        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        points = Console.ReadLine();

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(shortName, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(shortName, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option. Try again.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];

            // Check if the goal has already been completed
            if (goal.IsComplete())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("This goal has already been completed.");
                Console.ResetColor();
                return;
            }

            goal.RecordEvent();

            _score += goal.GetPoints();
            
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal index. Try again.");
        }
    }

    public void SaveGoals()
    {
        List<string> lines = new List<string>();
        string fileName;

        Console.Write("What is the name of the load file? ");
        fileName = Console.ReadLine();

        lines.Add(_score.ToString());

        if (_goals.Count <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no goals to save.");
            Console.ResetColor();
            return;
        }

        foreach (Goal goal in _goals)
        {
            string line = goal.GetStringRepresentation();
            lines.Add(line);
        }

        File.WriteAllLines(fileName, lines);
    }

    public void LoadGoals()
    {
        string fileName;
        Console.Write("What is the name of the load file? ");
        fileName = Console.ReadLine();

        //verify the extension of the file
        if (Path.GetExtension(fileName) != ".txt")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The file must be a .txt file.");
            Console.ResetColor();
            return;
        }

        //verify if the file exists
        if (!File.Exists(fileName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The file does not exist.");
            Console.ResetColor();
            return;
        }

        //verify if the file is empty
        if (new FileInfo(fileName).Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The file is empty.");
            Console.ResetColor();
            return;
        }


        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];

            string body = parts[1];

            string[]details = body.Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(details[0], details[1], details[2], bool.Parse(details[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(details[0], details[1], details[2]));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(details[0], details[1], details[2], int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5])));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }

        }
    }
}