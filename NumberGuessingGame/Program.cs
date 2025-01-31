using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int attempts = 0;
        int guess;

        Console.WriteLine("Welcome to number guessing! (1 to 100)");

        do
        {
            Console.Write("Your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < numberToGuess)
                Console.WriteLine("Too low!");
            else if (guess > numberToGuess)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine($"Correct! You have {attempts} Trials needed.");
        }
        while (guess != numberToGuess);
    }
}