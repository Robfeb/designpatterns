using System;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Implementations
{
    public class MuteQuack: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I cannot Quack!!!");
        }
    }
}
