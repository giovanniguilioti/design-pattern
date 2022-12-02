using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstractfactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}