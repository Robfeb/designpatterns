using System;
using ObserverPattern.interfaces;

namespace ObserverPattern.Models
{
    public class ForecastDisplay: IObserver, IDisplay
    {
        private ISubject weatherData;
        private float temperature;
        private float humidity;
        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
            Console.WriteLine($"Forecast Display Initiated");
        }

        public void Display()
        {
            Console.WriteLine($"Forecast Display Temp:{temperature} - Humidity:{humidity}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

    }
}
