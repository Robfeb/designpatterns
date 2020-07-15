using System;
using FactoryPattern.Models;

namespace FactoryPattern
{
    public class PizzaStore
    {
       public Pizza OrderPizza(string pizzatype)
        {
            Pizza pizza ;
            if (pizzatype.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (pizzatype.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            else if (pizzatype.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (pizzatype.Equals("hawaian"))
            {
                pizza = new HawaianPizza();
            }
            else
                pizza = new MargaritaPizza();



            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;


        }
    }
}
