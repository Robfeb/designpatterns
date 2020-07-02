using System;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Implementations
{
    public class FlyRocketPowered : IFlyBehavior
    
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying to the moon!!!");
        }
    }
}