using System.Text.Json.Serialization;

namespace PokeGeo.Engine.Domain;

public class pokemonDto
{
    public string Name { get; set; } = string.Empty;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public pokemonType Type { get; set; }

    public string SpriteUrl { get; set; } = string.Empty;
}
