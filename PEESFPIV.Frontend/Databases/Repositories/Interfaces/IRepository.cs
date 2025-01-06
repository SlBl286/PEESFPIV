
using PEESFPIV.Frontend.Models;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IRepository<T> where T : BaseModel
{
    Task<T?> GetById(Guid Id);
    Task<List<T>> GetList();
    Task<int> GetCount();
    Task Add(T entity);
    Task AddRange(List<T> entities);

    Task Update(T entity);
    Task Delete(List<T> entities);
    Task Delete(List<Guid> ids);


    Task<bool> ExistsAsync(Guid Id);
}