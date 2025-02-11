using System;
using WeatherStationApp.Models;

namespace WeatherStationApp.Services
{
    public class MobileApp
    {
        public void Subscribe(WeatherStation station)
        {
            station.WeatherUpdated += delegate (object sender, WeatherEventArgs e)
            {
                Console.WriteLine($"[MobileApp] Weather Alert! {e.WeatherCondition}, {e.Temperature}°C");
            };
        }
    }
}
