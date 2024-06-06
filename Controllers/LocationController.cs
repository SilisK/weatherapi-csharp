using WeatherAPI_CSharp.Models;
using WeatherAPI_CSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI_CSharp.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationController : ControllerBase
{
    public LocationController() { }

    [HttpGet(Name = "GetAllLocations")]
    public IEnumerable<Location> Get()
    {
        return LocationService.GetAll().ToArray();
    }

    [HttpGet("{id}")]
    public ActionResult<Location> Get(Guid id)
    {
        var location = LocationService.Get(id);
        if (location is null) return NotFound();

        return location;
    }
}