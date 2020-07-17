using System;
namespace AdapterPattern.Models
{
    public class MallardDuck : IDuck
    {
        public MallardDuck()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I'm a Mallard Duck, I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("I'm a Mallard Duck, I'm Quacking");
        }
    }
}
