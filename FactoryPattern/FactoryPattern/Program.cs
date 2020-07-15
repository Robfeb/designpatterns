using System;
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
            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("hawaian");
            //pizzaStore.OrderPizza("greek");
            pizzaStore.OrderPizza("pepperoni");
            pizzaStore.OrderPizza("veggie");
            Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
            var nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza("cheese");
            nyPizzaStore.OrderPizza("hawaian");
            //pizzaStore.OrderPizza("greek");
            nyPizzaStore.OrderPizza("pepperoni");
            nyPizzaStore.OrderPizza("veggie");
        }
    }
}
