using System.ComponentModel.DataAnnotations;

namespace PF_CSHARPINTERMEDIO_IDLRH.Models
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}