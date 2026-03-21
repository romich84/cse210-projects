namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }
    public void SetReference(ref Reference reference)
    {
        _reference = reference;
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public void SetWords(List<Word> words)
    {
        _words = words;
    }
    
    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0; i < numberToHide; i++)
        {
            _words[new Random().Next(_words.Count)].Hide();
        }
    }
    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {text.Trim()}";   
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}