using PEESFPIV.Frontend.Models.Auth;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetUserByUsername(string username);

}