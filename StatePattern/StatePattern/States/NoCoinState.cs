using System;
namespace StatePattern.States
{
    public class NoCoinState : IState
    {
        GumballMachine gumballMachine;
        public NoCoinState(GumballMachine gumball)
        {
            gumballMachine = gumball;

        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectCoin()
        {
            Console.WriteLine("You haven't inserted a coin");
        }

        public void InsertCoin()
        {

            Console.WriteLine("You inserted a coin");
            gumballMachine.SetState(StateKind.HAS_COIN);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there's no coin");
        }
    }
}
