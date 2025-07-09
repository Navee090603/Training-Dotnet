using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // Example inputs
            double num1 = 12.5;
            double num2 = 7.3;
            double num3 = 19.8;

            // Call the GetStats function and deconstruct the result
            var (minValue, maxValue, averageValue) = GetStats(num1, num2, num3);

            Console.WriteLine($"Minimum: {minValue}, Maximum: {maxValue}, Average: {averageValue}");

            Console.Read();
        }

        static (double min, double max, double avg) GetStats(double a, double b, double c)
        {
            double min = Math.Min(a, Math.Min(b, c));
            double max = Math.Max(a, Math.Max(b, c));
            double avg = (a + b + c) / 3.0;
            return (min, max, avg);
        }
    }
}
