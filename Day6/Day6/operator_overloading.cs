using System;


namespace Day6
{
    class Box
    {
        public int Length;

        public Box(int length)
        {
            Length = length;
        }

        //Operator overloading for +
        public static Box operator +(Box b1, Box b2)
        {
            return new Box(b1.Length + b2.Length);
        }

        public void Display()
        {
            Console.WriteLine("Box length: " + Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(10);
            Box box2 = new Box(15);

            Box combinedBox = box1 + box2;

            Console.WriteLine("Box 1 Length: " + box1.Length);
            Console.WriteLine("Box 2 Length: " + box2.Length);
            Console.WriteLine("Combined Box Length: " + combinedBox.Length);

            Console.ReadLine();
        }
    }
}
