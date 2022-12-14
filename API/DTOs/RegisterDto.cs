using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(26, MinimumLength = 1)]
        public string UserName {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password {get; set;}
    }
}