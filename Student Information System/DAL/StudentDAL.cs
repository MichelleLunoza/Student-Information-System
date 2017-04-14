using Student_Information_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Student_Information_System.DAL
{
    internal class StudentDAL : StudentBLL
    {
        private string conStr = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();

        public override void SaveDataDAL(StudentInfo studentinfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("SaveData", con))
                {
                    cmd.Parameters.Add("ID", SqlDbType.Int).Value = studentinfo.ID;
                    cmd.Parameters.Add("Lastname", SqlDbType.NVarChar).Value = studentinfo.Lastname;
                    cmd.Parameters.Add("Firstname", SqlDbType.NVarChar).Value = studentinfo.Firstname;
                    cmd.Parameters.Add("Middlename", SqlDbType.NVarChar).Value = studentinfo.Middlename;
                    cmd.Parameters.Add("Age", SqlDbType.Int).Value = studentinfo.Age;
                    cmd.Parameters.Add("Sex", SqlDbType.NVarChar).Value = studentinfo.Sex;
                    cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = studentinfo.Address;
                    cmd.Parameters.Add("College", SqlDbType.NVarChar).Value = studentinfo.College;
                    cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = studentinfo.Course;
                    cmd.Parameters.Add("YearLevel", SqlDbType.NVarChar).Value = studentinfo.YearLevel;
                    cmd.Parameters.Add("Section", SqlDbType.NVarChar).Value = studentinfo.Section;
                    cmd.Parameters.Add("Semester", SqlDbType.NVarChar).Value = studentinfo.Semester;
                    cmd.Parameters.Add("Scholarship", SqlDbType.NVarChar).Value = studentinfo.Scholarship;


                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
 