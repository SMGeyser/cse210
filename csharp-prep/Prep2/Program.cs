using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What grade did you get? ");
        string grade_input = Console.ReadLine();
        int grade = int.Parse(grade_input);
        string letter_grade;
        string modifier;

        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        int modifier_grade = grade % 10;

        if (modifier_grade >= 7 && letter_grade != "A" && letter_grade != "F")
        {
            modifier = "+";
        }
        else if (modifier_grade <= 3 && letter_grade != "F")
        {
            modifier = "-";
        }
        else
        {
            modifier = "";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congradulations!! You passed the class with a final grade of {letter_grade}{modifier}!");
        }
        else
        {
            Console.WriteLine($"Better luck next year! you fail with a final grade of {letter_grade}{modifier}");
        }

    }
}