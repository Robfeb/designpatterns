using System;
using System.Collections.Generic;
using BehaviorPattern.Models;

namespace BehaviorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing Behavior Pattern through ducks examples!");
            IEnumerable<Duck> duckList = new List<Duck>
            {
                new Duck(),
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };
            foreach (var duck in duckList)
            {
                ShowDuckActions(duck);
            }
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
