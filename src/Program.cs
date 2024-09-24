using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("��� ����� 3: " + Cube(3));
        Console.WriteLine("������� ����� 4: " + Square(4));
        Console.WriteLine("����� 5 � 10: " + Sum(5, 10));
        Console.WriteLine("��������� (10 - 5) / 2: " + ari(10, 5, 2));
        Console.WriteLine("���� ������ ��� 3: " + akchurin(3));
        Console.WriteLine("������� �� 7 � 3: " + Min(7, 3));
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
            Console.WriteLine("������ �� ���� ������.");
        }
        return (a - b) / c;
    }
    static string akchurin(int day)
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
    static double Min(double a, double b)
    {
        return a < b ? a : b;
    }
}
