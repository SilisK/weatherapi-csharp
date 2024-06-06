namespace WeatherAPI_CSharp.Models;

public class Location
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? City { get; set; }
    public string? State { get; set; }
    public WeatherForecast? Forecast { get; set; }
}