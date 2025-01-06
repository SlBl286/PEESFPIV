using System.Text;
using PEESFPIV.Frontend.Utils.Implements;
using PEESFPIV.Frontend.Utils.Interfaces;
namespace PEESFPIV.Frontend.Utils;

public static class DependencyInjection
{

    public static IServiceCollection AddUtils(this IServiceCollection services)
    {

        services.AddSingleton<IHashString, HashStringUtil>();
        return services;
    }

}