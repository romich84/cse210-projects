namespace EternalQuest;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal(string shortName, string description, int points, int bonus, int target, int amountCompleted) :
        base(shortName, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }
    public string GetDetailsString()
    {
        return $"{GetShortName()}: {GetDescription()} {GetPoints()}";
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal, {GetShortName()}, {GetDescription()}, {GetPoints()}, {GetBonus()}, {GetTarget()}, {GetAmountCompleted()}";
    }
}