using System;
namespace ObserverPattern.Models
{
    public class ConditionsDisplay : IDisplay
    {
        public ConditionsDisplay()
        {
            Console.WriteLine($"Conditions Display Initiated");
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Conditions Display Temp:{temp} - Humidity:{humidity} - Pressure:{pressure}");
        }
    }
}
