using System;

class GuessingGame
{
    static void Main()
    {
        int secretNumber = 25;
        int guess;
        int attempts = 0;

        Console.WriteLine("=== Number Guessing Game ===");

        do
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess > secretNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                Console.WriteLine("Total Attempts: " + attempts);
            }

        } while (guess != secretNumber);
    }
}

