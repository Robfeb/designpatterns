using System;
using BehaviorPattern.Implementations;

namespace BehaviorPattern.Models
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();

        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck");
        }
    }
}
