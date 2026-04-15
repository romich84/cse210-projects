namespace ExerciseTracking;

public class Swimming : Activity
{
    private int _lapsNumber;
    
    public Swimming (DateTime date, int length, int lapsNumber) : base(date, length)
    {
        _lapsNumber = lapsNumber;
    }

    public override double GetDistance()
    {
        return (_lapsNumber * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}