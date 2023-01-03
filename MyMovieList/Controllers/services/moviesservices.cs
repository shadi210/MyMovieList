using Microsoft.EntityFrameworkCore;
using MyMovieList.Controllers.data;
using MyMovieList.Controllers.data.enums;
using MyMovieList.Models;

namespace MyMovieList.Controllers.services
{
    public class moviesservice: Imoviesservices
    {
        private readonly AppDbContext _context;

        public moviesservice(AppDbContext context)
        {
            _context = context;
        }
        

        public void addMovie(movie Movie)
        {
            _context.Movies.Add(Movie);
            _context.SaveChanges();
        }

        


        

        

        public void removeMovie(string movieId)
        
        {
            _context.Remove(_context.Movies.Single(a => a.movieId == int.Parse(movieId)));
            _context.SaveChanges();
        }

        public void UpdateMovie(String movieId,String PosterUrl, String movieName, String Description)
        
        {

            movie person = _context.Movies.FirstOrDefault(b => b.movieId == int.Parse(movieId));
            person.PosterUrl = PosterUrl;
            person.movieName = movieName;
            person.Description = Description;
            
            _context.SaveChanges();
        }

        

        async Task<IEnumerable<movie>> Imoviesservices.GetAll()
        {
            var result = await _context.Movies.ToListAsync();
            return result;
        }

        
    }
}
