using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class LambdaExpression
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            var divide = numbers.FindAll(n => n % 3 == 0 );

            foreach(var v in divide)
            {
                Console.WriteLine($"{v}");
            }

            Console.ReadLine();
        }
    }
}
