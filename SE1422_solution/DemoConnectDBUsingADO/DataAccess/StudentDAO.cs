using DemoConnectDBUsingADO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConnectDBUsingADO.DataAccess
{
    internal class StudentDAO
    {
        private static List<Student> ConvertToListStudent(DataTable dt)
        {
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(
                    Convert.ToInt32(dr[0]),
                    dr[1].ToString(),
                    Convert.ToDateTime(dr[2]),
                    dr[3].ToString(),
                    Convert.ToInt32(dr[4]),
                    Convert.ToDouble(dr[5])));
            }
            return students;
        }

        public static List<Student> GetAllStudents()
        {
            string sql = "select * from Students";
            DataTable dt = DAO.GetDataBySql(sql,null);
            return ConvertToListStudent(dt);
        }

        public static List<Student> GetStudentByMajor(string major)
        {
            string sql = "select * from Students where Major = @m";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@m",System.Data.SqlDbType.NVarChar);
            parameters[0].Value = major;
            DataTable dt = DAO.GetDataBySql(sql,parameters);
            return ConvertToListStudent(dt);
        }

        public static int DeleteStudent(int StudentId)
        {
            string sql = "delete Students where Id = @id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id",SqlDbType.Int);
            parameters[0].Value = StudentId;
            return DAO.ExecuteSql(sql,parameters);
        }
    }
}
