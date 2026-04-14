namespace EternalQuest;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        // Eternal goals do not change state when recorded
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {GetShortName()} ({GetDescription()})";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal, {GetShortName()}, {GetDescription()}, {GetPoints()}";
    }
}