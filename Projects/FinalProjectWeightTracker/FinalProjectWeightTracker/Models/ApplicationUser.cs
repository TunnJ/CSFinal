using System;
using Microsoft.AspNetCore.Identity;

namespace WeightTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int goalWeight { get; set; }
        public int heightInInches { get; set; }
    }
}
