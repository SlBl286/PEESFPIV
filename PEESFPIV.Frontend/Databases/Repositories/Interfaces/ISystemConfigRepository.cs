using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Models.ViewModel;

namespace PEESFPIV.Frontend.Databases.Repositories.Interfaces;

public interface ISystemConfigRepository : IRepository<SystemConfig>
{
    Task<SystemConfig?> GetByCode(string code);

}