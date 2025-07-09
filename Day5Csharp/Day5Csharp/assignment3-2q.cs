using System;
using System.Linq;


namespace Day5Csharp
{
    // 2. Create a class called student which has data members like rollno, name, class, Semester, branch, int [] marks=new int marks [5](marks of 5 subjects )
    class Student
    {

        //data members

        public double RollNo;
        public string Name;
        public string Class;
        public int Semester;
        public string Branch;
        int[] Marks = new int[5];

        //Constructor

        public Student()
        {
            Console.Write("\nEnter the Roll Number : ");
            RollNo = double.Parse(Console.ReadLine());

            Console.Write("Enter Your Name : ");
            Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Your Class (A, B or C) : ");
            Class = Convert.ToString(Console.ReadLine());

            Console.Write("Which Semester Are you now 1-8 : ");
            Semester = int.Parse(Console.ReadLine());

            Console.Write("Which Branch are you from : ");
            Branch = Convert.ToString(Console.ReadLine());
        }

        //GetMarks Method for getting 5 Subject Mark
        public void GetMarks()
        {
            Console.WriteLine("\n*******Enter Your mark's on 5 subject*******");
            Console.WriteLine();
            for(int i = 0; i < Marks.Length; i++)
            {
                Console.Write($"Enter the {i+1} subject Mark : ");
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }

        //DisplayResult Method for checking the condition
        public void DisplayResult()
        {
            double Average = Marks.Average();

            bool pass = true;
            foreach(int i in Marks)
            {
                if (i < 35)
                {
                    pass = false;
                }
            }

            if(!pass || Average < 50)
            {
                Console.WriteLine("You Failed....");
            }
            else { Console.WriteLine("You Passed...."); }
        }

        //Display Method for displaying all object member values

        public void DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine($"********* Semester Mark Detail's *********");
            Console.WriteLine("\nRoll Number : {0} ",RollNo);
            Console.WriteLine("Name : {0} ",Name);
            Console.WriteLine("Class : {0} ",Class);
            Console.WriteLine("Semester : {0}",Semester);
            Console.WriteLine("Branch : {0}",Branch);

            Console.Write("Your result  :  "); DisplayResult(); //Whether pass or fail will be shown here



        }

        public static void Main()
        {

            //creating object for class student
            Student student = new Student();

            student.GetMarks();
            student.DisplayData();

            Console.Read();
        }

    }
}
