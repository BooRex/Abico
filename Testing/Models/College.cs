using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class College
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public virtual ICollection<Enrollee> Enrollees { get; set; }
    }
}