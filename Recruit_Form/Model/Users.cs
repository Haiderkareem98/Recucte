using System.ComponentModel.DataAnnotations;

namespace Recruit_Form.Model
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }



    }
}
