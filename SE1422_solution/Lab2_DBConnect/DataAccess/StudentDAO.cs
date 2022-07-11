using Lab2_DBConnect.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DBConnect.DataAccess
{
    internal class StudentDAO
    {
        private static List<Student> ConvertToListStudent(DataTable dt)
        {
            List<Student> students = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                students.Add(new Student(
                Convert.ToInt32(row["Id"]),
                row["Name"].ToString(),
                Convert.ToBoolean(row["Gender"]),
                Convert.ToDateTime(row["Dob"]),
                (new Major(row["Major"].ToString(), row["Title"].ToString())),
                Convert.ToBoolean(row["Active"]),
                Convert.ToDouble(row["Scholarship"])
                ));
            }
            return students;
        }

        public static List<Student> GetAllStudents()
        {
            String sql = "select s.*, m.Title from Students s join Major m on s.Major = m.Code";
            DataTable dt = DAO.GetDataBySql(sql, null);
            return ConvertToListStudent(dt);
        }

        public static List<Student> GetStudentByMajor(string majorCode)
        {
            String sql = "select s.*, m.Title from Students s join Major m on s.Major = m.Code and Major = @m";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@m", SqlDbType.VarChar);
            parameter[0].Value = majorCode;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            return ConvertToListStudent(dt);
        }

        public static int DeleteStudent(int StudentId)
        {
            string sql = "delete Students where Id = @id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = StudentId;
            return DAO.ExecuteSql(sql, parameters);
        }
        public static int UpdateStudent(Student s)
        {
            string sql = "update Students set Name = @name, Gender = @gender, Dob = @dob, Major = @major, Active = @active, Scholarship = @scholarship where id = @id";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = s.Name;
            parameters[1] = new SqlParameter("@gender", SqlDbType.Bit);
            parameters[1].Value = s.Gender;
            parameters[2] = new SqlParameter("@dob", SqlDbType.Date);
            parameters[2].Value = s.Dob;
            parameters[3] = new SqlParameter("@major", SqlDbType.VarChar);
            parameters[3].Value = s.Major.Code;
            parameters[4] = new SqlParameter("@active", SqlDbType.Bit);
            parameters[4].Value = s.Active ? 1 : 0;
            parameters[5] = new SqlParameter("@scholarship", SqlDbType.Float);
            parameters[5].Value = s.Scholarship;
            parameters[6] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[6].Value = s.Id;
            return DAO.ExecuteSql(sql, parameters);
        }
        public static int InsertStudent(Student s)
        {
            string sql = "Insert into Students ( [Name], [Gender], [Dob], [Major], [Scholarship], [Active]) values (@name,@gender,@dob,@major,@isActive,@scholarship)";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = s.Name;
            parameters[1] = new SqlParameter("@gender", SqlDbType.Bit);
            parameters[1].Value = s.Gender;
            parameters[2] = new SqlParameter("@dob", SqlDbType.Date);
            parameters[2].Value = s.Dob;
            parameters[3] = new SqlParameter("@major", SqlDbType.VarChar);
            parameters[3].Value = s.Major.Code;
            parameters[4] = new SqlParameter("@isActive", SqlDbType.Bit);
            parameters[4].Value = s.Active ? 1 : 0;
            parameters[5] = new SqlParameter("@scholarship", SqlDbType.Float);
            parameters[5].Value = s.Scholarship;
            
            return DAO.ExecuteSql(sql,parameters);
        }public static int DeleteStudent (Student s)
        {
            String sql = "Delete from Students where id = @id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = s.Id;
            return DAO.ExecuteSql(sql,parameters);
        }
    }
}
