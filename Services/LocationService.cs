using WeatherAPI_CSharp.Models;

namespace WeatherAPI_CSharp.Services;

public static class LocationService
{
    static List<Location> Locations { get; }
    static LocationService()
    {
        Locations = new List<Location>
        {
            new Location {}
        };
    }
}