using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_LinQ
{
    public class Student
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public DateTime Dob { get; set; }
        public int YearAddmission { get; set; }
        public float Scholarship { get; set; }

        public List<Student> students;
        public Student()
        {
            students = new List<Student>();
        }

        public Student(int id, string name, string major, DateTime dob, int yearAddmission, float scholarship)
        {
            Id = id;
            Name = name;
            Major = major;
            Dob = dob;
            YearAddmission = yearAddmission;
            Scholarship = scholarship;
        }
        public void ReadFromLine(string line)
        {
            string[] parts = line.Split("|");
            if (parts.Length!=6) 
            {
                throw new FormatException("Student is wrong format");
            }
            Id = Convert.ToInt32((parts[0]).Trim());
            Name = parts[1].Trim();
            Major = parts[2].Trim();
            Dob = Convert.ToDateTime(parts[3]);
            YearAddmission = Convert.ToInt32((parts[4]).Trim());
            Scholarship = Convert.ToSingle(parts[5]);
        }
        
        public void ReadFromFile(String fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    Student s = new Student();
                    try
                    {
                        s.ReadFromLine(line);
                        students.Add(s);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                reader.Close();
            }
            catch (FileNotFoundException )
            {
                Console.WriteLine("Input file is not exist");
            }
        }
        public int Menu()
        {   
            Console.WriteLine("===========================");
            Console.WriteLine("0.Read student from file");
            Console.WriteLine("1.Search student by Id.");
            Console.WriteLine("2.Search student by name.");
            Console.WriteLine("3.Search student by major.");
            Console.WriteLine("4.Search student by major and scholarship>=a");
            Console.WriteLine("5.Search student by year of Dob");
            Console.WriteLine("6.Search student by date");
            Console.WriteLine("7.Search student by year of addmission");
            Console.WriteLine("8.Search student by scholarship");
            Console.WriteLine("9.Search student by major and name.");
            Console.WriteLine("10.Exit");
            Console.Write("Choose a option from  1 to 9:    ");
            while (true)
            {
                string number = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(number);
                    if (num >= 0 && num <= 10)
                    {
                        return num;
                    }
                    Console.WriteLine("Choice must in [0-10]: ");

                }
                catch
                {
                    Console.WriteLine("Choice must is number");
                }
            }
        }
        public void PrintListStudent(List<Student> students)
        {
            if (students.Count==0||students.Contains(null))
            {
                Console.WriteLine("Can't find any students like that");
                return;
            }
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id}|{student.Name}|{student.Major}|{Convert.ToDateTime(student.Dob):dd MMM yyyy}|{student.Scholarship}|{student.YearAddmission}");
            }
        }
        public void PrintStudent(Student student)
        {
            
            Console.WriteLine($"{student.Id}|{student.Name}|{student.Major}|{Convert.ToDateTime(student.Dob):dd MMM yyyy}|{student.Scholarship}|{student.YearAddmission}");
        }
        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(student => student.Id == id);
        }
        public List<Student> GetStudentByName(string name)
        {
            return students.Where(student => student.Name.Contains(name)).ToList();
        }
        public List<Student> GetStudentByMajor(string major)
        {
            return students.Where(student => student.Major.Contains(major)).ToList();
        }
        public List<Student> GetStudentByMajorAndScholarship(string major, float scholarship)
        {
            return students.Where(student => student.Major.Contains(major) && student.Scholarship >= scholarship).ToList(); 
        }
        public List<Student> GetStudentByYearOfDob(int year)
        {
            return students.Where(student => student.Dob.Year == year).ToList();
        }
        public List<Student> GetStudentByYearOfAddmission(int year)
        {
            return students.Where(student=> student.YearAddmission == year).ToList();
        }
        public List<Student> GetStudentByScholarship(float min, float max)
        {
            return students.Where(student=> student.Scholarship>=min && student.Scholarship<=max).ToList();
        }
        public List<Student> GetStudentByDate(DateTime start, DateTime end)
        {
            return students.Where(student=>student.Dob.CompareTo(start)>=0 && student.Dob.CompareTo(end)<=0).ToList();
        }
        public List<Student> GetStudentByMajorAndName(string major, string name)
        {
            return students.Where(student => student.Major.Equals(major) && student.Name.Contains(name)).ToList();
        }   
        public List<string> GetStudentYearOfBirth()
        {
            List<string> list = new List<string>();
            //foreach (Student student in students)
            //{
            //    if(!list.Contains(student.Dob.Year))
            //    list.Add(student.Dob.Year);
            //}
            //return list;
            list = students.GroupBy(x => x.Dob.Year).Select(x => x.First().Dob.Year.ToString()).OrderBy(x => x).ToList();
            list.Add("All");
            return list; 
        }
        public List<string> GetStudentYearOfAdmission()
        {
            List<string> list = new List<string>();
            //foreach (Student student in students)
            //{
            //    if (!list.Contains(student.YearAddmission))
            //        list.Add((int)student.YearAddmission);
            //}
            //return list;
            list = students.GroupBy(x => x.YearAddmission).Select(x => x.First().YearAddmission.ToString()).OrderBy(x => x).ToList();
            list.Add("All");
            return list; 
        }
        public List<string> GetListMajor()
        {
            return students.GroupBy(x=>x.Major).Select(x => x.First().Major).ToList();

        }
       
    }
}
