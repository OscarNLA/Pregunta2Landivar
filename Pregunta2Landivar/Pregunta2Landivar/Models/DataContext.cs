using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pregunta2Landivar.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Pregunta2Landivar.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<Pregunta2Landivar.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<Pregunta2Landivar.Models.Course> Courses { get; set; }
    }
}