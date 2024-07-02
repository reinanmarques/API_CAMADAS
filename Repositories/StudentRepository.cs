using CRUD_ESTUDANTES.Data;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Repositories.Contract;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Repositories
{

    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _dbset;

        public StudentRepository(ProjectContext projectContext) : base(projectContext)
        {
            _dbset = projectContext.Set<Student>();
        }

        public async Task<List<Student>> GetAllWithCourse()
        {
            return await _dbset.Include(s => s.Course)
                .ToListAsync();
        }
    }
}