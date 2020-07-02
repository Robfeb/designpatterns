using System;
using BehaviorPattern.Implementations;
namespace BehaviorPattern.Models
{
    public class RubberDuck: Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();

        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck, looking as plastic made duck");
        }
    }
}
