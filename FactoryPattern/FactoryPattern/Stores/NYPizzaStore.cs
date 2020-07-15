using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        /* //normal factory
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
                }*/
        /* abstract factory*/
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new ClassicCheesePizza(ingredientFactory),
                PizzaType.Margarita => new ClassicMargaritaPizza(ingredientFactory),
                PizzaType.Hawaian => new ClassicHawaianPizza(ingredientFactory),
                PizzaType.Pepperoni => new ClassicPepperoniPizza(ingredientFactory),
                _ => null,
            };
            return pizza;
        }
    }
}
