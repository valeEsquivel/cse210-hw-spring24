using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber;
        int sum = 0;
        float average = 0;
        int max = 0;
        int smallestPositive = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);

        //* sum of the numbers
        foreach (int number in numbers)
        {
            sum += number;
        }

        //* average of the numbers
        average = (float)sum / numbers.Count;

        //* max of the numbers
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        //* smallest positive number
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == 0)
                {
                    smallestPositive = number;
                }
                else if (number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }

        // sort the list
        numbers.Sort();

        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}