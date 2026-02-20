using Microsoft.AspNetCore.Mvc;
using PokeGeo.Engine.Domain;

namespace PokeGeo.Engine.controllers;

[ApiController]
[Route("api/spawn")]
public class SpawnController : ControllerBase {
    private readonly spawnEngine _engine = new();

    [HttpGet]
    public IActionResult getSpawn(double lat, double lng, double temperature, string biome) {

        var environment = new EnviromentData {
            Latitude = lat,
            Longitude = lng,
            Temperature = temperature, 
            Biome = biome
        };

        var type = _engine.DetermineType(environment);

        var result = new pokemonDto
        {
            Name = "placeholder",
            Type = type,
            SpriteUrl = "https://example.com/image.png"
        };

        return Ok(result);
    }
}