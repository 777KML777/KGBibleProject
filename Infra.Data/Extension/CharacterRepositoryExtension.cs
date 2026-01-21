using Domain.Entities;
using Infra.Data.Mappings;

namespace Infra.Data.Extension;

public static class CharacterRepositoryExtension
{
    private readonly static ICharacterRepositoryMapper _mapper =
        GetterInjectionRepositoryExtensionMapper._characterRepositoryMapper ?? throw new("DI - RepositoryCharacterMapper Failed.");

    internal static CharacterEntityData ToEntityData(this CharacterEntity entity) =>
        _mapper.MappingEntityToEntityData(entity);
    internal static CharacterEntity ToEntity(this CharacterEntityData data) =>
        _mapper.MappingEntityDataToEntity(data);

    internal static IEnumerable<CharacterEntity> ToEntityEnumerable(this IEnumerable<CharacterEntityData> datas) =>
        _mapper.MappingEntityDataEnumerableToEntityEnumerable(datas);



}