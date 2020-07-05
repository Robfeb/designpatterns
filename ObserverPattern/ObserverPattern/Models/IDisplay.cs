using System;
namespace ObserverPattern.Models
{
    public interface IDisplay
    {
        void Update(float temp, float humidity, float pressure);
    }
}
