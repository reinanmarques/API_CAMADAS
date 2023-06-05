using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.Services.Contract;

public interface IStudentService
{
    List<StudentResponse> GetAll();
    StudentResponse GetById(Guid id);
    StudentResponse Save(StudentInsert? dto);
    StudentResponse Update(StudentUpdate? dto, Guid id);
    void Delete(Guid id);
}