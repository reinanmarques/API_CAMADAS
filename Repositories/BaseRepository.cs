using System.Linq.Expressions;
using Azure.Core;
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Persistence;
using CRUD_ESTUDANTES.Repositories.Contract;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{

    protected RepositoryContext RepoContext { get; set; }

    public BaseRepository(RepositoryContext repoContext)
    {
        this.RepoContext = repoContext;
    }


    public async Task<List<T>> GetAll()
    {
      return  await RepoContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByCondition(Expression<Func<T, bool>> expression)
    {
        return await RepoContext.Set<T>().FindAsync(expression);

    }

    public async Task<T> Save(T entity)
    {
        await RepoContext.Set<T>().AddAsync(entity);
        RepoContext.SaveChanges();
        return entity;  
    }

    public  async Task<T> Update(T entity)
    {
        RepoContext.Set<T>().Update(entity);
        await RepoContext.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Delete(T entity)
    {
        RepoContext.Set<T>().Update(entity);
        await RepoContext.SaveChangesAsync();
        return entity;
    }
}