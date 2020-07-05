using System;
namespace ObserverPattern.Models
{
    public class ForecastDisplay: IDisplay
    {
        public ForecastDisplay()
        {
            Console.WriteLine($"Forecast Display Initiated");
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Forecast Display Temp:{temp} - Humidity:{humidity} - Pressure:{pressure}");
        }

    }
}
