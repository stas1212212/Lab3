using System;

class Rectangle
{
    private double _side1;
    private double _side2;

    // Конструктор класу Rectangle
    public Rectangle(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }

    // Метод для обчислення площі прямокутника
    public double CalculateArea()
    {
        return _side1 * _side2;
    }

    // Метод для обчислення периметру прямокутника
    public double CalculatePerimeter()
    {
        return 2 * (_side1 + _side2);
    }

    // Властивість для отримання площі прямокутника
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Властивість для отримання периметру прямокутника
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
