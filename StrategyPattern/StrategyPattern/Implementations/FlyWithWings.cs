using System;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Implementations
{
    public class FlyWithWings: IFlyBehavior
    {
     
        public void Fly()
        {
            Console.WriteLine("I can fly with Wings!!");
        }
    }
}
