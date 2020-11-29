using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public IList<Student> Student { get; set; }

    }
}
