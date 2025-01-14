using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.ViewModel;
using System.Linq.Dynamic.Core;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class ResearchStudyRepository : Repository<ResearchStudy>, IResearchStudyRepository
{
    public ResearchStudyRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<GridResult<ResearchStudy>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection)
    {
        var orderby = "updatedAt ascending";
        if(!sortString.IsNullOrEmpty() && sortDirection != "None"){
            orderby = $@"{sortString} {sortDirection}";
        }
        var values =  await _dbContext.Set<ResearchStudy>().Skip((PageNumber-1)*PageSize).Take(PageSize).OrderBy(orderby).ToListAsync();

        return new GridResult<ResearchStudy>{ Total = await _dbContext.Set<ResearchStudy>().CountAsync(), Values = values ?? new List<ResearchStudy>() };
    }
}