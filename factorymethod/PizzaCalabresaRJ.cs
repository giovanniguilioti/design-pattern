using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factorymethod
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de calabresa Carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabresa especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}