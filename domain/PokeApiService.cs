using System.Net.Http.Json;

namespace PokeGeo.Engine.Domain;

public class PokeApiService {
    
    private readonly HttpClient _http = new();
    public async Task<string> GetRandomPokemonName () {

        var list = await _http.GetFromjsonAsync<PokemonList>(
            "https://pokeapi.co/api/v2/pokemon?limit=151"
        );
        var rand = new Random();
            return list!.results[rand.Next(list.results.Count)].name;
        }

    private class PokemonList
    {
        public List<PokemonItem> results { get; set; } = new();
    }

    private class PokemonItem
    {
        public string name { get; set; } = "";
    }
}