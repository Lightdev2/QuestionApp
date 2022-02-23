using System.ComponentModel.DataAnnotations;

namespace GetAnswerApp.Core.DTOs
{
    public class NewUser
    {
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
