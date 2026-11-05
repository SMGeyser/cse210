public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private bool _randBool;
    private bool _isDone;
    public Scripture(Reference reference, List<Word> wordList)
    {
        _reference = reference;
        _words = wordList;
    }
    public void Display()
    {
        _reference.Display();
        foreach (Word word in _words)
        {
            word.Display();
        }
    }
    private bool CheckVerse()
    {
        return _words.All(word => word.CheckHide());
    }
    public void NextLevel()
    {
        if (CheckVerse() == false)
        {
        foreach (Word word in _words)
        {
            _randBool = Random.Shared.Next(5) == 0;
            if (_randBool == true)
            {
                word.HideWord();
            }
        }
        }
        else
        {
            _isDone = true;
        }
    }
    public bool CheckDone()
    {
        return _isDone;
    }

}