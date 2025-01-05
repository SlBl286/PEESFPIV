namespace PEESFPIV.Frontend.States;

public static class DependencyInjection
{

    public static IServiceCollection AddStates(this IServiceCollection services)
    {
        services.AddSingleton<SidebarState>();
        return services;
    }
}