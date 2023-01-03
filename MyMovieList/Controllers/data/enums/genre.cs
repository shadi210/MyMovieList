using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

        
namespace MyMovieList.Controllers.data.enums
{
    public class genre
    {
        
        public enum genres
        {
            
            Action = 1,
            Comedy=2,
            Drama=3,
            Fantasy=4,
            Horror=5,
            Mystery=6,
            Romance=7,
            Thriller=8,
            Western=9,
        }

        [Key]
        public int id { get; set; }
        public genres Genre { get;  set; }


              

    }
}
