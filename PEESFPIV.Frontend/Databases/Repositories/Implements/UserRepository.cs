using Microsoft.EntityFrameworkCore;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;
using PEESFPIV.Frontend.Models.Auth;

namespace PEESFPIV.Frontend.Databases.Repositories.Implements;

public class UserRepository : Repository<User>, IUserRepository
{

    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }



    public async Task<User?> GetUserByUsername(string username)
    {
        var user = await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Username == username);
        return user;
    }

}
