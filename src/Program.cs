using System;
namespace ConsoleApp27
{
    class Program
    {
        public class ar
        {
            static void Main(string[] args)
            {

                int number = 15;

                Console.WriteLine($"Куб числа {number}: {Cube(number)}");
                Console.WriteLine($"Квадрат числа {number}: {Square(number)}");
                Console.WriteLine($"Сумма чисел {number} и 3: {Sum(number, 3)}");
                Console.WriteLine("Результат операции: " + Calculate(10, 5, 2));
                Console.WriteLine("День недели: " + GetDayOfWeek(3));
                Console.WriteLine("Минимальное число: " + Min(10, 5));
                Console.ReadKey();
            }

            //1
            static int Cube(int x)
            {
                return x * x * x;
            }

            //2
            static int Square(int x)
            {
                return x * x;
            }

            // 3
            static int Sum(int x, int y)
            {
                return x + y;
            }
            //4
            static double Calculate(int a, int b, int c)
            {
                return (a - b) / (double)c;
            }
            //5
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
            //6
            static int Min(int a, int b)
            {
                return (a < b) ? a : b;
            }

        }

    }
}