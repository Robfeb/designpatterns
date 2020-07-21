using System;
using StatePattern.States;

namespace StatePattern
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noCoinState;
        IState hasCoinState;
        IState soldState;
        IState winnerState;
        IState state;
        int balls = 0;
        public GumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noCoinState = new NoCoinState(this);
            hasCoinState = new HasCoinState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            this.balls = count;
            if (count > 0)
            {
                state = noCoinState;
            }
            else
                state = soldOutState;
        }
        public int GetGumBallsCount()
        {
            return balls;
        }
        public void InsertCoin()
        {
            state.InsertCoin();
        }

        public void EjectCoin()
        {
            state.EjectCoin();
        }
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        public void SetState(StateKind state)
        {
            switch (state)
            {
                case StateKind.HAS_COIN:
                    this.state = hasCoinState;
                    break;
                case StateKind.NO_COIN:
                    this.state = noCoinState;
                    break;
                case StateKind.SOLD:
                    this.state = soldState;
                    break;
                case StateKind.SOLD_OUT:
                    this.state = soldOutState;
                    break;
                case StateKind.WINNER:
                    this.state = winnerState;
                    break;
            }
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (balls != 0)
            {
                balls--;
            }
        }
        public override string ToString()
        {
            return balls + " gumballs - " + state;
        }
    }
}
