using CourseManagement.Logics;
using CourseManagerment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagement.Controllers
{
    //[BindProperties(SupportsGet = true)]
    public class CourseController : Controller
    {
        //[BindProperty(SupportsGet = true)]
        //public int Id { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int Id)
        {
            List<Subject> subjects = CourseLogic.GetSubjects();
            List<Course> courses = new List<Course>();
            string subjectName = "";
            using (var context = new APContext())
            {
                if (Id != 0)
                {
                    courses = context.Courses.Where(c => c.SubjectId == Id).ToList();
                    subjectName = subjects.FirstOrDefault(x => x.SubjectId == Id).SubjectName;
                }
            }
            ViewData["Id"] = Id;
            ViewData["subjects"] = subjects;
            ViewData["subjectId"] = Id;
            ViewData["subjectName"] = subjectName;
            ViewData["courses"] = courses;
            return View();
        }
        // do delete course
        public IActionResult Delete(int Id)
        {
            if (CourseLogic.DeleteCourse(Id) != 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult Detail(int Id)
        {
            Course course = new Course();
            using (var context = new APContext())
            {
                course = context.Courses.FirstOrDefault(x => x.CourseId == Id);
                _ = context.StudentCourses.Where(x => x.CourseId == Id).ToList();
                _ = context.Students.ToList();
                _ = context.Instructors.FirstOrDefault(x => x.InstructorId == course.InstructorId);
                _ = context.Departments.ToList();
                _ = context.Terms.FirstOrDefault(x => x.TermId == course.TermId);
                _ = context.Subjects.FirstOrDefault(x => x.SubjectId == course.SubjectId);
                _ = context.Campuses.FirstOrDefault(x => x.CampusId == course.CampusId);

            }
            return View(course);
        }

    }
}
