using System;

namespace Lab2
{
    public static class MathFunctions
    {
        // Реализация синуса с использованием разложения в ряд Тейлора
        public static double Sin(double x)
        {
            double result = 0.0;
            double term = x;  
            int n = 1;
            while (Math.Abs(term) > 1e-15)  
            {
                result += term;
                n += 2;
                term *= -x * x / (n * (n - 1));
            }
            return result;
        }

        // Реализация косинуса с использованием разложения в ряд Тейлора
        public static double Cos(double x)
        {
            double result = 1.0;
            double term = 1.0; 
            int n = 1;
            while (Math.Abs(term) > 1e-15) 
            {
                term *= -x * x / ((2 * n - 1) * (2 * n)); 
                result += term;
                n++;
            }
            return result;
        }

        // Реализация натурального логарифма с использованием разложения в ряд Тейлора
        public static double Ln(double x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("x должен быть больше нуля для вычисления натурального логарифма.");
            }
            double result = 0;
            double term = (x - 1) / (x + 1);
            double currentTerm = term;
            int n = 1;
            while (Math.Abs(currentTerm) > 1e-10)
            {
                result += currentTerm / n;
                currentTerm *= term * term;
                n += 2;
            }
            return 2 * result;
        }

        // Главная функция f(x)
        public static double ComputeFunction(double x)
        {
            if (x > 0)
            {
                double sinX = Sin(x);
                double cosX = Cos(x);
                return Math.Sqrt(sinX + Math.Pow(cosX, 2)) + Math.Log(x);
            }
            else if (x <= 0)
            {
                if (x == 0) throw new ArgumentException("Логарифм не может быть вычислен для x = 0.");
                double sinX = Sin(x);
                double cosX = Cos(x);
                return Math.Abs(sinX - cosX) / Math.Log(Math.Abs(x));
            }
            else
            {
                throw new ArgumentException("Неверное значение x.");
            }
        }
    }
}
