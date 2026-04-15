using System.Globalization;

namespace ExerciseTracking;

public abstract class Activity
{
    private DateTime _date;
    private int _length;
    
    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} {this.GetType().Name} ({_length} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}