using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            try
            {
                double result = MathFunctions.ComputeFunction(x);
                Console.WriteLine($"Результат для x = {x}: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
