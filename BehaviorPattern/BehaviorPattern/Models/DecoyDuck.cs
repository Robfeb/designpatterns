using System;
namespace BehaviorPattern.Models
{
    public class DecoyDuck: Duck
    {
        public override void Quack()
        {
            Console.WriteLine("I'm a Decoy Duck, I cannot Quack!!");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck, looking as wood made duck");
        }
        public override void Fly()
        {
            Console.WriteLine("I'm a Rubber Duck, I cannot fly!!!");
        }
    }
}
