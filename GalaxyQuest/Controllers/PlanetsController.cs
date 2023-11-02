using GalaxyQuest.Interfaces;
using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;
using GalaxyQuest.Models;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly StarWarsApiService _starWarsApiService;

        public PlanetsController(StarWarsApiService starWarsApiService)
        {
            _starWarsApiService = starWarsApiService;
        }

        public async Task<IActionResult> Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets; 
            var starWarsPlanets = await _starWarsApiService.GetAllPlanets(); 

            var model = new PlanetsViewModel
            {
                MilkyWayPlanets = milkyWayPlanets,
                StarWarsPlanets = starWarsPlanets
            };

            return View(model);
        }

        public IActionResult MilkyWayPlanets()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            return PartialView("_MilkyWayPlanets", milkyWayPlanets);
        }

        public async Task<IActionResult> StarWarsPlanets()
        {
            var starWarsPlanets = await _starWarsApiService.GetAllPlanets();
            return PartialView("_StarWarsPlanets", starWarsPlanets);
        }
    }
}
