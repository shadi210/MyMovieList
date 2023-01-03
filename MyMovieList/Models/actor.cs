using System.ComponentModel.DataAnnotations;

namespace MyMovieList.Models
{
    public class actor
    {
        [Key]
        public int actorId { get; set; }
        public string photoUrl { get; set; }
        public string actorName { get; set; }
        public string Description { get; set; }
        public List<actor_movies> Actors_Movies { get; set; }
    }
}
