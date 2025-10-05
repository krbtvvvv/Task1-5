using System;
using System.Text;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Установка кодировки для поддержки украинских символов
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Завдання 1. Парність числа");
            Console.WriteLine("Введіть число:");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                string message = GetMessage(number);
                Console.WriteLine(message);
            }
            else


            {
                Console.WriteLine("Помилка: Будь ласка, введіть коректне ціле число.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string GetMessage(int number)
        {
            if (IsEven(number))
            {
                return "Двері відкриваються!";
            }
            else
            {
                return "Двері зачинені...";
            }
        }
    }
}