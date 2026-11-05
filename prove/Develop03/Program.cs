using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Console.WriteLine("welcome to the Scripture Memorizer");

        string book="";
        int chapter=0;
        int startVerse=0;
        int endVerse=0;
        string verseText="";

        ReadCsv reader = new ReadCsv();
        List<string[]> rows = reader.ReadRows("moses319.csv");
        foreach (string[] row in rows)
        {
            book = row[0];
            string chapterIn = row[1];
            chapter = int.Parse(chapterIn);
            string startVerseIn = row[2];
            startVerse = int.Parse(startVerseIn);
            string endVerseIn = row[3];
            endVerse = int.Parse(endVerseIn);
            verseText = row[4];
        }

        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        List<Word> words = verseText
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(word => new Word(word))
        .ToList();

        Scripture scripture = new Scripture(reference, words);

        while (scripture.CheckDone() == false)
        {
            Console.Write("\n\n\n\n");
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words.");
            Console.ReadLine();
            scripture.NextLevel();
        }
    }
}