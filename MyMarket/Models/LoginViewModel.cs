using System.ComponentModel.DataAnnotations;

namespace MyMarket.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")] 
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "")]
        public bool RememberMe { get; set; }
    }
}
