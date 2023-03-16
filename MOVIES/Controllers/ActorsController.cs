using Microsoft.AspNetCore.Mvc;
using MOVIES.DATA;
using MOVIES.DATA.Services;

namespace MOVIES.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAllActors();

            return View(data);
        }

        // Actors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
