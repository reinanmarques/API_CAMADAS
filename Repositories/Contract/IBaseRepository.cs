using System.Linq.Expressions;

namespace CRUD_ESTUDANTES.Repositories.Contract;

public interface IBaseRepository<T>
{
    Task<List<T>> GetAll();
     Task<T?> GetById(Guid id);
    Task<T> Save(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(Guid id);
}