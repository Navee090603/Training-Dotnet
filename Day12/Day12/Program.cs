using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intval = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter the number {i + 1} :");
                while (!int.TryParse(Console.ReadLine(), out intval[i]))
                {
                    Console.Write("Invalid input. Please enter a valid integer: ");
                }
            }

            //Query Expression
            IEnumerable<int> oddvalues = from v in intval
                                         where (v % 2) != 0
                                         select v;

            //For Displaying Purpose
            foreach (int x in oddvalues)
            {
                Console.WriteLine(x);
            }



            Console.ReadLine();
        }
    }

    class Student
    {
        public double Id { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> stdlist = new List<Student>()
            {
                new Student{Id = 101, StudentName="Naveen", Email="Naveen@gmail.com"},
                new Student{Id = 102, StudentName="Nithin", Email="Nithin@gmail.com"},
                new Student{Id = 103, StudentName="Nikitha", Email="Nikitha@gmail.com"},
            };

            return stdlist;

        }
    }
}
