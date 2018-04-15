using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Models;
using Testing.DataAccess;

namespace Testing.Fill
{
    public class DataAdd
    {
        public static void FillDB(string a1, string a2)
        {
            var colleges = new List<College>
                {
                new College {
                    Title = a1, City = a2
                }
            };
            using (var context = new TestContext())
            {
                colleges.ForEach(p => context.Colleges.Add(p));
                context.SaveChanges();
            }
        }
    }
}