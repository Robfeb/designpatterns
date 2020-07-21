using System;
namespace StatePattern.States
{
    public class HasCoinState : IState
    {
        GumballMachine gumballMachine;
        Random randomWinner = new Random(3);
        public HasCoinState(GumballMachine gumball)
        {
            gumballMachine = gumball;

        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectCoin()
        {
            Console.WriteLine("coin returned");
            gumballMachine.SetState(StateKind.NO_COIN);

        }

        public void InsertCoin()
        {
            Console.WriteLine("You can't insert another coin");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(3);
            if ((winner == 0) && (gumballMachine.GetGumBallsCount() > 1))
            {
                gumballMachine.SetState(StateKind.WINNER);
            }
            else
            {
                gumballMachine.SetState(StateKind.SOLD);
            }
        }
    }
}
