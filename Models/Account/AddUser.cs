using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Account
{
    public class AddUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "The Password field must be a minimum of 8 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must contain at least a lowercase letter, an uppercase letter and a symbol")]
        public string Password { get; set; }
    }
}