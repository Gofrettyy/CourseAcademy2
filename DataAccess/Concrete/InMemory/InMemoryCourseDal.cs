using System.Linq.Expressions;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCourseDal : ICourseDal
{
    List<Course> _courses;

    public InMemoryCourseDal()
    {
        _courses = new List<Course>
        {
            new Course
            {
                Id = 1, CategoryId = 1, InstructorId = 1, Title = ".Net", Price = 0, Description = "Açıklama"
            },
            new Course
            {
                Id = 2, CategoryId = 1, InstructorId = 3, Title = "Java", Price = 0, Description = "Açıklama"
            },
            new Course { Id = 3, CategoryId = 2, InstructorId = 2, Title = "Js", Price = 0, Description = "Açıklama" },
            new Course { Id = 4, CategoryId = 3, InstructorId = 1, Title = "Rust", Price = 0, Description = "Açıklama" }

        };
    }

    public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
    {
        return _courses;
    }

    public Course Get(Expression<Func<Course, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Course entity)
    {
        _courses.Add(entity);
    }

    public void Update(Course entity)
    {
        Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == entity.Id);
        courseToUpdate.Title = entity.Title;
        courseToUpdate.CategoryId = entity.CategoryId;
        courseToUpdate.InstructorId = entity.InstructorId;
        courseToUpdate.Description = entity.Description;
        courseToUpdate.Price = entity.Price;
    }

    public void Delete(Course entity)
    {
        Course courseToDelete = _courses.SingleOrDefault(c => c.Id == entity.Id);
        _courses.Remove(courseToDelete);
    }

    public List<CourseDetailDto> GetCourseDetails()
    {
        throw new NotImplementedException();
    }
}