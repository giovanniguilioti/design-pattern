using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factorymethod
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }
        protected abstract Pizza CriarPizza(string tipo);
    }
}