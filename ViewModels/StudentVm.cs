using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Models;

namespace TrainingApp.ViewModels
{
    public class StudentVm
    {
        public int Id { get; set; }

       
        public string FirstName { get; set; }

       
        public string Address { get; set; }

        
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Grade Grade { get; set; }
    }
}
