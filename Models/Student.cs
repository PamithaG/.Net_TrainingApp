using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Invalid Max length")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = " Invalid Length")]
        public string LastName { get; set; }

        public string Address { get; set; }
        [Range(5, 200, ErrorMessage = "The age is incorrect")]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Grade Grade { get; set; }

        public Student( )
        {

        }
    }
}
