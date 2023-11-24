using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfCourseDal : EfEntityRepositoryBase<Course,CourseAcademyDbContext> , ICourseDal
{
    public List<CourseDetailDto> GetCourseDetails()
    {
        using (CourseAcademyDbContext context = new CourseAcademyDbContext())
        {
            var result = from c in context.Courses
                join ct in context.Categories
                    on c.CategoryId equals ct.Id
                    join i in context.Instructors
                    on c.InstructorId equals i.Id
                select new CourseDetailDto
                {
                    Id = c.Id,
                    CategoryName = ct.Name,
                    Title = c.Title,
                    InstructorName = i.Name
                };
            return result.ToList();
        }
    }
}