using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PEESFPIV.Frontend.Databases.Repositories;

namespace PEESFPIV.Frontend.Databases;

public static class DependencyInjection
{

    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfigurationManager configuration)
    {
        var dbSettings = new DbSettings();
        configuration.Bind(DbSettings.SectionName, dbSettings);
        services.AddSingleton(Options.Create(dbSettings));
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(dbSettings.AppDb));
        services.AddRepositories();
        return services;
    }
}