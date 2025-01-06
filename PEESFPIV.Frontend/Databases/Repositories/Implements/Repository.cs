using Microsoft.EntityFrameworkCore;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class Repository<T> : IRepository<T> where T : BaseModel
{
    protected readonly AppDbContext _dbContext;

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Add(T item)
    {
        var AddResult = await _dbContext.AddAsync(item);
        _dbContext.SaveChanges();
    }
    public async Task Update(T item)
    {
        var UpdateResult = _dbContext.Update(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        var item = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        return item is not null;
    }

    public async Task<List<T>> GetList()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }
    public async Task<int> GetCount()
    {
        return await _dbContext.Set<T>().CountAsync();
    }

    public async Task AddRange(List<T> entities)
    {
        await _dbContext.AddRangeAsync(entities);
    }

    public async Task Delete(List<T> entities)
    {
        _dbContext.RemoveRange(entities);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(List<Guid> ids)
    {
        var entities = await _dbContext.Set<T>().Where(ic => ids.Contains(ic.Id)).ToListAsync();
        _dbContext.RemoveRange(entities);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<T?> GetById(Guid id)
    {
        var item = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(u => u.Id.Equals(id));
        return item;
    }
}
