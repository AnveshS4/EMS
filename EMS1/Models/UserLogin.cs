using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EMS1.Models
{
    public class UserLogin
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool RememberMe { get; set; }
    }
}
