using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Arthimetic_Opertor
    {
        static void Main(string[] args)
        {
            
            
                // Input data
                int pricePerItem =200;
                int quantity = 5;
                float discountRate = 0.10f;

                // Calculate total
                float totalPrice = pricePerItem * quantity;

                // Apply discount
                float discountAmount = totalPrice * discountRate;
                float finalAmount = totalPrice - discountAmount;

                // Output the results
                Console.WriteLine("=== Billing Summary ===");
                Console.WriteLine("Price per item: " + pricePerItem);
                Console.WriteLine("Total items   : " + quantity);
                Console.WriteLine("Total price   : " + totalPrice);
                Console.WriteLine("Discount (10%): " + discountAmount);
                Console.WriteLine("Final amount  : " + finalAmount);

                Console.ReadLine(); // Wait for user to press Enter
            
           

        }
    }


}
