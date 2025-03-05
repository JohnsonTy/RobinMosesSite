using System.ComponentModel.DataAnnotations;

namespace RobinMoses.Models
{
        public class LoginVM
        {
            [Required(ErrorMessage = "Please enter your username.")]
            [StringLength(255)]
            public string Username { get; set; }

            [Required(ErrorMessage = "Please enter your password.")]
            [StringLength(255)]
            public string Password { get; set; }

            public string ReturnUrl { get; set; }

            public bool RememberMe { get; set; }

        }
}