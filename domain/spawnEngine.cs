namespace PokeGeo.Engine.Domain;

public class spawnEngine {

    public pokemonType DetermineType(EnviromentData environment)
    {
        if (environment.Temperature >= 30)
            return pokemonType.Fire;

        if (environment.Biome == "Ocean")
            return pokemonType.Water;

        if (environment.Biome == "Forest")
            return pokemonType.Grass;

        return pokemonType.Normal;
    }
}