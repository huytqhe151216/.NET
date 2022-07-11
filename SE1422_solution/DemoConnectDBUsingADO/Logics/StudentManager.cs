using DemoConnectDBUsingADO.DataAccess;
using DemoConnectDBUsingADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConnectDBUsingADO.Logics
{
    internal class StudentManager
    {
        public static List<Student> GetAllStudents(string FileName)
        {
            FileIO file = new FileIO(FileName);
            return file.ReadFromFile();
        }
        public static List<Student> GetAllStudentFromDB()
        {
            return StudentDAO.GetAllStudents();
        }
        public static int DeleteStudent(int StudentId)
        {
            return StudentDAO.DeleteStudent(StudentId);
        }
        public static Student SearchById(List<Student> students, int Id)
        {
            return students.FirstOrDefault(x => x.Id == Id);
        }
        public static List<Student> SearchByName(List<Student> students, string Name)
        {
            return students.Where(x => x.Name.Contains(Name)).ToList();
        }

        public static List<Student> SearchByYearOfDob(List<Student> students, int Year)
        {
            return students.Where(x => x.Dob.Year == Year).ToList();
        }

        public static List<Student> SearchByMajor(List<Student> students, string Major)
        {
            return students.Where(x => x.Major.Equals(Major)).ToList();
        }

        public static List<Student> SearchByMajor(List<Student> students, List<string> Majors)
        {
            return students.Where(x => Majors.IndexOf(x.Major) >= 0).ToList();
        }

        public static List<Student> SearchByEntryYear(List<Student> students, int Year)
        {
            return students.Where(x => x.EntryYear == Year).ToList();
        }

        public static List<Student> SearchByScholarship(List<Student> students, double From, double To)
        {
            return students.Where(x => From <= x.Scholarship && x.Scholarship <= To).ToList();
        }

        public static List<String> GetAllMajor(List<Student> students)
        {
            List<String> list = students.Select(x => x.Major).Distinct().ToList();
            return list;
        }

        public static List<String> GetAllEntryYear(List<Student> students)
        {
            List<String> list = students.Select(x => x.EntryYear.ToString()).Distinct().ToList();
            list.Insert(0, "All years");
            return list;
        }

        public static List<String> GetAllYearDob(List<Student> students)
        {
            List<String> list = students.Select(x => x.Dob.Year.ToString()).Distinct().ToList();
            list.Insert(0, "All years");
            return list;
        }
    }
}
