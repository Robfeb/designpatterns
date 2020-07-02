using System;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Implementations
{
    public class Squeak: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can Squeak!!!");
        }
    }
}
