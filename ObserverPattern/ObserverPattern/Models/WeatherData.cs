using System;
using System.Collections.Generic;
using ObserverPattern.interfaces;

namespace ObserverPattern.Models
{
    public class WeatherData : ISubject
    {

        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);

        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
