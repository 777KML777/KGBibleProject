using Domain.Entities;
using Infra.Data.Mappings;

namespace Infra.Data.Extension;

public static class BookRepositoryExtension
{
    private readonly static IBookRepositoryMapper _mapper =
        GetterInjectionRepositoryExtensionMapper._bookRepositoryMapper ?? throw new("DI - RepositoryBookMapper Failed.");

    internal static BookEntityData ToEntityData(this BookEntity entity) => 
        _mapper.MappingEntityToEntityData(entity);
    internal static BookEntity ToEntity(this BookEntityData data) => 
        _mapper.MappingEntityDataToEntity(data);


}