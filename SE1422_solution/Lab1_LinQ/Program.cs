using System;
using System.Collections.Generic;

namespace Lab1_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            
            Program program = new Program();
            int choice;
            do
            {
                choice = student.Menu();
                
                switch (choice)
                {
                    case 0:
                        string fileName = @"C:\Users\ADMIN\source\repos\SE1422_solution\Lab1_LinQ\input.txt";
                        student.ReadFromFile(fileName);
                        student.PrintListStudent(student.students);
                        break;
                    case 1:
                        //student.PrintStudent(student.GetStudentById(program.GetInt()));
                        student.PrintListStudent(new List<Student>() { student.GetStudentById(program.GetInt("as ID: ")) });
                        break;
                    case 2:
                        student.PrintListStudent(student.GetStudentByName(program.GetString("as Name: ")));
                        break;
                    case 3:
                        student.PrintListStudent(student.GetStudentByMajor(program.GetString("as major: ")));
                        break;
                    case 4:
                        student.PrintListStudent(student.GetStudentByMajorAndScholarship(program.GetString("as major: "), program.GetFloat("as scholarship: ")));
                        break;
                    case 5:
                        student.PrintListStudent(student.GetStudentByYearOfDob(program.GetInt("as year: ")));
                        break;
                    case 6:
                        //student.PrintListStudent(student.GetStudentByDate(DateTime.Parse(program.GetString("as start date: ")), DateTime.Parse(program.GetString("as end date: "))));
                        student.PrintListStudent(student.GetStudentByDate(program.GetDateTime("as start date: "), program.GetDateTime("as end date: ")));
                        break;
                    case 7:
                        student.PrintListStudent(student.GetStudentByYearOfAddmission(program.GetInt("as year of addmission: ")));
                        break;
                    case 8:
                        student.PrintListStudent(student.GetStudentByScholarship(program.GetFloat("as min scholarship:"), program.GetFloat("as max scholarship: ")));
                        break;

                    case 9:
                        student.PrintListStudent(student.GetStudentByMajorAndName(program.GetString("as major:"), program.GetString("as name: ")));
                        break;
                }
                if (choice == 10) break;
            } while (true);
        }
        int GetInt(string mess)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a non negative integer "+mess);
                    
                    int num= Convert.ToInt32(Console.ReadLine());
                    if (num >= 0) return num;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a integer");
                }
            }
            
        }
        float GetFloat(string mess)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a non negative float number "+mess);
                    float num= Convert.ToSingle(Console.ReadLine());
                    if (num >= 0) return num;

                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a integer");
                }
            }

        }
        string GetString(string mess)
        {
            Console.Write("Enter a string "+mess);
            return Console.ReadLine();
        }

        DateTime GetDateTime(string mess)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a date " + mess);
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter a date like 15 Jun 2000");
                }
            }

        }
    }
}
