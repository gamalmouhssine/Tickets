using System.ComponentModel.DataAnnotations;
using Tickets.Data.BaseEntity;

namespace Tickets.Models
{
    public class Actor : Crew, IEntityBase
    {
       

        [Key]
        public int id { get; set; }
        public List<ActorMovies> actorMovies { get; set; }
    }
}
