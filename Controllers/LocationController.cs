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

    [HttpPost]
    public IActionResult Create(Location location)
    {
        LocationService.Add(location);
        return CreatedAtAction(nameof(Get), new { id = location.Id }, location);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Location location)
    {
        if (id != location.Id) return BadRequest();

        var existingLocation = LocationService.Get(id);
        if (existingLocation is null) return NotFound();

        LocationService.Update(location);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var location = LocationService.Get(id);

        if (location is null) return NotFound();

        LocationService.Delete(id);

        return NoContent();
    }
}