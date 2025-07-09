using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day12CSharp

{

    class ExpressionTrees

    {
        public static void Main()

        {

            //Func<string, string, string> stringJoin = (s1, s2) => String.Concat(s1, s2);

            //Expression<Func<string, string, string>> stringJoinExpr = (s1, s2) => String.Concat(s1, s2);

            //var result = stringJoinExpr.Compile()("Banu", "Mathi");

            Expression<Func<int, int, int>> AddTwoNumbersExpr = (n1, n2) => (n1 + n2);
            var sum = AddTwoNumbersExpr.Compile()(10, 20);
            Console.WriteLine($"Total is : {sum}");
            //Console.WriteLine(result);

            Console.Read();

        }

    }

}

