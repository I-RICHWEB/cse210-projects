using System;

public class Fractions
{
    private int _topNumber;
    private int _bottomNumber;

    public Fractions()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fractions(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fractions(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public int Getbottom()
    {
        return _bottomNumber;
    }

    public void SetTop(int top)
    {
         _topNumber = top;
    }

    public void Setbottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public void DisplayFractions()
    {
        Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public void DisplayDecimals()
    {
        float top = Convert.ToSingle(_topNumber);
        float bottom = Convert.ToSingle(_bottomNumber);
        float deci = top / bottom;
        Console.WriteLine(deci);
    }
}