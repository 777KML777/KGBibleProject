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

        // AppServices 
        builder.AddScoped<IBookAppService, BookAppService>();

        // Services
        builder.AddScoped<IBookService, BookService>();
        // --- Services Mappers 
        builder.AddScoped<IBookServiceMapper, BookServiceMapper>();

        // Repositories 
        builder.AddScoped<IBookRepository, BookRepository>();
        // --- Repositories Mappers 
        builder.AddScoped<IBookRepositoryMapper, BookRepositoryMapper>();

        // Packages 
        builder.AddScoped<IGenericRepository, GenericRepository>();
    }
}