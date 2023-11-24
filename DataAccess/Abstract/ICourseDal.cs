

using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;


namespace DataAccess.Abstract;

public interface ICourseDal : IEntityRepository<Course>
{
   List<CourseDetailDto> GetCourseDetails();

}