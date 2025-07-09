using System;
using Day15.implementors;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the type of card from the user
            Console.Write("Enter Card Type : ");
            string cardType = Console.ReadLine();
            ICreditCard creditCard = CreditCardFactory.GetCreditCard(cardType);

            //based on the card type we will creare appropriate objects
            //if (cardType == "MoneyBack")
            //{
            //    creditCard = new MoneyBack();
            //}
            //else if (cardType == "Platinum")
            //{
            //    creditCard = new Platinum();
            //}
            //else if (cardType == "Titanium")
            //{
            //    creditCard = new Titanium();
            //}

            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : "+ creditCard.GetCardLimit());
                Console.WriteLine("Annual Charges : "+ creditCard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type...");
            }
            Console.Read();
        }
    }
}
