using CRUD_ESTUDANTES.Data;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Persistence;
using CRUD_ESTUDANTES.Repositories.Contract;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Repositories;

public class StudentRepository : BaseRepository<Student> ,IStudentRepository
{
  private  readonly RepositoryContext repoContext;
  
  public StudentRepository(RepositoryContext repoContext) : base(repoContext)
  {
      this.repoContext = repoContext;
  }

  public async Task<List<Student>> GetAllWithCourse()
    {
        return await repoContext.Students
            .Include(s => s.Course)
            .ToListAsync();
    }
}