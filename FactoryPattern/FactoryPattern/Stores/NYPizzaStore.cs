using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public class NYPizzaStore : PizzaStore
    {

        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new NYStyleCheesePizza(),
                PizzaType.NewYork => new NYPizza(),
                PizzaType.Pepperoni => new NYStylePepperoniPizza(),
                PizzaType.Hawaian => new NYStyleHawaianPizza(),
                _ => null,
            };
            return pizza;
        }
    }
}
