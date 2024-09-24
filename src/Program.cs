using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Куб числа 3: " + Cube(3));
        Console.WriteLine("Квадрат числа 4: " + Square(4));
        Console.WriteLine("Сумма 5 и 10: " + Sum(5, 10));
        Console.WriteLine("Результат (10 - 5) / 2: " + ari(10, 5, 2));
        Console.WriteLine("День недели для 3: " + akchurin(3));
        Console.WriteLine("Минимум из 7 и 3: " + Min(7, 3));
    }
    static double Cube(double number)
    {
        return Math.Pow(number, 3);
    }
    static double Square(double number)
    {
        return Math.Pow(number, 2);
    }
    static double Sum(double a, double b)
    {
        return a + b;
    }
    static double ari(double a, double b, double c)
    {
        if (c == 0)
        {
            Console.WriteLine("Делить на ноль нельзя.");
        }
        return (a - b) / c;
    }
    static string akchurin(int day)
    {
        switch (day)
        {
            case 1: return "Понедельник";
            case 2: return "Вторник";
            case 3: return "Среда";
            case 4: return "Четверг";
            case 5: return "Пятница";
            case 6: return "Суббота";
            case 7: return "Воскресенье";
            default: return "Некорректный номер дня";
        }
    }
    static double Min(double a, double b)
    {
        return a < b ? a : b;
    }
}
