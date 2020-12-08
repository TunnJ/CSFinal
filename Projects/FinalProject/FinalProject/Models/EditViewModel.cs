using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class EditViewModel
    {
        [Required]
        public int GoalWeight { get; set; }
    }
}
