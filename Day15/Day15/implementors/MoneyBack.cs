using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15.implementors
{
    class MoneyBack : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 500.0f;
        }

        public int GetCardLimit()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }
    }
}
