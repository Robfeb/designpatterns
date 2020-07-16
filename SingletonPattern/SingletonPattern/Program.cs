using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Singleton Pattern project!");
            var single = Singleton.GetInstance();
            single.DoSomething();
            var singleLazy = SingletonLazy.GetInstance();
            singleLazy.DoSomething();
        }
    }
}
