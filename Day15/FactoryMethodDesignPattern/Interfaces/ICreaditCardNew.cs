using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    interface ICreaditCardNew : 
    {
        string GetCardType();
        int GetCardLimit();
        float GetAnnualCharges();
    }
}
