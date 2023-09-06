using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tickets.Data.BaseEntity;
using Tickets.StaticData;

namespace Tickets.Models
{
    public class Movie:IEntityBase
    {
        [Key] 
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime Startdate { get; set; }
        [Required]
        public DateTime Enddate { get; set; }
        [Required]
        public Moviecategory Moviecategory { get; set; }

        public List<ActorMovies> actorMovies { get; set; }
         
        public int IdCinema { get; set; }
        [ForeignKey("IdCinema")]
        public Cinema cinema { get; set; }

        public int IdProducer { get; set; }
        [ForeignKey("IdProducer")]
        public Producer producer { get; set; }
    }
}
