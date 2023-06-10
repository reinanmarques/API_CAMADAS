namespace CRUD_ESTUDANTES.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
        public Course(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}