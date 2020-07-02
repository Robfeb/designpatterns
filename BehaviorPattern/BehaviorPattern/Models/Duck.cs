using System;

namespace BehaviorPattern.Models
{
    public class Duck
    {
        public virtual void Display()
        {
            Console.WriteLine("I'm a common Duck, showing as a common duck");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I'm a common Duck, I can fly!!!");
        }

        public virtual void Quack()
        {
            Console.WriteLine("I'm a common Duck, I can Quack like a common duck");
        }

        public virtual void Swim()
        {
            Console.WriteLine("I'm a common Duck, I can Swim!!");
        }
        
    }
}
