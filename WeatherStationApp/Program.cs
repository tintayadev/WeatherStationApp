using System;
using WeatherStationApp.Services;

namespace WeatherStationApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Initializing Weather Station App...\n");

            // Create instances
            WeatherStation station = new WeatherStation();
            ConsoleLogger logger = new ConsoleLogger();
            MobileApp app = new MobileApp();

            // Subscribe to events
            logger.Subscribe(station);
            app.Subscribe(station);

            // Additional subscription using a Lambda
            station.WeatherUpdated += (sender, e) =>
            {
                Console.WriteLine($"[Lambda] Quick Update: {e.WeatherCondition}, {e.Temperature}°C");
            };

            // Simulate weather updates
            station.UpdateWeather("Sunny", 25.5);
            station.UpdateWeather("Rainy", 18.2);
        }
    }
}
