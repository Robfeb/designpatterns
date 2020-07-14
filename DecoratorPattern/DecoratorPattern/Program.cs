using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the StarBuzz Coffee (Decorator Pattern)");
            var coffee1 = new Expresso();
            coffee1.setMilk(true);
            var coffee2 = new HouseBlend();
            var coffee3 = new DarkRoast();
            var coffee4 = new Decaf();
            List<Beverage> coffeList = new List<Beverage>() { coffee1,coffee2,coffee3,coffee4 };

            foreach (var coffee in coffeList)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(coffee.GetDescription());
                Console.WriteLine(coffee.Cost() + "€");
            }
        }
    }
}
