using System.ComponentModel.DataAnnotations;

namespace Study.UserIdentity.Mongo.DTO
{
    public class UserDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
