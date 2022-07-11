using DemoConnectDBUsingADO.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConnectDBUsingADO.DataAccess
{
    internal class FileIO
    {
        private string filename;

        public FileIO(string fileName)
        {
            this.filename = fileName;
        }
        public List<Student> ReadFromFile()
        {
            StreamReader reader = new StreamReader(filename);
            List<Student> students = new List<Student>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    string[] items = line.Split('|');
                    Student s = new Student(
                        Convert.ToInt32(items[0]),
                        items[1],
                        Convert.ToDateTime(items[2]),
                        items[3],
                        Convert.ToInt32(items[4]),
                        Convert.ToDouble(items[5])
                        );
                    students.Add(s);
                }
                catch (Exception)
                { }
            }
            reader.Close();
            return students;
        }
    }
}
