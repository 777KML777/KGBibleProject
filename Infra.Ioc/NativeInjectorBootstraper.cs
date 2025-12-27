using Infra.Data.Interfaces;
using Infra.Data.Mappers;
using StorageContextJson;

namespace Infra.Ioc;

public static class NativeInjectorBootstrapper
{
    public static void Register(this IServiceCollection builder)
    {
        // AppServices 
        builder.AddScoped<IDoubtAppService, DoubtAppService>();

        // Services
        builder.AddScoped<IDoubtService, DoubtService>();
        // --- Services Mappers 
        builder.AddScoped<IDoubtServiceMapper, DoubtServiceMapper>();

        // Repositories 
        builder.AddScoped<IDoubtRepository, DoubtRepository>();
        // --- Repositories Mappers 
        builder.AddScoped<IDoubtRepositoryMapper, DoubtRepositoryMapper>();

        // Packages 
        builder.AddScoped<IGenericRepository, GenericRepository>();
    }
}