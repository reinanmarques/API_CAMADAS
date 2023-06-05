using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Persistence;
using CRUD_ESTUDANTES.Repositories.Contract;

namespace CRUD_ESTUDANTES.Repositories;

public class StudentRepository : BaseRepository<Student> ,IStudentRepository
{
    public StudentRepository(RepositoryContext repoContext) : base(repoContext)
    {
    }
}