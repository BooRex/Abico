using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Testing.Models;
using Testing.DataAccess;

namespace Testing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            College college = new College
            {
                Title = textBox1.Text,
                City = textBox2.Text
            };
            var context = new TestContext();
            context.Colleges.Add(college);
            context.SaveChanges();
        }
    }
}