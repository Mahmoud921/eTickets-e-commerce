using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePectureURL { get; set; }

        [Required(ErrorMessage = "Full Name is Required")]
        [Display(Name = "Full Name")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is Required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
