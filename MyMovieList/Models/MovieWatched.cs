using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieList.Models
{
    public class MovieWatched
    {
          
        [ForeignKey("movieId")]
        public int movieId { get; set; }
        public movie Movie { get; set; }

        [ForeignKey("userEmail")]
        public String userEmail { get; set; }
        public users Users { get; set; }

        public bool watched { get; set; }
        public int score { get; set; }
        public bool favourite { get; set; }


    }
}
