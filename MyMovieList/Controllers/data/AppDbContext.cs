using Microsoft.EntityFrameworkCore;
using MyMovieList.Models;

namespace MyMovieList.Controllers.data
{
    public class AppDbContext:DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
         {
         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<MovieWatched>().HasKey(am => new
            {
                am.userEmail,
                am.movieId
            });

            modelBuilder.Entity<MovieWatched>().HasOne(m => m.Movie).WithMany(am => am.Movies_Watched).HasForeignKey(m => m.movieId);
            modelBuilder.Entity<MovieWatched>().HasOne(m => m.Users).WithMany(am => am.Movies_Watched).HasForeignKey(m => m.userEmail);



            modelBuilder.Entity<actor_movies>().HasKey(am => new
            {
                am.actorId,
                am.movieId
            });

            modelBuilder.Entity<actor_movies>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.movieId);
            modelBuilder.Entity<actor_movies>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.actorId);

            


            base.OnModelCreating(modelBuilder);
        }


        


        public DbSet<actor> Actors { get; set; }
        public DbSet<movie> Movies { get; set; }
        public DbSet<users> Users { get; set; }
        public DbSet<actor_movies> Actors_Movies { get; set; }
        public DbSet<MovieWatched> Movies_Watched { get; set; }
        

    }
}