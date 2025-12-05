using System;

namespace RandomNumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 20); // Random number between 1 and 19 inclusive

            Console.WriteLine("I've picked a number between 1 and 19. Try to guess it!");
            bool guessedCorrectly = false;

            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Incredible! You guessed it right!");
                    guessedCorrectly = true;
                    break;
                }
                else
                {
                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try a higher number.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try a lower number.");
                    }
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"Sorry, you couldn't guess it. The number was: {secretNumber}");
            }

            Console.ReadLine();
        }
    }
}