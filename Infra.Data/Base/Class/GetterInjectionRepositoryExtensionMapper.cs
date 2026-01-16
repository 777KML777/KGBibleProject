namespace Infra.Data.Base.Class;

/// <summary>
/// Essa classe base é responsável por simular uma injeção para as classes de extensões. <br/>
///  Classes estáticas de extensões não podem ser injetadas. 
/// </summary>
public static class GetterInjectionRepositoryExtensionMapper
{
    internal static IBookRepositoryMapper? _bookRepositoryMapper;
    internal static ICharacterRepositoryMapper? _characterRepositoryMapper;
    internal static IDoubtRepositoryMapper? _doubtRepositoryMapper;
    public static void Constructor(this WebApplication builder)
    {
        using var scope = builder.Services.CreateScope();
        {
            _bookRepositoryMapper = scope.ServiceProvider.GetRequiredService<IBookRepositoryMapper>();
            _characterRepositoryMapper = scope.ServiceProvider.GetRequiredService<ICharacterRepositoryMapper>();
            _doubtRepositoryMapper = scope.ServiceProvider.GetRequiredService<IDoubtRepositoryMapper>();
        }

    }
}