namespace EternalQuest;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string shortName,  string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
          _isComplete = true;  
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete)
        {
            return $"[X] {GetShortName()} ({GetDescription()})";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()})";
        }
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal, {GetShortName()}, {GetDescription()}, {GetPoints()}, {GetIsComplete()}";
    }
}