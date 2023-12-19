class Program
{
    static void Main()
    {
        // Створення екземпляра класу Figure з трьома точками
        Figure triangle = new Figure(new Point(0, 0, "A"), new Point(0, 3, "B"), new Point(4, 0, "C"));

        // Розрахунок та виведення периметру багатокутника
        triangle.CalculatePerimeter();
    }
}
