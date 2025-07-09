using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    //operator overloading

    class Box
    {
        public int length;
        public int breadth;

        //operator overloading


        public static Box operator +(Box box1, Box box2)
        {
            Box temp = new Box();
            temp.length = box1.length + box2.length;
            temp.breadth = box1.breadth + box2.breadth;
            return temp;
        }

        public static Box operator ++(Box box)
        {
            box.length++;
            box.breadth++;
            return box;
        }

    }


    class OperatorOverloadingEg
    {
        static void Main()
        {
            //int a = 5, b = 5, c;
            //c = a + b;
            //c++;
            //Console.WriteLine(c);

            Box b1 = new Box();
            b1.length = 5;
            b1.breadth = 4;

            Box b2 = new Box();
            b2.length = 10;
            b2.breadth = 5;

            Box b3 = b1 + b2;  // goto line no.15
            Console.WriteLine($"The overall Length is {b3.length} and breadth is {b3.breadth} without increament");
            b3++;
            Console.WriteLine($"The overall Length is {b3.length} and breadth is {b3.breadth} with increament");
            Console.Read();

        }
    }
}
