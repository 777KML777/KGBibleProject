namespace Domain.Base.Class;

/// <summary>
/// Essa classe base é responsável por simular uma injeção para as classes de extensões. <br/>
///  Classes estáticas de extensões não podem ser injetadas. 
/// </summary>
public static class GetterInjectionServiceExtensionMapper
{
    internal static IBookServiceMapper? _bookServiceMapper;
    internal static ICharacterServiceMapper? _characterServiceMapper;
    internal static IDoubtServiceMapper? _doubtServiceMapper;
    public static void Constructor(this WebApplication builder)
    {
        using var scope = builder.Services.CreateScope();
        _bookServiceMapper = scope.ServiceProvider.GetRequiredService<IBookServiceMapper>();
        _characterServiceMapper = scope.ServiceProvider.GetRequiredService<ICharacterServiceMapper>();
        _doubtServiceMapper = scope.ServiceProvider.GetRequiredService<IDoubtServiceMapper>();
    }
}