namespace Fractions;

public class Fraction
{
    private int _top;
    private int _bottom;
    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string top = Convert.ToString(_top);
        string bottom = Convert.ToString(_bottom);
        string result = $"{top}/{bottom}";
        return result;
    }

    public double GetDecimalValue()
    {
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);
        double result = top / bottom;
        return result;
    }

}