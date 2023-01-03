using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieList.Models
{
    public class actor_movies
    {
        [ForeignKey("actorId")]
        public int actorId { get; set; }
        public actor Actor { get; set; }

        [ForeignKey("movieId")]
        public int movieId { get; set; }
        public movie Movie { get; set; }
    }
}
