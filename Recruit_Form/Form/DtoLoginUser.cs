using System.ComponentModel.DataAnnotations;

namespace Recruit.Form
{
    public class DtoLoginUser
    {
        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }
    }
}
