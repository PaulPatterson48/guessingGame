// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guessing Game!");

        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1. Easy (8 guesses)");
        Console.WriteLine("2. Medium (6 guesses)");
        Console.WriteLine("3. Hard (4 guesses)");
        Console.WriteLine("4. Cheater Level (unlimited guesses");

        int maxAttempts;

        Console.Write("Enter the number corresponding to your difficulty choice: ");
        string difficultyChoice = Console.ReadLine();

        switch (difficultyChoice)
        {
            case "1":
                maxAttempts = 8;
                break;
            case "2":
                maxAttempts = 6;
                break;
            case "3":
                maxAttempts = 4;
                break;
            case "4":
                maxAttempts = int.MaxValue;
                    break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Easy difficulty (8 guesses).");
                maxAttempts = 8;
                break;
        }

        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        
        int attempts = 0;

        Console.WriteLine("Guess the secret number. You have " + maxAttempts + " chances.");

        while (attempts < maxAttempts)
        {
            Console.Write("Enter your guess (" + (attempts +1) + ")>");
            string userInput = Console.ReadLine();

            int userGuess;
            if (int.TryParse(userInput,out userGuess))
            {

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    return;
                }
                else
                {
                    if(userGuess < secretNumber)
                    {
                        Console.WriteLine("Sorry, your guess is too low. You have " + (maxAttempts - attempts - 1) + " chances remaining.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your guess is too high. You have " + (maxAttempts - attempts - 1) + " chances remaining.");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            //Increment the attempts
            attempts++;
        }
        if (attempts == maxAttempts)
        {
            Console.WriteLine("Sorry, you've run out of chances. The correct number is " + secretNumber + ".");
        }
        
    }
}
