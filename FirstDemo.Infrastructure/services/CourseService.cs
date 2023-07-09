using FirstDemo.Infrastructure.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseBO = FirstDemo.Infrastructure.BusinessObjects.Course;
using CourseEO = FirstDemo.Infrastructure.Entites.Course;


namespace FirstDemo.Infrastructure.services
{
    public class CourseService : ICourseService
    {
        public void CreateCourse(CourseBO course)
        {
            course.SetProperClassStartDate();
        }
    }
}
