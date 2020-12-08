using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Height in Inches")]
        public int HeightInInches { get; set; }

        [Required]
        [Display(Name = "Goal Weight")]
        public int GoalWeight { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
