using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        bool cont = true;

        while (cont == true)
        {
            Journal userJournal = new Journal();

            Console.WriteLine("\n1. Add an entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Exit");
            Console.Write("What would you like to do? (1, 2, or 3) ");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                userJournal.AddEntry();
            }
            else if (userChoice == "2")
            {
                userJournal.DisplayAllEntries();
            }
            else
            {
                Console.WriteLine("Goodbye!");
                cont = false;
            }
        }
    }
}
