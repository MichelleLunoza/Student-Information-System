using Student_Information_System.BLL;
using Student_Information_System.DAL;
using Student_Information_System.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
    public class Student: Istudent
    {
        private StudentBLL bll = new StudentDAL();

        public Student()
        {
        }

        public void SaveData(StudentInfo studentinfo)
        {
            bll.SaveData(studentinfo);
        }

    }
}
