using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.Repositories.Contract;

public interface IStudentRepository : IBaseRepository<Student>
{
    public Task<List<Student>> GetAllWithCourse();
}