using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Feedbackmangement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select a category")]
        public string Category { get; set; }

        [Range(1, 5, ErrorMessage = "Select a rating from 1 to 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Enter your comments")]
        [StringLength(300, ErrorMessage = "Maximum 300 characters")]
        public string Comments { get; set; }
    }
}