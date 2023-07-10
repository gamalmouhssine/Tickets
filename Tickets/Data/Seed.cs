using Tickets.Data;
using Tickets.Models;
using Tickets.StaticData;


    public class Seed
{
    public static void seed(IApplicationBuilder app)
    {
        using (var servicescope = app.ApplicationServices.CreateScope())
        {
            var context = servicescope.ServiceProvider.GetService<Appdbcontext>();
            context.Database.EnsureCreated();

            //Cinema
            if (!context.cinemas.Any())
            {
                context.cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                context.SaveChanges();
            }
            //Actors
            if (!context.actors.Any())
            {
                context.actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePic = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                context.SaveChanges();
            }
            //Producers
            if (!context.producers.Any())
            {
                context.producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePic = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePic = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                context.SaveChanges();
            }
            //Movies
            if (!context.movies.Any())
            {
                context.movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Title = "Life",
                            Description = "This is the Life movie description",
                            Price = 39,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            Startdate = DateTime.Now.AddDays(-10),
                            Enddate = DateTime.Now.AddDays(10),
                            IdCinema = 3,
                            IdProducer = 3,
                            Moviecategory = Moviecategory.Documentary
                        },
                        new Movie()
                        {
                            Title = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 39,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            Startdate = DateTime.Now,
                            Enddate = DateTime.Now.AddDays(3),
                            IdCinema = 1,
                            IdProducer = 1,
                            Moviecategory = Moviecategory.Action
                        },
                        new Movie()
                        {
                            Title = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            Startdate = DateTime.Now,
                            Enddate = DateTime.Now.AddDays(7),
                            IdCinema = 4,
                            IdProducer = 4,
                            Moviecategory = Moviecategory.Horror
                        },
                        new Movie()
                        {
                            Title = "Race",
                            Description = "This is the Race movie description",
                            Price = 39,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            Startdate = DateTime.Now.AddDays(-10),
                            Enddate = DateTime.Now.AddDays(-5),
                            IdCinema = 1,
                            IdProducer = 2,
                            Moviecategory = Moviecategory.Documentary
                        },
                        new Movie()
                        {
                            Title = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            Startdate = DateTime.Now.AddDays(-10),
                            Enddate = DateTime.Now.AddDays(-2),
                            IdCinema = 1,
                            IdProducer = 3,
                            Moviecategory = Moviecategory.Musical
                        },
                        new Movie()
                        {
                            Title = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            Startdate = DateTime.Now.AddDays(3),
                            Enddate = DateTime.Now.AddDays(20),
                            IdCinema = 1,
                            IdProducer = 5,
                            Moviecategory = Moviecategory.Drama
                        }
                    });
                context.SaveChanges();
            }
            //Actors & Movies
            if (!context.actorMovies.Any())
            {
                context.actorMovies.AddRange(new List<ActorMovies>()
                    {
                        new ActorMovies()
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new ActorMovies()
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new ActorMovies()
                        {
                            ActorID = 1,
                             MovieID = 2
                        },
                         new ActorMovies()
                        {
                            ActorID = 4,
                             MovieID = 2
                        },

                        new ActorMovies()
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new ActorMovies()
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new ActorMovies()
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new ActorMovies()
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new ActorMovies()
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new ActorMovies()
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new ActorMovies()
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new ActorMovies()
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new ActorMovies()
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new ActorMovies()
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new ActorMovies()
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new ActorMovies()
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new ActorMovies()
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
                    });
                context.SaveChanges();
            }

        }
    }
}