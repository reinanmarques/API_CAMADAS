using System.Diagnostics.CodeAnalysis;
using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.DTO.Response;

public class StudentResponse
{
    public StudentResponse(Student? student)
    {
        Id = student.Id;
        
        Name = student.Name;
        Course = student.Course;
    }

    public Guid Id { get; set; }
    [NotNull]
    public string Name { get; set; }
    [NotNull]
    public string Course { get; set; } 
    
    
}