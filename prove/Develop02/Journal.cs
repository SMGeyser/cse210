class Journal
{
    //attributes
    List<string> _prompts = [
        "What was your highlight today?",
        "What do you want to be better at tomorrow?",
        "How did the Lord bless you today?",
        "What was a tender mercy in your life today?",
        "What was something hard that happened today?"
    ];
    public string _filename = "entry.csv";
    //behaviors
    public void AddEntry()
    {
        Entry currentEntry = new Entry();

        int randomIndex = Random.Shared.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Today's Date: {dateText}");
        Console.WriteLine($"\n{randomPrompt}\n");
        string userResponse = Console.ReadLine();

        currentEntry._date = dateText;
        currentEntry._prompt = randomPrompt;
        currentEntry._response = userResponse;
        currentEntry.Save();
    }
    public void DisplayAllEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry entryToDisplay = new Entry();
            entryToDisplay._date = parts[0];
            entryToDisplay._prompt = parts[1];
            entryToDisplay._response = parts[2];

            entryToDisplay.Display();
        }
    }
}