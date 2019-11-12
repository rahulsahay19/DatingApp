using System.ComponentModel.DataAnnotations;
using System;

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
        
        [Required]
        public string Gender { get; set; }
        
        [Required]
        public string KnownAs { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}