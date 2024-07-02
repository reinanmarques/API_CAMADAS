using System.ComponentModel.DataAnnotations;
using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.DTO.Request
{

    public class StudentInsert
    {
        public StudentInsert()
        {

        }

        [Required(ErrorMessage = "Preencha o nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Preencha o curso")]
        public CourseRequest Course { get; set; }
        [Required(ErrorMessage = "Preencha o email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o password")]
        public string Password { get; set; }

    }
}