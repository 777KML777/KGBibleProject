using Services.Interfaces;
using Services.Implementations.Doubt;

namespace Ioc; 

public static class NativeInjectorBootstrapper
{
    public static void Register(this IServiceCollection builder)
    {
        // AppServices 
        builder.AddScoped<IDoubtAppServices, DoubtAppServices>(); 

        // Services
        builder.AddScoped<IDoubtServices, DoubtServices>(); 
        // -- Services Mappers 
        builder.AddScoped<IDoubtServicesMapper, DoubtServicesMapper>(); 

        // Repositories 
        builder.AddScoped<IDoubtRepositoryMapper, DoubtRepositoryMapper>(); 
        // -- Repositories Mappers 
        builder.AddScoped<IDoubtRepositoryMapper, DoubtRepositoryMapper>(); 
    }
}