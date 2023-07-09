using FirstDemo.Infrastructure.BusinessObjects;

namespace FirstDemo.Infrastructure.services
{
    public interface ICourseService
    {
        void CreateCourse(Course course);
    }
}