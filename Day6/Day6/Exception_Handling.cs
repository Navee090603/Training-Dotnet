using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Exception_Handling
    {
        public static void Main()
        {
            int a = 10,b = 23;
            //Console.WriteLine(result);
            string[] books = { "OAD", "AI", "DS" };
            Console.WriteLine(books[3]);
            try
            {
                int result = a / b;
                Console.WriteLine("result");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("OOPS Something Went Wrong !");
            }

            finally
            {
                Console.WriteLine("Thank You!!!!");
            }

            Console.Read();
        }
    }
}
