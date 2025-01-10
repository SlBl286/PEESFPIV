using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.ViewModel;
using System.Linq.Dynamic.Core;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class ObjectiveRepository : Repository<Objective>, IObjectiveRepository
{
    public ObjectiveRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<GridResult<Objective>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection)
    {
        var orderby = "updatedAt ascending";
        if(!sortString.IsNullOrEmpty() && sortDirection != "None"){
            orderby = $@"{sortString} {sortDirection}";
        }
        var values =  await _dbContext.Set<Objective>().Skip((PageNumber-1)*PageSize).Take(PageSize).OrderBy(orderby).ToListAsync();

        return new GridResult<Objective>{ Total = await _dbContext.Set<Objective>().CountAsync(), Values = values ?? new List<Objective>() };
    }
}