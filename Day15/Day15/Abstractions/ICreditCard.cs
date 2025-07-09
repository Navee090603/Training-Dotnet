using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCardLimit();
        float GetAnnualCharges();
    }
}
