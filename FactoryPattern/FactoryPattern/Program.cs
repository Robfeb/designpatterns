using System;
using FactoryPattern.Interfaces;
using FactoryPattern.Stores;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Welcome to the Pizza Store (Factory Pattern)");
            var pizzaStore = new ChicagoPizzaStore();
            pizzaStore.OrderPizza(PizzaType.Cheese);
            pizzaStore.OrderPizza(PizzaType.Hawaian);
            //pizzaStore.OrderPizza("greek");
            pizzaStore.OrderPizza(PizzaType.Pepperoni);
            pizzaStore.OrderPizza(PizzaType.Veggie);
            Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
            var nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza(PizzaType.Cheese);
            nyPizzaStore.OrderPizza(PizzaType.Hawaian);
            //pizzaStore.OrderPizza("greek");
            nyPizzaStore.OrderPizza(PizzaType.Pepperoni);
            nyPizzaStore.OrderPizza(PizzaType.Veggie);
        }
    }
}
