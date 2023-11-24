using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract;

public interface ICourseService
{
    public IDataResult<List<Course>> GetAll();
    public IDataResult<List<Course>> GetByCourseId(int id);
    public IDataResult<List<CourseDetailDto>> GetCourseDetails();
    public IResult Add(Course course);
    public IResult Delete(Course course);
    public IResult Update(Course course);
}