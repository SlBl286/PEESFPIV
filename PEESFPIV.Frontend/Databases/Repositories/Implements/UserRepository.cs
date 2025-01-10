using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;
using System.Linq.Dynamic.Core;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class UserRepository : Repository<User>, IUserRepository
{

    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<GridResult<User>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection)
    {
        var orderby = "updatedAt ascending";
        if (!sortString.IsNullOrEmpty() && sortDirection != "None")
        {
            orderby = $@"{sortString} {sortDirection}";
        }
        var values = await _dbContext.Set<User>().Include(u => u.Role).Skip((PageNumber - 1) * PageSize).Take(PageSize).OrderBy(orderby).ToListAsync();

        return new GridResult<User> { Total = await _dbContext.Set<User>().CountAsync(), Values = values ?? new List<User>() };
    }



    public async Task<User?> GetUserByUsername(string username)
    {
        var user = await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Username == username);
        return user;
    }

}
