using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
    public class StudentInfo
    {
        public StudentInfo()
        {
        }

        public int ID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string College { get; set; }
        public string Course { get; set; }
        public string YearLevel { get; set; }
        public string Sex { get; set; }
        public string Section { get; set; }
        public string Semester { get; set; }
        public string Scholarship { get; set; }

        //login
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
