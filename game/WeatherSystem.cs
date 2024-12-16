public class WeatherSystem
{
    public string CurrentWeather { get; private set; }

    public WeatherSystem()
    {
        ChangeWeather("Clear"); // Set default weather
    }

    public void ChangeWeather(string weather)
    {
        CurrentWeather = weather;
        Console.WriteLine($"The weather has changed to {CurrentWeather}.");
    }

    public void ApplyWeatherEffects(Character character)
    {
        if (CurrentWeather == "Rain")
        {
            character.TakeDamage(5);
            Console.WriteLine("The rain is causing you to take additional damage!");
        }
    }
}
