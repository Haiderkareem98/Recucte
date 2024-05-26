using System.ComponentModel.DataAnnotations;

namespace Recruit.Model
{
    public class UserA
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
