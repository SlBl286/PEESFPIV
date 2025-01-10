using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IKeyFocusRepository : IRepository<KeyFocus>
{
    Task<GridResult<KeyFocus>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection);

}