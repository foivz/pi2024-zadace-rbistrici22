using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment.Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        // Add additional properties as needed
    }
}
