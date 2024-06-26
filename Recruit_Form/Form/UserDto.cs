﻿using System.ComponentModel.DataAnnotations;

namespace Recruit.Form
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
