using System.ComponentModel.DataAnnotations;

namespace ScaffoldingDemo.Models
{
    public class LoginModel
    {

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

    }

}
