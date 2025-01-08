using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IRoleRepository : IRepository<Role>
{
    Task<GridResult<Role>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection);

}