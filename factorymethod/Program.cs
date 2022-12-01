using factorymethod;

Console.WriteLine("===PIZZARIA===\n");
Console.WriteLine("Informa o local: (S)-São Paulo / (R)-Rio de Janeiro");
var localEscolhido = Console.ReadLine().ToUpper();

Console.WriteLine("Escolha a pizza (M)-Mussarela / (C)-Calabresa");
var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
    PizzaFactoryMethod pizzaria =
        PizzaSimpleFactory.CriarPizzaria(localEscolhido);
    
    var pizza = pizzaria.MontaPizza(pizzaEscolhida);

    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("\nPizza concluida com sucesso");
}
catch(Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
Console.ReadLine();
