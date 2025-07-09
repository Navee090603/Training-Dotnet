using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    interface IName
    {
        string Name { get; set; } //decl of property
    }

    class Employee : IName
    {
        public string Name { get; set; }
    }

    class Company : IName
    {
        //private string companyname { get; set; } //class property

        public string companyname;
        public int age { get; set; } = 21;

        public string Name
        {
            get { return companyname; }
            set { companyname = value; }
        }
    }

    class InterfaceWithProperty
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Naveen";

            IName c = new Company();
            c.Name = "Infinite Ltd.,";

            Console.WriteLine("This is {0} from {1}",e.Name,c.Name);
            Company company = new Company();
            company.Name = "New Infinite";
            company.age = 25;

            Console.WriteLine(company.Name+" is "+company.age+" Years ");
            Console.Read();

        }
    }
}
