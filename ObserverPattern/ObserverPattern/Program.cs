using System;
using ObserverPattern.Models;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Observer Pattern Example");
            Console.WriteLine("---------------------------------------");
            WeatherData weatherData = new WeatherData();
            ConditionsDisplay currentDisplay = new ConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.ReadLine();
        }
    }
}
