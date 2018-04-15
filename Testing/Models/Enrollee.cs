using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Enrollee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public decimal CertAv { get; set; }
        public virtual College College { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}