using System;
using ObserverPattern.interfaces;

namespace ObserverPattern.Models
{
    public class HeatDisplay : IObserver, IDisplay
    {
        private ISubject weatherData;
        private float temperature;
        private float humidity;
        private float pressure;
        public HeatDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
            Console.WriteLine($"Heat Display Initiated");
        }

        public void Display()
        {
            Console.WriteLine($"Heat Display Temp:{temperature} ");
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
