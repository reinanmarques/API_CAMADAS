using System.ComponentModel.DataAnnotations;

namespace CRUD_ESTUDANTES.DTO.Request;

public class StudentInsert
{
    [Required(ErrorMessage = "Preencha o nome")]
    public string Name { get; set; } 
    [Required(ErrorMessage = "Preencha o curso")]
    public string Course { get; set; } 
}