using System;
namespace StatePattern.States
{
    public interface IState
    {
        public void InsertCoin();
        public void EjectCoin();
        public void TurnCrank();
        public void Dispense();
    }
}
