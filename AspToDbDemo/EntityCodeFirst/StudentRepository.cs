using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirst
{
    public class StudentRepository
    {
        public List<Course> GetCourses()
        {
            var context = new StudentDataContext();
            return context.Courses.Include("Students").ToList();
        }
    }
}