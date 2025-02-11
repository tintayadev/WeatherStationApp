using System;

namespace WeatherStationApp.Models
{
    public class WeatherEventArgs : EventArgs
    {
        public string WeatherCondition { get; }
        public double Temperature { get; }

        public WeatherEventArgs(string condition, double temperature)
        {
            WeatherCondition = condition;
            Temperature = temperature;
        }
    }
}
