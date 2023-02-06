using System.ComponentModel.DataAnnotations;

namespace eBilety.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Avatar")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Imię i nazwisko")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
