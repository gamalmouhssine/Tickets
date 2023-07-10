using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Cinema
    {
        [Key]
        public int IdCinema { get; set; }
        public string Logo { get; set; }
        public string CinemaName { get; set; }    
        public string Description { get; set; }
        public List<Movie> movies { get; set; }


    }
}
