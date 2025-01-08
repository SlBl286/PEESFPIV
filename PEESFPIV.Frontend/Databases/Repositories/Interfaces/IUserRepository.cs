using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetUserByUsername(string username);
    Task<GridResult<User>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection);

}