using System;
namespace ObserverPattern.Models
{
    public class StatisticsDisplay : IDisplay
    {
        public StatisticsDisplay()
        {
            Console.WriteLine($"Statistics Display Initiated");
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Statistics Display Temp:{temp} - Humidity:{humidity} - Pressure:{pressure}");
        }
    }
}
