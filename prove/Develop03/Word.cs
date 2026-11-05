using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _word;
    private int _length;
    private char _blank = '_';
    private string _blankWord;
    private bool _isHidden;
    public Word(string word)
    {
        _word = word;
    }
    private string GetDisplayString()
    {
        if (_isHidden == true)
        {
            _length = _word.Length;
            _blankWord = new string(_blank, _length);
            return _blankWord;
        }
        else
        {
            return _word;
        }
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    public bool CheckHide()
    {
        return _isHidden;
    }
    public void Display()
    {
        Console.Write($"{GetDisplayString()} ");
    }
}