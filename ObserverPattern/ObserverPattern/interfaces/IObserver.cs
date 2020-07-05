using System;
namespace ObserverPattern.interfaces
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
