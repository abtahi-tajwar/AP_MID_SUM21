using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace June14ClassPerformance.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public int Credit { get; set; }
        public string CGPA { get; set; }
        public int Dept_Id { get; set; }
    }
    
}