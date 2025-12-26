using Infra.Data.Interfaces;
using Infra.Data.Mappers;

namespace Ioc; 

public static class NativeInjectorBootstrapper
{
    public static void Register(this IServiceCollection builder)
    {
        // AppServices 
        builder.AddScoped<IDoubtAppServices, DoubtAppServices>(); 

        // Services
        builder.AddScoped<IDoubtService, DoubtService>(); 
        // --- Services Mappers 
        builder.AddScoped<IDoubtServiceMapper, DoubtServiceMapper>(); 

        // Repositories 
        builder.AddScoped<IDoubtRepository, DoubtRepository>(); 
        // --- Repositories Mappers 
        builder.AddScoped<IDoubtRepositoryMapper, DoubtRepositoryMapper>(); 
    }
}