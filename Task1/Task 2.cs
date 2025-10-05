using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Завдання 2. Масив і підрахунок");

            // Генерация массива
            int[] numbers = GenerateRandomArray(10, 1, 100);

            // Вывод массива

            Console.WriteLine("Згенерований масив:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();


            // Вычисление и вывод статистики
            Console.WriteLine($"Сума чисел: {GetSum(numbers)}");
            Console.WriteLine($"Середнє значення: {GetAverage(numbers):F2}");
            Console.WriteLine($"Мінімальне число: {GetMin(numbers)}");
            Console.WriteLine($"Максимальне число: {GetMax(numbers)}");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        // Метод генерации случайного массива
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }

            return array;
        }

        // Метод вычисления суммы
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Метод вычисления среднего значения
        public static double GetAverage(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            return (double)GetSum(numbers) / numbers.Length;
        }

        // Метод поиска минимального значения
        public static int GetMin(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        // Метод поиска максимального значения
        public static int GetMax(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}