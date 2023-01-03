using Microsoft.EntityFrameworkCore;
using MyMovieList.Controllers.data.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieList.Models
{
    public class movie
    {

        [Key] 
        public int movieId { get; set; }
        public string PosterUrl { get; set; }
        public string movieName { get; set; }
        public float movieScore { get; set; }
        public string Description { get; set; }
        public List<genre> genres { get; set; }

        public List<actor_movies> Actors_Movies { get; set; }
        public List<MovieWatched> Movies_Watched { get; set; }



    }
}
