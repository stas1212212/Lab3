class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину сторони 1 прямокутника: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони 2 прямокутника: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Створення екземпляра класу Rectangle
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виведення на екран периметру та площі прямокутника
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
    }
}
