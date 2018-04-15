using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Admission
    {
        public int ID { get; set; }
        public virtual Enrollee Enrollee { get; set; }
        public bool Budget { get; set; }
        public bool Daytime { get; set; }
    }
}