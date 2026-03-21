namespace ScriptureMemorizer;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
    
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            return new string('_', _text.Length);
        }
    }
    
}