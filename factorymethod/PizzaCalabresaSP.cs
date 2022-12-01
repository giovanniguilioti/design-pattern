using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factorymethod
{
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de calabresa Paulista com muita calabresa";
            massa = "Massa fina crocante";
            molho = "Molho de tomate italiano";
            ingredientes.Add("Fatias de calabresa defumada especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}