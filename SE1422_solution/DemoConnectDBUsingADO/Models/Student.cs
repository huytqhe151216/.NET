using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConnectDBUsingADO.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; }
        public int EntryYear { get; set; }
        public double Scholarship { get; set; }

        public Student(int id, string name, DateTime dob, string major, int entryYear, double scholarship)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Major = major;
            EntryYear = entryYear;
            Scholarship = scholarship;
        }
    }
}
