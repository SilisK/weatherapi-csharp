namespace WeatherAPI_CSharp;

public class WeatherForecast
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public static WeatherForecast CreateNewForecast(double? index = null)
    {
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(index == null ? DateTime.Now : DateTime.Now.AddDays((double)index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
    }
}
