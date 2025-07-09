using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15.implementors
{
    class Platinum : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 2000.0f;
        }

        public int GetCardLimit()
        {
            return 25000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }
    }
}
