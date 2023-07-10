using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Actor:Crew
    {
        [Key]
        public int IdActor { get; set; }
        public List<ActorMovies> actorMovies { get; set; }

    }
}
