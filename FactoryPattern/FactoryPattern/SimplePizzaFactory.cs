using System;
using FactoryPattern.Models;

namespace FactoryPattern
{
    public class SimplePizzaFactory
    {

        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            /* else if (pizzatype.Equals("greek"))
             {
                 pizza = new GreekPizza();
             }
            */
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (pizzaType.Equals("hawaian"))
            {
                pizza = new HawaianPizza();
            }
            else if (pizzaType.Equals("margarita"))
            {
                pizza = new MargaritaPizza();
            }
            return pizza;
        }

    }
}
