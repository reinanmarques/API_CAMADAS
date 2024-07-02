
using CRUD_ESTUDANTES.Data;
using CRUD_ESTUDANTES.Repositories.Contract;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CRUD_ESTUDANTES.Repositories
{

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected ProjectContext RepoContext { get; set; }

        public BaseRepository(ProjectContext projectContext)
        {
            this.RepoContext = projectContext;
        }


        public async Task<List<T>> GetAll()
        {
            return await RepoContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetById(Guid id)
        {
            return await RepoContext.Set<T>().FindAsync(id);

        }

        public async Task<T> Save(T entity)
        {
            await RepoContext.Set<T>().AddAsync(entity);
            RepoContext.SaveChanges();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            RepoContext.Set<T>().Update(entity);
            await RepoContext.SaveChangesAsync();
            return entity;
        }

        public void Delete(T entity)
        {
            RepoContext.Set<T>().Remove(entity);
            RepoContext.SaveChanges();
        }
    }
}