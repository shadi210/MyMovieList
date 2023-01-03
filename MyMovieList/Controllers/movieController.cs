using Microsoft.AspNetCore.Mvc;
using MyMovieList.Controllers.data;
using MyMovieList.Models;

namespace MyMovieList.Controllers
{
    public class movieController : Controller
    {


        private readonly AppDbContext _context;


        public movieController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index(int p=0)
        {
            var  data = _context.Movies.ToList();
            if (p == 1)
            {
                data.Sort(((x, y) => x.movieName.CompareTo(y.movieName)));
                return View(data);
            }
            else
            {
                data.Sort(((x, y) => x.movieScore.CompareTo(y.movieScore)));
                return View(data);
            }
        }

        
    }
}
