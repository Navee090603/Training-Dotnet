using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    interface ICustomer
    {
        //method declaration
         void Print();
         int Add(int a, int b);
    }

    interface ISupplier
    {
        void Print();
    }

   
    class Customer : ICustomer,ISupplier
    {
        void ICustomer.Print()
        {
            Console.WriteLine("Hello from Print Method of Icustomer");
        }

        public void Print()
        {
            Console.WriteLine("Hello from Print Method of Supplier");
        }

        public int Add(int x,int y)
        {
            return x + y;
        }

        
    }

    class InterfaceTester
    {
        static void Main()
        {
            Customer customer = new Customer();
            ((ICustomer)customer).Print();
            ((ISupplier)customer).Print();
            

            //customer.Print();

            //ICustomer icust = new Customer();
            //icust.Print();

            //ISupplier isupp = new Customer();
            //isupp.Print();
            

            Console.Read();
        }
    }
}
