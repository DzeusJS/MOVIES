using Microsoft.AspNetCore.Mvc;
using MOVIES.DATA;

namespace MOVIES.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Cinemas.ToList();

            return View(data);
        }
       
    }
}
