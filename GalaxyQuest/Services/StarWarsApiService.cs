using GalaxyQuest.Models;
using System.Net.Http;
using Newtonsoft.Json;
using GalaxyQuest.Interfaces;

namespace GalaxyQuest.Services
{
    public class StarWarsApiService : IStarWarsApiService
    {
        private readonly HttpClient _httpClient;
        public StarWarsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://swapi.dev/api");
        }


        public async Task<List<StarWarsPlanet>> GetAllPlanets()
        {
            var planetList = new List<StarWarsPlanet>();

             string url = "/planets/";
             var response = await _httpClient.GetAsync(url);

             if (response.IsSuccessStatusCode)
             {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<PlanetResult>(content);

                foreach (var planet in result.Results)
                {
                    planetList.Add(new StarWarsPlanet(planet.Name, planet.Population));
                }
             }

            return planetList;
        }
    }
}
