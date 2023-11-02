using GalaxyQuest.Models;

namespace GalaxyQuest.Interfaces
{
    public interface IStarWarsApiService
    {
        Task<List<StarWarsPlanet>> GetAllPlanets();
    }
}
