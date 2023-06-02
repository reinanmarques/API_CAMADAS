namespace CRUD_ESTUDANTES.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }

    public Student(string name)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
       
    }
}