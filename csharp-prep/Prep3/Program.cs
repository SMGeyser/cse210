using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string response;
        do
        {
        Console.Write("What is the magic number? ");
        string userNumber = Console.ReadLine();
        int magicNumber = int.Parse(userNumber);
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            if (guess > magicNumber)
            {
                Console.WriteLine("Go lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Go higher");
            }
            else
            {
                Console.WriteLine("That's the magic number!!");
            }
        } while (guess != magicNumber);
        Console.Write("Would you like to play again? (y/n) ");
        response = Console.ReadLine();
        } while (response == "y");
    }
}