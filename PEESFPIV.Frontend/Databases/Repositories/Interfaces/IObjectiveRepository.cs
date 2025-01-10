using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IObjectiveRepository : IRepository<Objective>
{
    Task<GridResult<Objective>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection);

}