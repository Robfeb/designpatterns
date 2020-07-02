using System;
using BehaviorPattern.Implementations;
namespace BehaviorPattern.Models
{
    public class DecoyDuck: Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck, looking as wood made duck");
        }
    }
}
