using System;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Завдання 5. Середній бал у групах студентів");


            // Создаем зубчатый массив с оценками 4 групп (от 10 до 30 студентов в каждой)
            int[][] groups = new int[][]
            {
                new int[] { 85, 90, 78, 92, 88, 76, 95, 83, 79, 91, 87, 82, 89, 84, 80, 75, 93, 77, 86, 81 }, // Группа 1 (20 студентов)
                new int[] { 65, 72, 68, 75, 70, 62, 78, 71, 67, 74, 69, 73, 66, 77, 64, 79, 63, 76, 61, 80, 60, 81, 59, 82, 58 }, // Группа 2 (25 студентов)
                new int[] { 92, 95, 88, 96, 90, 94, 89, 93, 91, 97, 87, 98, 86, 99, 85, 100, 84, 83, 82, 81, 80 }, // Группа 3 (21 студент)
                new int[] { 55, 60, 65, 70, 58, 63, 68, 72, 57, 62, 67, 74, 59, 64, 69, 53, 61, 66, 71, 56, 54, 52 } // Группа 4 (22 студента)
            };

            // Выводим статистику по всем группам
            PrintGroupStatistics(groups);

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        // Метод вычисления среднего балла для одной группы
        public static double GetAverage(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                return 0;

            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }

        // Метод поиска минимальной оценки в группе
        public static int GetMin(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                return 0;

            int min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            return min;
        }

        // Метод поиска максимальной оценки в группе
        public static int GetMax(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                return 0;

            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }
            return max;
        }

        // Метод вывода статистики по всем группам
        public static void PrintGroupStatistics(int[][] groups)
        {
            if (groups == null)
            {
                Console.WriteLine("Немає даних про групи.");
                return;
            }

            Console.WriteLine($"Всього груп: {groups.Length}");
            Console.WriteLine("Статистика за групами:");
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i] != null && groups[i].Length > 0)
                {
                    double average = GetAverage(groups[i]);
                    int min = GetMin(groups[i]);
                    int max = GetMax(groups[i]);
                    int studentCount = groups[i].Length;

                    Console.WriteLine($"Група {i + 1}:");
                    Console.WriteLine($"  Кількість студентів: {studentCount}");
                    Console.WriteLine($"  Середній бал = {average:F1}");
                    Console.WriteLine($"  Мінімальний = {min}");
                    Console.WriteLine($"  Максимальний = {max}");
                    Console.WriteLine();
                }
                else

                {
                    Console.WriteLine($"Група {i + 1}: Немає даних");
                    Console.WriteLine();
                }
            }
        }
    }
}