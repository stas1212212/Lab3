using System;

class Point
{
    private double _x;
    private double _y;
    private string _name;

    // Власний конструктор класу Point
    public Point(double x, double y, string name)
    {
        _x = x;
        _y = y;
        _name = name;
    }

    // Властивості з методом доступу get
    public double X
    {
        get { return _x; }
    }

    public double Y
    {
        get { return _y; }
    }

    public string Name
    {
        get { return _name; }
    }
}