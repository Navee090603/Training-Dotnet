using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15.implementors
{
    class Titanium : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 1500.0f;
        }

        public int GetCardLimit()
        {
            return 25000;
        }

        public string GetCardType()
        {
            return "Titanium Super";
        }
    }
}
