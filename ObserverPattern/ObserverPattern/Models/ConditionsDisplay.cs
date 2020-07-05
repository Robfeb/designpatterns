using System;
using ObserverPattern.interfaces;

namespace ObserverPattern.Models
{
    public class ConditionsDisplay : IObserver ,IDisplay
    {
        private ISubject weatherData;
        private float temperature;
        private float humidity;
        private float pressure;
        public ConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
            Console.WriteLine($"Conditions Display Initiated");
        }

        public void Display()
        {
            Console.WriteLine($"Conditions Display Temp:{temperature} - Humidity:{humidity} - Pressure:{pressure}");
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
