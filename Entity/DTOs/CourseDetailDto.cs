using Core.Entities;

namespace Entity.DTOs;

public class CourseDetailDto : IDto
{
    public int Id { get; set; }
    public string? CategoryName { get; set; }
    public string? InstructorName { get; set; }
    public string? Title { get; set; }
}