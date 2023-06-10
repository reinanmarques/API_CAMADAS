using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.DTO.Request;

public class StudentUpdate
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Course Course { get; set; }

}