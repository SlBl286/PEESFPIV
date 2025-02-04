using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PEESFPIV.Frontend.Databases.Repositories.Implements;
using PEESFPIV.Frontend.Databases.Repositories.Interfaces;

namespace PEESFPIV.Frontend.Databases.Repositories;

public static class DependencyInjection
{

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        var dbSettings = new DbSettings();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ISystemConfigRepository, SystemConfigRepository>();
        services.AddScoped<IObjectiveRepository, ObjectiveRepository>();
        services.AddScoped<IKeyFocusRepository, KeyFocusRepository>();
        services.AddScoped<IOutcomeRepository, OutcomeRepository>();
        services.AddScoped<IPartnerRepository, PartnerRepository>();
        services.AddScoped<IResearchStudyRepository, ResearchStudyRepository>();
        services.AddScoped<ITrainingCourseRepository, TrainingCourseRepository>();

        return services;
    }
}