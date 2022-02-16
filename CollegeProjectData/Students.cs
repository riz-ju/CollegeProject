using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectData
{
    public class Students
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Sdepartment { get; set; }
        public int Sage { get; set; }
        public DateTime SjoiningDate { get; set; }
        
    }
}
