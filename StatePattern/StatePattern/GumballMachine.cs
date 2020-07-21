using System;
namespace StatePattern
{
    public class GumballMachine
    {
        StateKind state = StateKind.SOLD_OUT;
        int count = 0;
        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = StateKind.NO_COIN;
            }
        }

        public void InsertCoin()
        {
            if (state == StateKind.HAS_COIN)
            {
                Console.WriteLine("You can't insert another coin");
            }
            else if (state == StateKind.NO_COIN)
            {
                state = StateKind.HAS_COIN;
                Console.WriteLine("You inserted a coin");
            }
            else if (state == StateKind.SOLD_OUT)
            {
                Console.WriteLine("You can't insert a coin, the machine is sold out");
            }
            else if (state == StateKind.SOLD)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }

        public void EjectCoin()
        {
            if (state == StateKind.HAS_COIN)
            {
                Console.WriteLine("coin returned");
                state = StateKind.NO_COIN;
            }
            else if (state == StateKind.NO_COIN)
            {
                Console.WriteLine("You haven't inserted a coin");
            }
            else if (state == StateKind.SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (state == StateKind.SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a coin yet");
            }
        }
        public void TurnCrank()
        {
            if (state == StateKind.SOLD)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            }
            else if (state == StateKind.NO_COIN)
            {
                Console.WriteLine("You turned but there's no coin");
            }
            else if (state == StateKind.SOLD_OUT)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (state == StateKind.HAS_COIN)
            {
                Console.WriteLine("You turned..."); state = StateKind.SOLD;
                Dispense();
            }
        }
        public void Dispense()
        {
            if (state == StateKind.SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot"); count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    state = StateKind.SOLD_OUT;
                }
                else
                {
                    state = StateKind.NO_COIN;
                }
            }
            else if (state == StateKind.NO_COIN)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (state == StateKind.SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == StateKind.HAS_COIN)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }
        public override string ToString()
        {
            return count+ " gumballs - "+ state;
        }
    }
}
