using OrderManagement.Core.Models;

namespace OrderManagement.Core.DataLayer.Repositories;
public interface IRepository<T> where T : BaseModel
{
    Task<T> GetByID(int id);
    Task<T> GetByUniqueID(Guid id);
    Task Insert(T entity);
    Task Insert(IEnumerable<T> entity);
    Task Delete(T entity);
    Task Delete(IEnumerable<T> entity);
}