class Figure
{
    private Point[] _points;

    // Конструктор для 3 точок
    public Figure(Point point1, Point point2, Point point3)
    {
        _points = new Point[] { point1, point2, point3 };
    }

    // Конструктор для 4 точок
    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        _points = new Point[] { point1, point2, point3, point4 };
    }

    // Конструктор для 5 точок
    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        _points = new Point[] { point1, point2, point3, point4, point5 };
    }

    // Метод для розрахунку довжини сторони багатокутника
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Метод для розрахунку периметру багатокутника
    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < _points.Length - 1; i++)
        {
            perimeter += GetSideLength(_points[i], _points[i + 1]);
        }

        // Додаємо відстань між останньою та першою точками
        perimeter += GetSideLength(_points[_points.Length - 1], _points[0]);

        Console.WriteLine($"Назва багатокутника: {_points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}