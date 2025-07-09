using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }

    }
    class ProductFilter
    {
        public Expression<Func<Products, bool>> FilterCriteria { get; set; }

        public static void Main()
        {
            var filter = new ProductFilter
            {
                FilterCriteria = p => p.Price < 100
            };

            var products = new List<Products>
            {
                new Products{Name = "Pens",Price = 50},
                new Products{Name = "Pencils",Price = 10},
                new Products{Name = "USB",Price = 500},
                new Products{Name = "Memory",Price = 50},
            };

            var lesspricedproducts = products.AsQueryable().Where(filter.FilterCriteria).ToList();
            
            foreach(var item in lesspricedproducts)
            {
                Console.WriteLine($"Less PricedProducts {item.Name} and its Price {item.Price}");
            }

            Console.WriteLine("-----------------");

            Expr1();

            Console.WriteLine("------------------");

            Expr2();

            Console.Read();
        
        }

        static void Expr1()
        {
            Expression<Func<int, bool>> check = num => num < 10;

            Func<int, bool> expdel = check.Compile();

            Console.WriteLine(expdel(15));
            Console.WriteLine(expdel(5));
        }

        static void Expr2()
        {
            BinaryExpression be1 = Expression.Power(Expression.Constant(2d), Expression.Constant(3d));

            //let us create a lamba for expression
            Expression<Func<double>> explamda = Expression.Lambda<Func<double>>(be1);

            //compile the lambda
            Func<double> expdel = explamda.Compile();

            double result = expdel();
            Console.WriteLine($"2 raised to the power of 3 is : {result}");
        
        }
    }
}