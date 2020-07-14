using System;
using System.Collections.Generic;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the StarBuzz Coffee (Decorator Pattern)");
            var expresso = new Expresso();
            expresso.SetSize(Models.Size.Big);
            var milk = new Milk(expresso);
            var houseBlend = new HouseBlend();
            var mocha= new Mocha(houseBlend);
            var darkRoast = new DarkRoast();
            var soy= new Soy(darkRoast);
            var decaf = new Decaf();
            decaf.SetSize(Models.Size.Small);
            var milky= new Milk(decaf);
            var whip = new Whip(milky);


            List<IBeverage> coffeList = new List<IBeverage>() { milk, mocha, soy, whip };

            foreach (var coffee in coffeList)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(coffee.GetDescription());
                Console.WriteLine(coffee.GetSize().ToString());
                Console.WriteLine(coffee.Cost() + "€");
            }
        }
    }
}
