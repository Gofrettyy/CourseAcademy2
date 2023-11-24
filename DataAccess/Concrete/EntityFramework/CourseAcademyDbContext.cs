using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class CourseAcademyDbContext :DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source= localhost; Initial Catalog = CourseAcademyDb2; User Id=SA; Password = reallyStrongPwd123; TrustServerCertificate=True;Encrypt=false");
    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
}