using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstractfactory
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}