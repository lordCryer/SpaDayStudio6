﻿using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage="Enter all fields.")]
        [StringLength (15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 charactures long.")]
        public string? UserName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Enter all fields")]
        [StringLength (20, MinimumLength = 6, ErrorMessage = "Username must be between 6 and 20 charactures long.")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords must match.")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Enter all fields")]
        public string? VerifyPassword { get; set; }
    }
}
