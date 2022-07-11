using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DBConnect.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public Major Major { get; set; }
        public bool Active { get; set; }
        public double Scholarship { get; set; }

        public Student(int id, string name, bool gender, DateTime dob, Major major, bool active, double scholarship)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Dob = dob;
            Major = major;
            Active = active;
            Scholarship = scholarship;
        }

        public Student()
        {
            Scholarship = 0;
            Dob = DateTime.Today;
        }
    }
}
