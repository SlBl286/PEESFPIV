using Microsoft.EntityFrameworkCore;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class SystemConfigRepository : Repository<SystemConfig>, ISystemConfigRepository
{
    public SystemConfigRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }

    public async Task<SystemConfig?> GetByCode(string code)
    {
        var conf = await _dbContext.Set<SystemConfig>().AsNoTracking().FirstOrDefaultAsync(u => u.Code == code);

        return conf;
    }
}