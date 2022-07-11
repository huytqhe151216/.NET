using Lab2_DBConnect.DataAccess;
using Lab2_DBConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DBConnect.Logics
{
    internal class StudentManager
    {
        public static List<Student> GetAllStudents()
        {
            return StudentDAO.GetAllStudents();
        }
        public static List<Major> getAllMajors()
        {
            return MajorDAO.GetAllMajor();
        }
        public static List<Student> GetStudentByMajor(string majorCode)
        {
            return StudentDAO.GetStudentByMajor(majorCode);
        }
        public static int UpdateStudent(Student s)
        {
            return StudentDAO.UpdateStudent(s);
        }
        public static int InsertStudent(Student s)
        {
            return StudentDAO.InsertStudent(s);
        }
        public static int DeleteStudent(Student s)
        {
            return StudentDAO.DeleteStudent(s);
        }
    }
}
