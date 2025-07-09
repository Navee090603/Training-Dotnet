using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Shape
    {
        protected float R, L, B;

        public virtual float Area() // Marked as virtual --> can be overridden in child class
        {
            return 3.14f * R * R;
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length : ");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            GetLB(); // Added to ensure length and breadth are set before calculating
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("Enter the Radius : ");
            R = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            GetRadius(); // Added to ensure R has a value before calculation
            return 3.14f * R * R;
        }

        public override float Circumference()
        {
            return base.Circumference();
        }
    }

    class OverridingfEg
    {
        static void Main()
        {
        //    Rectangle rectangle = new Rectangle();
        //    Console.WriteLine("Area of Rectangle is {0}", rectangle.Area());

        //    Console.WriteLine("-----------------");

        //    Console.WriteLine("Rectangle Circumference is {0}", rectangle.Circumference());

        //    Circle circle = new Circle();
        //    Console.WriteLine("Area and Circumference of Circle {0} , {1}", circle.Area(), circle.Circumference());

            Shape shape = new Shape();
            Console.WriteLine(shape.Area());
            Console.WriteLine(shape.Circumference());

            shape = new Rectangle(); //co variance



            Console.ReadLine();
        }
    }
}
