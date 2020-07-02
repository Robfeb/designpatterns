using System;
using BehaviorPattern.Implementations;

namespace BehaviorPattern.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck, looking as Mallard duck");
        }
    }
}
