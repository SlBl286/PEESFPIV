using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.ViewModel;
using System.Linq.Dynamic.Core;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class KeyFocusRepository : Repository<KeyFocus>, IKeyFocusRepository
{
    public KeyFocusRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<GridResult<KeyFocus>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection)
    {
        var orderby = "updatedAt ascending";
        if(!sortString.IsNullOrEmpty() && sortDirection != "None"){
            orderby = $@"{sortString} {sortDirection}";
        }
        var values =  await _dbContext.Set<KeyFocus>().Skip((PageNumber-1)*PageSize).Take(PageSize).OrderBy(orderby).ToListAsync();

        return new GridResult<KeyFocus>{ Total = await _dbContext.Set<KeyFocus>().CountAsync(), Values = values ?? new List<KeyFocus>() };
    }
}