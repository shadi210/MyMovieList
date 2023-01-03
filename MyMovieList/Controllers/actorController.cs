using Microsoft.AspNetCore.Mvc;
using MyMovieList.Controllers.data;

namespace MyMovieList.Controllers
{
    public class actorController : Controller
    {

        private readonly AppDbContext _context;


        public actorController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data=_context.Actors.ToList();
            return View(data);
        }
    }
}
