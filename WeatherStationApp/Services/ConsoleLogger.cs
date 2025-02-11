using System;
using WeatherStationApp.Models;

namespace WeatherStationApp.Services
{
    public class ConsoleLogger
    {
        public void Subscribe(WeatherStation station)
        {
            station.WeatherUpdated += LogWeather; // Subscribe using += operator
        }

        private void LogWeather(object sender, WeatherEventArgs e)
        {
            Console.WriteLine($"[ConsoleLogger] Weather Updated: {e.WeatherCondition}, Temp: {e.Temperature}°C");
        }
    }
}
