using System;

namespace SingletonPattern
{
    public class SingletonLazy
    {
        private static readonly SingletonLazy uniqueInstance = new SingletonLazy();
        private SingletonLazy() { }
        public static SingletonLazy GetInstance()
        {
            return uniqueInstance;
        }
        public void DoSomething()
        {
            Console.WriteLine("Do Something From SingletonLazy Class");
        }
    }
}
