using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new ChicagoStyleCheesePizza(),
                PizzaType.Chicago => new ChicagoPizza(),
                PizzaType.Greek => new ChicagoStyleGreekPizza(),
                PizzaType.Pepperoni => new ChicagoStylePepperoniPizza(),
                PizzaType.Veggie => new ChicagoStyleVeggiePizza(),
                _ => null,
            };
            return pizza;
        }
    }
}
