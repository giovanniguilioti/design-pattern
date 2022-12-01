namespace factorymethod
{
    //ConcreteProduct
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela Carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmesão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}