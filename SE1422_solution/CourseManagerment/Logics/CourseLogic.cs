using CourseManagerment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagement.Logics
{
    public class CourseLogic
    {
        public static List<Course> GetCourses()
        {
            using (var context = new APContext())
            {
                return context.Courses.ToList();
            }
        }
        public static Course GetCourse(int id)
        {
            using (var context = new APContext())
            {
                return context.Courses.FirstOrDefault(x => x.CourseId == id);
            }
        }
        public static List<Course> GetCourseBySubjectId(int id)
        {
            using (var context = new APContext())
            {
                return context.Courses.Where(x => x.SubjectId == id).ToList();
            }
        }
        public static List<Subject> GetSubjects()
        {
            using (var context = new APContext())
            {
                return context.Subjects.ToList();
            }
        }
        public static int DeleteCourse(int Id)
        {
            try
            {
                using (var context = new APContext())
                {
                    List<CourseSchedule> courseSchedule = context.CourseSchedules.Where(x => x.CourseId == Id).ToList();
                    List<RollCallBook> llBooks = new List<RollCallBook>();
                    foreach (var item in courseSchedule)
                    {
                        llBooks.AddRange(context.RollCallBooks.Where(x => x.TeachingScheduleId == item.TeachingScheduleId).ToList());
                    }
                    context.RollCallBooks.RemoveRange(llBooks);
                    context.CourseSchedules.RemoveRange(courseSchedule);
                    List<StudentCourse> studentCourses = context.StudentCourses.Where(x => x.CourseId == Id).ToList();
                    context.StudentCourses.RemoveRange(studentCourses);
                    context.Courses.Remove(context.Courses.First(x => x.CourseId == Id));
                    context.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
