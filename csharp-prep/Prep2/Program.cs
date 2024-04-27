using System;

class Program
{
    static void Main(string[] args)
    {
        float gradePercentage;
        string letter;
        string sign = "";

        Console.Write("What is your grade percentage? ");

        gradePercentage = float.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "";
        }

        // ? Validation of symbol, excluding when the letter is F and the percentage is more than 93, because A+ does not exists
        if (letter != "F" && gradePercentage <= 93)
        {
            if (gradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"\nYour letter grade is {letter}{sign}");

        // ? Verification of the minimum necessary to approve the class
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations!, you approved the class.");
        }
        else
        {
            Console.WriteLine("You should keep praticing for the next time.");
        }
    }
}