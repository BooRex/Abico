using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}