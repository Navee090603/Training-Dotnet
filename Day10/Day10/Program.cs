using System;
using System.Collections.Generic;


namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {

            //PredigateEg();
            //FunctionDeligateEg();

            Animal animal = GetAnimal();
            Console.WriteLine(animal.speak()); 
            Console.ReadLine();
        }

        //Predigate Example:
        public static void PredigateEg()
        {
            //creating list
            List<int> numbers = new List<int> ();

            Console.WriteLine("Enter the numbers to check divisible by 3 or not :");
            
            for(int i = 0; i < 5; i++) 
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }
            



            //prdicate ---> Take one parameter and return bool
            Predicate<int> isDivisibleBy3 = number => number % 3 == 0;

            //using Find all checking whether divisible by 3 or not
            List<int> DivisibleBy3 = numbers.FindAll(isDivisibleBy3);

            Console.WriteLine("Divisible by 3 are ");

            foreach (int num in DivisibleBy3)
            {
                Console.WriteLine(num);
            }
        }

        //Function Delegate

        public static void FunctionDeligateEg()
        {
            //input1
            Console.Write("Enter the First Number : ");
            int input1 = int.Parse(Console.ReadLine());

            //input2
            Console.Write("Enter the second Number : ");
            int input2 = int.Parse(Console.ReadLine());

            //inbuild funtion deligate
            Func<int, int, int> multiply = (a, b) => (a * b);
            int result = multiply(input1, input2);

            Console.WriteLine($"The result is: {result}");
        }

        //Covarience and Contra-Varience

        public class Animal
        {
            public string speak() => "I'm Parent";
        }

        public class Dog : Animal
        {
            public string Bark() => "Wooof!";
        }

        public static Animal GetAnimal()
        {
            Dog dog = new Dog();
            return dog;
        }
    }
}
