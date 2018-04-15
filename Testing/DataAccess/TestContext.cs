using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Testing.Models;

namespace Testing.DataAccess
{
    class TestContext : DbContext
    {
        public DbSet<Enrollee> Enrollees { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Admission> Admissions { get; set; }    }
}