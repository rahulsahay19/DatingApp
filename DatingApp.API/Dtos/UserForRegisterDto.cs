using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(17, MinimumLength=5, ErrorMessage="You must specify username between 5 and 17 characters.")]
        public string Username { get; set; }
        [Required]
        [StringLength(27, MinimumLength=5, ErrorMessage="You must specify password between 5 and 27 characters.")]
        public string Password { get; set; }
    }
}