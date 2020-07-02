using System;
using BehaviorPattern.Implementations;
namespace BehaviorPattern.Models
{
    public class RedHeadDuck: Duck
    {
        public RedHeadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Red Head Duck, looking as Red Head duck");
        }
    
    }
}
