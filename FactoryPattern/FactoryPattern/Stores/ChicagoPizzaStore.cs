using System;
using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {

        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (pizzaType.Equals("greek"))
             {
                 pizza = new ChicagoStyleGreekPizza();
             }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (pizzaType.Equals("Chicago"))
            {
                pizza = new ChicagoPizza();
            }
            return pizza;
        }
    }
}
