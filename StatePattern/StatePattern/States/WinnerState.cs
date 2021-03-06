﻿using System;
namespace StatePattern.States
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;
        public WinnerState(GumballMachine gumball)
        {
            gumballMachine = gumball;

        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetGumBallsCount() == 0)
            {
                gumballMachine.SetState(StateKind.SOLD_OUT);
            }
            else
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
                if (gumballMachine.GetGumBallsCount() > 0)
                {
                    gumballMachine.SetState(StateKind.NO_COIN);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.SetState(StateKind.SOLD_OUT);
                }
            }
        }

        public void EjectCoin()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertCoin()
        {

            Console.WriteLine("Please wait, we're already giving you a gumball");

        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }
    }
}
