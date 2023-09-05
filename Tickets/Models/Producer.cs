using System.ComponentModel.DataAnnotations;
using Tickets.Data.BaseEntity;

namespace Tickets.Models
{
    public class Producer: Crew, IEntityBase
    {
        [Key]
        public int id { get; set; }
        public List<Movie> movies { get; set; }
    }
}
