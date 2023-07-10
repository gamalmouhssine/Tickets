using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Producer:Crew
    {
        [Key]
        public int IdProducer { get; set; }
        public List<Movie> movies { get; set; }
    }
}
