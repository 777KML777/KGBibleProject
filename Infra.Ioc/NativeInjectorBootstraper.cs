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
        builder.AddScoped<ICharacterServiceMapper, CharacterServiceMapper>();

        // Repositories 
        builder.AddScoped<IBookRepository, BookRepository>();
        builder.AddScoped<ICharacterRepository, CharacterRepository>();

        // --- Repositories Mappers 
        builder.AddScoped<IBookRepositoryMapper, BookRepositoryMapper>();
        builder.AddScoped<ICharacterRepositoryMapper, CharacterRepositoryMapper>();

        // Packages 
        builder.AddScoped<IGenericRepository, GenericRepository>();
    }
}