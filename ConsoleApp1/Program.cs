using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int exit = 0;
            int result;
            while (exit == 0)
            {
                Console.WriteLine("Какое действие выполнить?\nДля сложения введите - 1\nДля вычитания введите - 2\nДля деления введите - 3\nДля возведения в степень введите - 4");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        result = x + y;
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine("Чтобы завершить введите - 1\nЧтобы продолжить введите - 0");
                        exit = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        result = x - y;
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine("Чтобы завершить введите - 1\nЧтобы продолжить введите - 0");
                        exit = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        result = x / y;
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine("Чтобы завершить введите - 1\nЧтобы продолжить введите - 0");
                        exit = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        result = (int)Math.Pow(x, y);
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine("Чтобы завершить введите - 1\nЧтобы продолжить введите - 0");
                        exit = int.Parse(Console.ReadLine());
                        break;

                }
            }
        }
    }
}
