namespace Infra.Data.Extension;

public static class BookRepositoryExtension
{
    private readonly static IBookRepositoryMapper _mapper =
        GetterInjectionRepositoryExtensionMapper._bookRepositoryMapper ?? throw new("DI - RepositoryBookMapper Failed.");

    internal static BookEntityData ToEntityData(this BookEntity entity) =>
        _mapper.EntityToEntityData(entity);
    internal static BookEntity ToEntity(this BookEntityData data) =>
        _mapper.EntityDataToEntity(data);

    internal static IEnumerable<BookEntity> ToEntity(this IEnumerable<BookEntityData> datas) =>
        _mapper.EntityDataToEntity(datas);



}