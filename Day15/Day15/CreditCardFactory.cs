using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day15.implementors;

namespace Day15
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new Platinum();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }

            return creditCard;
        }
    }
}
