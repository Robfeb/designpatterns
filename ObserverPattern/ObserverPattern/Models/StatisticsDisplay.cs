using System;
using ObserverPattern.interfaces;

namespace ObserverPattern.Models
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private ISubject weatherData;
        private float temperature;
        private float humidity;
        private float pressure;
        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
            Console.WriteLine($"Statistics Display Initiated");
        }

        public void Display()
        {
            Console.WriteLine($"Statistics Display Temp:{temperature} - Humidity:{humidity} - Pressure:{pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
