using MyMovieList.Controllers.data.enums;
using MyMovieList.Models;
using static MyMovieList.Controllers.data.enums.genre;
using System.Collections.Generic;

namespace MyMovieList.Controllers.data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<movie>()
                    {
                        new movie()
                        {
                           movieName= "Life",
                            Description = "This is the Life movie description",
                            PosterUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            genres=new List<genre> (){ new genre { Genre=(genres)1 }, new genre { Genre = (genres)2 }, new genre { Genre = (genres)3 } } ,
                            movieScore=0
                        },
                        new movie()
                        {
                           movieName= "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            PosterUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            genres=new List<genre> (){ new genre { Genre=(genres)1 }, new genre { Genre = (genres)2 }, new genre { Genre = (genres)3 } } ,
                            movieScore=0
                        },
                        new movie()
                        {
                           movieName= "Ghost",
                            Description = "This is the Ghost movie description",
                            PosterUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            genres=new List<genre> (){ new genre { Genre=(genres)1 }, new genre { Genre = (genres)2 }, new genre { Genre = (genres)3 } } ,
                            movieScore=0
                        },
                        new movie()
                        {
                           movieName= "Race",
                            Description = "This is the Race movie description",
                            PosterUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            genres=new List<genre> (){ new genre { Genre=(genres)1 }, new genre { Genre = (genres)2 }, new genre { Genre = (genres)3 } } ,
                            movieScore=0
                        },
                        new movie()
                        {
                           movieName= "Scoob",
                            Description = "This is the Scoob movie description",
                            PosterUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            genres=new List<genre> (){ new genre { Genre=(genres)1 }, new genre { Genre = (genres)2 }, new genre { Genre = (genres)3 } } ,
                            movieScore=0
                        },
                        new movie()
                        {
                           movieName= "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            PosterUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            genres=new List<genre> (){ new genre { Genre=(genres)1 }, new genre { Genre = (genres)2 }, new genre { Genre = (genres)3 } } ,
                            movieScore=0
                        }
                    });
                    context.SaveChanges();
                }


                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<actor>()
                    {
                        new actor()
                        {
                            actorName = "actor 1",
                            Description = "This is the Description of the first actor",
                            photoUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new actor()
                        {
                            actorName = "actor 2",
                            Description = "This is the Description of the second actor",
                            photoUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new actor()
                        {
                            actorName = "actor 3",
                            Description = "This is the Description of the second actor",
                            photoUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new actor()
                        {
                            actorName = "actor 4",
                            Description = "This is the Description of the second actor",
                            photoUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new actor()
                        {
                            actorName = "actor 5",
                            Description = "This is the Description of the second actor",
                            photoUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                


                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<actor_movies>()
                    {
                        new actor_movies()
                        {
                            actorId = 1,
                            movieId = 1
                        },
                        new actor_movies()
                        {
                            actorId = 3,
                            movieId = 1
                        },

                         new actor_movies()
                        {
                            actorId = 1,
                            movieId = 2
                        },
                         new actor_movies()
                        {
                            actorId = 4,
                            movieId = 2
                        },

                        new actor_movies()
                        {
                            actorId = 1,
                            movieId = 3
                        },
                        new actor_movies()
                        {
                            actorId = 2,
                            movieId = 3
                        },
                        new actor_movies()
                        {
                            actorId = 5,
                            movieId = 3
                        },


                        new actor_movies()
                        {
                            actorId = 2,
                            movieId = 4
                        },
                        new actor_movies()
                        {
                            actorId = 3,
                            movieId = 4
                        },
                        new actor_movies()
                        {
                            actorId = 4,
                            movieId = 4
                        },


                        new actor_movies()
                        {
                            actorId = 2,
                            movieId = 5
                        },
                        new actor_movies()
                        {
                            actorId = 3,
                            movieId = 5
                        },
                        new actor_movies()
                        {
                            actorId = 4,
                            movieId = 5
                        },
                        new actor_movies()
                        {
                            actorId = 5,
                            movieId = 5
                        },


                        new actor_movies()
                        {
                            actorId = 3,
                            movieId = 6
                        },
                        new actor_movies()
                        {
                            actorId = 4,
                            movieId = 6
                        },
                        new actor_movies()
                        {
                            actorId = 5,
                            movieId = 6
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<users>()
                    {
                        new users()
                        {
                            userEmail = "admin",
                            password = "admin",
                            isAdmin = true

                        },
                        new users()
                        {
                            userEmail = "bchinic@gmail.com",
                            password = "shadi210",
                            isAdmin = false

                        }

                    });
                    context.SaveChanges();
                }

                if (!context.Movies_Watched.Any())
                {
                    context.Movies_Watched.AddRange(new List<MovieWatched>()
                    {
                        new MovieWatched()
                        {
                            movieId = 1,
                            userEmail = "bchinic@gmail.com"

                        },
                        new MovieWatched()
                        {
                            movieId = 2,
                            userEmail = "bchinic@gmail.com"

                        }

                    });
                    context.SaveChanges();
                }

            }




     
        }
    }
}

