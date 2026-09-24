using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int number;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished");
        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        Console.WriteLine($"The sum of the list is: {numbers.Sum()}");
        Console.WriteLine($"The average of the list is: {numbers.Average()}");
        Console.WriteLine($"The largest number in the list is: {numbers.Max()}");
    }
}