using System;
namespace ConsoleApp27
{
    class Program
    public class Program
    {
        static void Main(string[] args)
        {

            int number = 15;

            Console.WriteLine($"��� ����� {number}: {Cube(number)}");
            Console.WriteLine($"������� ����� {number}: {Square(number)}");
            Console.WriteLine($"����� ����� {number} � 3: {Sum(number, 3)}");

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