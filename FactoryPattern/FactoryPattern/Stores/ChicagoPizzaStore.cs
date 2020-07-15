using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        /*
         *Normal factory
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
        */
        /*Abstract factory*/
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new ClassicCheesePizza(ingredientFactory),
                PizzaType.Margarita => new ClassicMargaritaPizza(ingredientFactory),
                PizzaType.Greek => new ClassicGreekPizza(ingredientFactory),
                PizzaType.Pepperoni => new ClassicPepperoniPizza(ingredientFactory),
                PizzaType.Veggie => new ClassicVeggiePizza(ingredientFactory),
                _ => null,
            };
            return pizza;
        }
    }
}
