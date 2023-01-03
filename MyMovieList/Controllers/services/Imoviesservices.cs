using MyMovieList.Controllers.data.enums;
using MyMovieList.Models;

namespace MyMovieList.Controllers.services
{
    public interface Imoviesservices
    {
        Task<IEnumerable<movie>> GetAll();
        void addMovie(movie Movie);
        void UpdateMovie(String movieId, String PosterUrl ,String movieName ,String Description  );
        void removeMovie(string movieId);
    }
}
