using Microsoft.AspNetCore.Mvc;
using MyMovieList.Controllers.services;
using MyMovieList.Models;

namespace MyMovieList.Controllers
{
    public class crudmoviescontroller : Controller
    {
        private readonly Imoviesservices _service;
        public crudmoviescontroller(Imoviesservices service)
        {
            _service = service;
        }






        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }


        [HttpPost]
        public ActionResult create( string PosterUrl, string movieName, string Description)

        {
            movie u = new movie();
            u.PosterUrl = PosterUrl;
            u.movieName = movieName;
            u.Description = Description;
            _service.addMovie(u);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult update(String PosterUrl, String movieName,  String Description, String id)
        {

            _service.UpdateMovie(id, PosterUrl,  movieName,    Description);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult delete(String id)
        {
            _service.removeMovie(id);
            return RedirectToAction("Index");
        }





    }

}
