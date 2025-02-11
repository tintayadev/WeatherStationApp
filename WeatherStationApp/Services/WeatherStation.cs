using System;
using WeatherStationApp.Models;

namespace WeatherStationApp.Services
{
    public class WeatherStation
    {
        // Define an event
        public event EventHandler<WeatherEventArgs> WeatherUpdated;

        // Method to update weather and trigger event
        public void UpdateWeather(string condition, double temperature)
        {
            Console.WriteLine($"WeatherStation: Updating weather to {condition}, {temperature}°C...");
            OnWeatherUpdated(new WeatherEventArgs(condition, temperature));
        }

        // Method to raise the event
        protected virtual void OnWeatherUpdated(WeatherEventArgs e)
        {
            WeatherUpdated?.Invoke(this, e); // Raise the event safely
        }
    }
}
