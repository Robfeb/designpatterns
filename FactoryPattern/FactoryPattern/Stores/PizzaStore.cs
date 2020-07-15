using System;
using FactoryPattern.Models;

namespace FactoryPattern.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }
            else
                Console.WriteLine($"So Sorry! We don't have {pizzaType} here!");

            return pizza;
        }

        public abstract Pizza CreatePizza(string pizzaType);
    }
}
