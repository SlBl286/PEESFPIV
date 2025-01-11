using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IPartnerRepository : IRepository<Partner>
{
    Task<GridResult<Partner>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection);

}