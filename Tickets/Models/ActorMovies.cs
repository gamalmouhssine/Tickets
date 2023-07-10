namespace Tickets.Models
{
    public class ActorMovies
    {
        public int MovieID { get; set; }
        public Movie movie { get; set; }
        public int ActorID { get; set; }
        public Actor actor { get; set; }
    }
}
