using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Models;
using TrainingApp.ViewModels;

namespace TrainingApp.Data
{
    public class Test : DbContext
    {
        public Test (DbContextOptions<Test> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
