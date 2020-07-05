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
            WeatherData weather = new WeatherData();
            weather.MessurementsChanged();
            
            Console.ReadLine();
        }
    }
}
