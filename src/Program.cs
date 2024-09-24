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

                Console.WriteLine($"��� ����� {number}: {Cube(number)}");
                Console.WriteLine($"������� ����� {number}: {Square(number)}");
                Console.WriteLine($"����� ����� {number} � 3: {Sum(number, 3)}");
                Console.WriteLine("��������� ��������: " + Calculate(10, 5, 2));
                Console.WriteLine("���� ������: " + GetDayOfWeek(3));
                Console.WriteLine("����������� �����: " + Min(10, 5));
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
                    case 1: return "�����������";
                    case 2: return "�������";
                    case 3: return "�����";
                    case 4: return "�������";
                    case 5: return "�������";
                    case 6: return "�������";
                    case 7: return "�����������";
                    default: return "������������ ����� ���";
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