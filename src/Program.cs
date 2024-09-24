using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 15;

        Console.WriteLine($"Куб числа {number}: {Cube(number)}");
        Console.WriteLine($"Квадрат числа {number}: {Square(number)}");
        Console.WriteLine($"Сумма {number} и 3: {Sum(number, 3)}");
        Console.WriteLine("Результат (10 - 5) / 2: " + Calculate(10, 5, 2));
        Console.WriteLine("День недели для 3: " + GetDayOfWeek(3));
        Console.WriteLine("Минимальное из 10 и 5: " + Min(10, 5));
        
        Console.ReadKey(); // Ожидание нажатия клавиши
    }

    // 1. Функция, возвращающая куб числа
    static int Cube(int x)
    {
        return x * x * x;
    }

    // 2. Функция, возвращающая квадрат числа
    static int Square(int x)
    {
        return x * x;
    }

    // 3. Функция, возвращающая сумму двух чисел
    static int Sum(int x, int y)
    {
        return x + y;
    }

    // 4. Функция, отнимающая от первого числа второе и делящая на третье
    static double Calculate(int a, int b, int c)
    {
        if (c == 0)
        {
            throw new DivideByZeroException("Делить на ноль нельзя.");
        }
        return (a - b) / (double)c;
    }

    // 5. Функция, возвращающая день недели на русском языке
    static string GetDayOfWeek(int day)
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

    // 6. Функция, возвращающая меньшее из двух чисел
    static int Min(int a, int b)
    {
        return (a < b) ? a : b;
    }
}
