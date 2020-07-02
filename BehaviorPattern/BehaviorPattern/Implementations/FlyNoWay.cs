using System;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Implementations
{
    public class FlyNoWay: IFlyBehavior
    {
     
        public void Fly()
        {
            Console.WriteLine("I cannot fly!!!");
        }
    }
}
