using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the StarBuzz Coffee (Decorator Pattern)");
            var expresso = new Expresso();
            
            var houseBlend = new HouseBlend();
            houseBlend.SetMocha(true);
            var darkRoast = new DarkRoast();
            darkRoast.SetSoy(true);
            var decaf = new Decaf();
            decaf.SetMilk(true);
            List<Beverage> coffeList = new List<Beverage>() { expresso,houseBlend,darkRoast,decaf };

            foreach (var coffee in coffeList)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(coffee.GetDescription());
                Console.WriteLine(coffee.Cost() + "€");
            }
        }
    }
}
