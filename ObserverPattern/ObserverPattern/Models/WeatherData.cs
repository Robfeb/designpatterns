using System;
namespace ObserverPattern.Models
{
    public class WeatherData
    {
        private ConditionsDisplay currentConditionsDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastDisplay forecastDisplay;

        public WeatherData()
        {
            currentConditionsDisplay = new ConditionsDisplay();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
        }
        public float GetTemperature() { return 1; }
        public float GetHumidity() { return 1; }
        public float GetPressure() { return 1; }

        public void MessurementsChanged() {
            float temp = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();

            currentConditionsDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);

        }

    }
}
