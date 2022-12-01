namespace factorymethod
{
    //ConcreteProduct
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