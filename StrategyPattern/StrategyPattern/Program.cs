using System;
using System.Collections.Generic;
using BehaviorPattern.Implementations;
using BehaviorPattern.Models;

namespace BehaviorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing Strategy Pattern through ducks examples!");
            var modelDuck = new ModelDuck();
            
            IEnumerable < Duck > duckList = new List<Duck>
            {
                new Duck(),
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck(),
                new DecoyDuck(),
                new ModelDuck(),
                modelDuck
            };
            foreach (var duck in duckList)
            {
                ShowDuckActions(duck);
            }
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            ShowDuckActions(modelDuck);
            Console.ReadLine();

        }
        static void ShowDuckActions(Duck duck)
        {
            Console.WriteLine("-----------------");
            duck.Display();
            duck.Fly();
            duck.Quack();
            duck.Swim();
        }
    }
}
