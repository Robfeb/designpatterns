using System;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Implementations
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("I can Quack like a common duck");
        }
    }
}
