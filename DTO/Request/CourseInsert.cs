using System.ComponentModel.DataAnnotations;

namespace CRUD_ESTUDANTES.DTO.Request
{
    public class CourseInsert
    {
        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Name { get; set; }
    }
}
