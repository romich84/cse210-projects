namespace YouTubeVideos;

public class Comment
{
    private string _namePerson;
    private string _textComment;

    public Comment(string name, string textComment)
    {
        _namePerson = name;
        _textComment = textComment;
    }

    public string GetNamePerson()
    {
        return _namePerson;
    }

    public void SetNamePerson(string name)
    {
        _namePerson = name;
    }

    public string GetTextComment()
    {
        return _textComment;
    }

    public void SetTextComment(string textComment)
    {
        _textComment = textComment;
    }
    
    public void GetDisplayComment()
    {
        Console.WriteLine($"{GetNamePerson()}: {GetTextComment()}");
    }
}