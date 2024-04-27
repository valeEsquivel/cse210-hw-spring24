using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        int times = 0;

        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        do
        {
            Console.Write("\nWhat is your guess? ");
            guess = int.Parse(Console.ReadLine());
            times++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {times} times to guess the magic number");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        } while (guess != magicNumber);
    }
}