using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface IResearchStudyRepository : IRepository<ResearchStudy>
{
    Task<GridResult<ResearchStudy>> GetPagedList(int PageNumber, int PageSize, string sortString, string sortDirection);

}