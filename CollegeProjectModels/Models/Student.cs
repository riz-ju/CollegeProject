using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectModels.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public string department { get; set; }
        public int age { get; set; }

        public DateTime joiningDate { get; set; }
    }
}

