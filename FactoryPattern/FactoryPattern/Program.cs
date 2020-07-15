using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Store (Factory Pattern)");
            var pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("hawaian");
            //pizzaStore.OrderPizza("greek");
            pizzaStore.OrderPizza("pepperoni");
            pizzaStore.OrderPizza("veggie");
        }
    }
}
