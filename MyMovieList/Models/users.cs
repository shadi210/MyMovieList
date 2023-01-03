using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace MyMovieList.Models
{
    public class users
    {



        [System.ComponentModel.DataAnnotations.Key]
        public string userEmail { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public bool isAdmin { get; set; }
        public List<MovieWatched> Movies_Watched { get; set; }

    }
}
