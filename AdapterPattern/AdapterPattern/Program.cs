using System;
using AdapterPattern.Adapters;
using AdapterPattern.Models;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adapter Pattern!");
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            turkey.Fly();

            TestDuck(duck);
            TestDuck(turkeyAdapter);
        }

        static void TestDuck(IDuck duck)
        {
            Console.WriteLine("****************");
            duck.Quack();
            duck.Fly();
        }
    }
}
