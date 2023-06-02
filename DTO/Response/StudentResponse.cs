namespace CRUD_ESTUDANTES.DTO.Response;

public class StudentResponse
{
    public StudentResponse(Guid id, string name, string course)
    {
        Id = id;
        Name = name;
        Course = course;
    }

    public Guid Id { get; set; } 
    public string Name { get; set; } 
    public string Course { get; set; } 
}