namespace Homework;

public class Assignment
{
    private string _studentName;
    private string _topic;
    
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string StudentName)
    {
        _studentName = StudentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string Topic)
    {
        _topic = Topic;
    }
    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}