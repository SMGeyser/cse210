using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        MathAssignment tonightHomework = new MathAssignment("Sam", "Linear Algebra", "3.1", "5, 9, 11-13");
        Console.WriteLine($"{tonightHomework.GetSummary()}\n{tonightHomework.GetHomeworkList()}");

        WritingAssingment tomorrowHomework = new WritingAssingment("Sam", "English", "Tolkien");
        Console.WriteLine($"{tomorrowHomework.GetSummary()}\n{tomorrowHomework.GetWritingInformation()}");
    }
}
public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Student Name: {_studentName}\nAssignment Topic: {_topic}";
    }
}
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string student, string topic, string section, string problems) : base(student, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} (problems: {_problems})";
    }
}
public class WritingAssingment : Assignment
{
    private string _title;
    public WritingAssingment(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }
}