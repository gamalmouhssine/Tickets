using System.ComponentModel.DataAnnotations;
using Tickets.Data.BaseEntity;

namespace Tickets.Models
{
    public class Cinema : Crew, IEntityBase
    {
        [Key]
        public int id { get; set; }
        public string Logo { get; set; }
        public string CinemaName { get; set; }    
        public string Description { get; set; }
        public List<Movie> movies { get; set; }


    }
}
