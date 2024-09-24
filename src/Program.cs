using System;
namespace ConsoleApp27
{
    class Program
    public class Program
    {
        static void Main(string[] args)
        {

            int number = 15;

            Console.WriteLine($" уб числа {number}: {Cube(number)}");
            Console.WriteLine($" вадрат числа {number}: {Square(number)}");
            Console.WriteLine($"—умма чисел {number} и 3: {Sum(number, 3)}");

            Console.ReadKey();
        }


        static int Cube(int x)
        {
            return x * x * x;
        }


        static int Square(int x)
        {
            return x * x;
        }


        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}