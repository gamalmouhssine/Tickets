using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Crew
    {
        [Required]
        [Display (Name = "Profile Picture")]
        public string ProfilePic { get; set; }
        [Required]
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Required]
        [Display(Name =" Biography")]
        public string Bio { get; set; }
    }
}
