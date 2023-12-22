using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEnd.Models
{
    public class ClientService
    {
        public int IdClient { get; set; }
        [Required (ErrorMessage = "Необходимо ввести фамилию")]
        [StringLength(50)]
        public string? Surname { get; set; }
        [Required (ErrorMessage = "Необходимо ввести имя")]
        [StringLength(50)]
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "Необходимо ввести дату рождения")]
        [StringLength(50)]
        public DateTime? BirthDate { get; set; }
        [Required(ErrorMessage = "Необходимо ввести город")]
        [StringLength(50)]
        public string? City { get; set; }
        [Required(ErrorMessage = "Необходимо ввести интересы")]
        [StringLength(50)]
        public string? Interest { get; set; }
        [Required(ErrorMessage = "Необходимо выбрать ваш пол")]
        [StringLength(50)]
        public string? Gender { get; set; }
        public bool HasPair { get; set; }
    }
}
