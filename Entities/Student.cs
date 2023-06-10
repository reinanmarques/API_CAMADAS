namespace CRUD_ESTUDANTES.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Course Course { get; set; }
    public string Email  { get; set; }
    public string Password  { get; set; }

    public Student(string name, Course course, string email, string password)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Course = course;
        this.Email = email;
        this.Password = password;

    }

    public Student()
    {
    }
}