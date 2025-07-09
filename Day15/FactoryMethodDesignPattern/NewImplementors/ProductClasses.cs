using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15.NewImplementors
{
    class MoneyBack : ICreditCardNew
    {
        public float GetAnnualCharges()
        {
            return 500.0f;
        }
https://www.msn.com/en-us/money/watchlist?id=auvwzr&tab=Markets&ocid=winp2fptaskbarhoverent&cvid=22fd5812b83244ece52100d37c792a24
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

