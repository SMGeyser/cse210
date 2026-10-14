class Entry
{
    //attributes
    public string _date="";
    public string _prompt="";
    public string _response="";    
    //behaviors
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
    public void Save()
    {
        string _filename = "entry.csv";

        using StreamWriter outputFile = new(_filename, append:true);
        outputFile.WriteLine($"{_date}~{_prompt}~{_response}");
    }

}