using System.ComponentModel.DataAnnotations;

namespace CRUD_ESTUDANTES.DTO.Request;

public class StudentInsert
{
    public StudentInsert(string name, string course)
    {
        Name = name;
        Course = course;
    }

    [Required(ErrorMessage = "Preencha o nome")]
    public string Name { get; set; } 
    [Required(ErrorMessage = "Preencha o curso")]
    public string Course { get; set; }
    [Required(ErrorMessage = "Preencha o email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Preencha o password")]
    public string Password { get; set; }
    
}