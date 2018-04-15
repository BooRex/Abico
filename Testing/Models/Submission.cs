using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Submission
    {
        public int ID { get; set; }
        public virtual Enrollee Enrollee { get; set; }
        public bool Original { get; set; }
    }
}