using System;

namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }

        public static double GetPerimeter(double a, double b, double c) => a + b + c;

        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c)) return "Не трикутник";

            if (a == b && b == c) return "рівносторонній";
            if (a == b || b == c || a == c) return "рівнобедрений";
            if (Math.Abs(a * a + b * b - c * c) < 1e-6 ||
                Math.Abs(a * a + c * c - b * b) < 1e-6 ||
                Math.Abs(b * b + c * c - a * a) < 1e-6)
                return "прямокутний";

            return "довільний";
        }

        public static void Main()
        {
            Console.Write("Введіть сторони a, b, c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine($"Периметр = {GetPerimeter(a, b, c)}");
                Console.WriteLine($"Площа = {GetArea(a, b, c):F2}");
                Console.WriteLine($"Тип: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Такого трикутника не існує.");
            }
        }
    }
}