using WeatherAPI_CSharp.Models;

namespace WeatherAPI_CSharp.Services;

public static class LocationService
{
    static List<Location> Locations { get; }
    static LocationService()
    {
        Locations = new List<Location>
        {
            new Location { City = "Brooklyn", State = "New York", Forecast = WeatherForecast.CreateNewForecast() },
            new Location { City = "Los Angeles", State = "California", Forecast = WeatherForecast.CreateNewForecast() },
        };
    }

    public static List<Location> GetAll() => Locations;

    public static Location? Get(Guid id) => Locations.FirstOrDefault(loc => loc.Id == id);

    public static void Add(Location location)
    {
        Locations.Add(location);
    }

    public static void Delete(Guid id)
    {
        var location = Get(id);
        if (location is null) return;

        Locations.Remove(location);
    }

    public static void Update(Location location)
    {
        var index = Locations.FindIndex(loc => loc.Id == location.Id);
        if (index == -1) return;

        Locations[index] = location;
    }
}