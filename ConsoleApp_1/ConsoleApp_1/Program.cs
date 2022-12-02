using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, d, n;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первый член арифметической прогрессии:");
                    a1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите разность арифметической прогрессии:");
                    d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число членов арифметической прогрессии:");
                    n = double.Parse(Console.ReadLine());

                    if (n % 1 == 0) { }
                    else throw new Exception("Число членов арифметической прогрессии введено некорректно");
                    if (n < 0) throw new Exception("Число членов арифметической прогрессии не может быть отрицательным");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
            double sum = (2 * a1 + d * (n - 1)) * n / 2;
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
