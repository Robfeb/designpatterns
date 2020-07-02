using System;
namespace BehaviorPattern.Models
{
    public class RubberDuck: Duck
    {

        public override void Quack()
        {
            Console.WriteLine("I'm a Rubber Duck, I have a special Quack!!");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck, looking as plastic made duck");
        }
        public override void Fly()
        {
            Console.WriteLine("I'm a Rubber Duck, I cannot fly!!!");
        }
    }
}
