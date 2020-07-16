using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
        public void DoSomething()
        {
            Console.WriteLine("Do Something From Singleton Class");
        }
    }
}
