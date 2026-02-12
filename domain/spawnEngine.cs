namespace PokeGeo.Engine.Domain;

public class spawnEngine {

    public PokemonType DetermineType(EnvironmentData environment)
    {
        if (environment.Temperature >= 30)
            return PokemonType.Fire;

        if (environment.Biome == "Ocean")
            return PokemonType.Water;

        if (environment.Biome == "Forest")
            return PokemonType.Grass;

        return PokemonType.Normal;
    }
}