using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LifeInsuranceWeb.Models
{
    public class CalculateModel
    {
        [Required(ErrorMessage = "Please fill in your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please supply a Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please choose a gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select a Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please choose whether you have children or not")]
        public string Children { get; set; }

        [Required(ErrorMessage = "Please state whether you are a smoker or not")]
        public string Smoker { get; set; }

        [Required(ErrorMessage = "Please supply the avereage amount of exercise you do a week please")]
        public int HoursOfExercise { get; set; }

    }
}