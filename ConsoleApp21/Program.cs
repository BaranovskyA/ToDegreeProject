using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            int degree = 1;
            Console.WriteLine(">> Для выхода нужно ввести 0 вместо числа.");
            while (number != 0)
            {
                try
                {
                    Console.Write(">> Введите число, которое нужно возвести в степень: \n>> ");
                    number = int.Parse(Console.ReadLine());

                    if (number == 0) break;

                    Console.Write(">> Введите степень для числа: \n>> ");
                    degree = int.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    continue;
                }

                Console.WriteLine($">> Результат: {MyPow(number, degree)}\n\t=================================\t");
            }
        }

        static double MyPow(double number, int degree)
        {
            if(degree > 0)
            {
                double multiplier = number;
                for (int i = 1; i < degree; i++)
                    number = number * multiplier;
                return number;
            }
            else
            {
                Console.WriteLine($">> Дробь: 1 / {Math.Pow(number, -degree)} или 1 / {number}^{-degree}");
                return 1 / Math.Pow(number, -degree);
            }
        }
    }
}
