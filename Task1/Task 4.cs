using System;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Завдання 4. Робота з трикутником");
            Console.WriteLine("Введіть три сторони трикутника:");

            Console.Write("Сторона a: ");
            string? inputA = Console.ReadLine();

            Console.Write("Сторона b: ");
            string? inputB = Console.ReadLine();


            Console.Write("Сторона c: ");
            string? inputC = Console.ReadLine();


            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if (IsValidTriangle(a, b, c))
                    {
                        double perimeter = GetPerimeter(a, b, c);
                        double area = GetArea(a, b, c);
                        string type = GetTriangleType(a, b, c);

                        Console.WriteLine("\nРезультати:");
                        Console.WriteLine($"Трикутник існує ✓");
                        Console.WriteLine($"Периметр: {perimeter:F2}");
                        Console.WriteLine($"Площа: {area:F2}");
                        Console.WriteLine($"Тип трикутника: {type}");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Ці сторони не можуть утворювати трикутник.");
                        Console.WriteLine("(сума двох сторін повинна бути більшою за третю)");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка: Сторони повинні бути додатними числами.");
                }
            }
            else
            {
                Console.WriteLine("Помилка: Будь ласка, введіть коректні числа.");
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        // Проверка существования треугольника
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Вычисление периметра
        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        // Вычисление площади по формуле Герона
        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2; // полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Определение типа треугольника
        public static string GetTriangleType(double a, double b, double c)
        {
            // Проверка на равносторонний
            if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001)
                return "Рівносторонній";

            // Проверка на равнобедренный
            if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
                return "Рівнобедрений";

            // Проверка на прямоугольный (теорема Пифагора)
            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 0.001 ||
                Math.Abs(a2 + c2 - b2) < 0.001 ||
                Math.Abs(b2 + c2 - a2) < 0.001)
                return "Прямокутний";

            // Во всех остальных случаях - произвольный
            return "Довільний";
        }
    }
}