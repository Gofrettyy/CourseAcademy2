

using Core.Entities;

namespace Entity.Concrete;

public class Category : IEntity
{
    public int Id { get; set; }
    public string Name  { get; set; }
    List<Course> Courses = new List<Course>();
    
}