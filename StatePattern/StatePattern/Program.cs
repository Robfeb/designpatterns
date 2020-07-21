using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the State Pattern project!");

            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertCoin();
            gumballMachine.EjectCoin();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            gumballMachine.EjectCoin();
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertCoin();
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);

        }
    }
}
