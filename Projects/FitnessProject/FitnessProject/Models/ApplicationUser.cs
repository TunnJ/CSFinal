using System;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int goalWeight { get; set; }
        public int heightInInches { get; set; }
        public int currentWeight { get; set; }
    }
}
