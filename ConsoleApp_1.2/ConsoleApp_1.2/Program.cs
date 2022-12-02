using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сторону a:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону b:");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону c:");
                    c = double.Parse(Console.ReadLine());

                    if (a == 0 || b == 0 || c == 0) throw new Exception("Сторона не может иметь значение равное нулю");
                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Сторона не может иметь отрицательное значение");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }

            if (a == b && b == c && a == c)
            {
                Console.WriteLine("Треугольник - равносторонний");
                return;
            }

            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник - равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник - НЕ равнобедренный");
            }
        }
    }
}
