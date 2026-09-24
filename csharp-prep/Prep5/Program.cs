using System;

class Program
{
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!!");
    }
    static string UserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }
    static int UserNumber()
    {
        Console.Write("What is your favorite number? ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    static void UserBirthyear(out int year)
    {
        Console.Write("What year were you born? ");
        string input = Console.ReadLine();
        year = int.Parse(input);
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int number, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is {number}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        WelcomeMessage();
        string name = UserName();
        int number = UserNumber();
        int birthYear;
        UserBirthyear(out birthYear);
        number = SquareNumber(number);
        DisplayResult(name, number, birthYear);
    }
}