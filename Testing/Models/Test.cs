using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Test
    {
        public int ID { get; set; }
        public virtual Enrollee Enrollee { get; set; }
        public virtual Subject Subject { get; set; }
        public decimal Result { get; set; }
        public DateTime Date { get; set; }
    }
}