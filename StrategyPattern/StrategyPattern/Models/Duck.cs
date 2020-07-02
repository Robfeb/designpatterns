using System;
using BehaviorPattern.Implementations;
using BehaviorPattern.Interfaces;

namespace BehaviorPattern.Models
{
    public class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public void SetFlyBehavior(IFlyBehavior flyB)
        {
            flyBehavior = flyB;
        }
        public void SetQuackBehavior(IQuackBehavior quarkB)
        {
            quackBehavior = quarkB;
        }

        public virtual void Display()
        {
            Console.WriteLine("I'm a common Duck, showing as a common duck");
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public virtual void Swim()
        {
            Console.WriteLine("I'm a common Duck, I can Swim!!");
        }
        
    }
}
