using System;
namespace StatePattern.States
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumball)
        {
            gumballMachine = gumball;

        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectCoin()
        {
            Console.WriteLine("You can't eject, you haven't inserted a coin yet");
        }

        public void InsertCoin()
        {

            Console.WriteLine("You can't insert a coin, the machine is sold out");

        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
    }
}
