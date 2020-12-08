using System;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public double goalWeight { get; set; }
        public double heightInInches { get; set; }
        public double currentWeight { get; set; }
    }
}
