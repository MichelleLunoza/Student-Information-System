using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.BLL
{
    public abstract class StudentBLL
    {
        internal void SaveData(StudentInfo studentinfo)
        {
            SaveDataDAL(studentinfo);
        }

        public abstract void SaveDataDAL(StudentInfo studentinfo);
   
    }
}
