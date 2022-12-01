namespace factorymethod
{
    //Creator
    public abstract class PizzaFactoryMethod
    {
        protected abstract Pizza CriarPizza(string tipo);
        public Pizza MontaPizza(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }
    }
}