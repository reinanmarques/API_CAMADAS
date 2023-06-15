using CRUD_ESTUDANTES.Data;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Repositories.Contract;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {

        public CourseRepository(ProjectContext projectContext) : base(projectContext)
        {
            
        }
    }
}
