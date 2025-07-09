using System;


namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array1();
            //Array2();
            //Array3();
            //Enum();
            //Program ob1 = new Program(2, "naveen");
            //Result obj1 = new Result();
            //obj1.GetData();
            //obj1.GetMarks();
            //obj1.GetResults();
            //obj1.PutResults();
            


            Console.ReadLine();

        }

        //OneDimension

        static void Array1()

        {
            Console.Write("Enter the Size : ");
            int size = int.Parse(Console.ReadLine());

            int[] OneDimension = new int[size];
            for (int x = 0; x < OneDimension.Length; x++)
            {
                Console.Write($"Enter a Element {x + 1} : ");
                OneDimension[x] = int.Parse(Console.ReadLine());
            }

            foreach (int i in OneDimension)
            {
                Console.Write(i + " ");
            }

        }

        //TwoDimension

        static void Array2()
        {

            Console.Write("Enter The Row Size : ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the Column Size : ");
            int col = int.Parse(Console.ReadLine());

            int[,] TwoDimension = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter Element at position {i} {j} : ");
                    TwoDimension[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(TwoDimension[i, j] + " ");

                }
                Console.WriteLine();
            }

        }

        //Three Dimension

        static void Array3()
        {
            Console.Write("Enter the Fixed Row for you : ");
            int row = int.Parse(Console.ReadLine());

            int[][] twodimen = new int[row][];

            for (int i = 0; i < row; i++)
            {
                Console.Write($"Enter the Column size you want {i} : ");
                int col = int.Parse(Console.ReadLine());

                twodimen[i] = new int[col];

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter the elements of {i} {j} : ");
                    twodimen[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The Jagged array are : ");
            for (int i = 0; i < twodimen.Length; i++)
            {
                for (int j = 0; j < twodimen[i].Length; j++)
                {
                    Console.Write(twodimen[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        //enum


        enum days { Sunday = 0, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        static void Enum()
        {
            Console.WriteLine("Enter the Number between 0-6 : ");
            int day = int.Parse(Console.ReadLine());

            if (day >= 0 && day <= 6)
            {
                days selected = (days)day;
                Console.WriteLine("The selected day is " + selected);
            }
            else
            {
                Console.WriteLine("Enter a Valid Number ");
            }

        }

        //Static constructor

        static int interest = 6;

        static Program()
        {
            Console.WriteLine("Welcome all");
        }

        public Program(int age, string name)
        {
            Console.WriteLine(age + " " + name + " " + interest);
        }

        //inheritance

        class Student
        {
            private string Rollno;
            private string Name;
            private string Class;

            public void GetData()
            {
                Console.Write("Enter Roll No : ");
                Rollno = Console.ReadLine();
                Console.Write("Name : ");
                Name = Console.ReadLine();
                Console.Write("Enter Class : ");
                Class = Console.ReadLine();

            }

            public void PutData()
            {
                Console.Write($"Name : {Name}");
                Console.Write($"Class : {Class}");
                Console.Write($"RollNo : {Rollno}");
            }
        }

        class Marks : Student
        {
            protected int[] a = new int[5];

            public void GetMarks()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("Enter Subject {0} marks :", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
            }

            public void PutMarks()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Marks in Subject {0} is {1}  ", i + 1, a[i]);

                }
            }

        }

        class Result : Marks
        {
            int Totalmarks = 0;

            public void GetResults()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Totalmarks = Totalmarks + a[i];
                }
            }

            public void PutResults()
            {
                Console.WriteLine("====== Results ======");
                PutData();
                PutMarks();

            }

        }

       

    }
}





