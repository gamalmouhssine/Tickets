using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.Data
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovies>().HasKey(am => new
            {
                am.MovieID,
                am.ActorID
            });
            modelBuilder.Entity<ActorMovies>().HasOne(m =>
            m.movie).WithMany(am => 
            am.actorMovies).HasForeignKey(m =>
            m.MovieID);

            modelBuilder.Entity<ActorMovies>().HasOne(m =>
            m.actor).WithMany(am => 
            am.actorMovies).HasForeignKey(m =>
            m.ActorID);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> actors { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<ActorMovies> actorMovies { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Producer> producers { get; set; }
    }
}
