using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class BMIViewModel
    {
        [Required]
        public double currentWeight { get; set; }
        public double goalWeight { get; set; }
        public double height { get; set; }

        public double calculateBMI(double currentWeight, double height)
        {
            return (currentWeight * 0.453592) / ((height / 39.3701) * (height / 39.3701));
        }

        public double calculateProgress(double currentWeight, double goalWeight)
        {
            return (goalWeight / currentWeight) * 100;
        }

        public string category(double BMI)
        {
            if(BMI < 18.5)
            {
                return "underweight";
            }else if(BMI < 24.9)
            {
                return "normal weight";
            }else if(BMI < 29.9)
            {
                return "overweight";
            }
            else
            {
                return "obese";
            }
        }
    }
}
