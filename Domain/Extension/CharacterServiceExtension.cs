using Domain.Base.Class;

namespace Domain.Extension;

public static class CharacterServiceExtension
{
    private readonly static ICharacterServiceMapper _mapper =
        GetterInjectionServiceExtensionMapper._characterServiceMapper ?? throw new("DI - ServiceCharacterMapper Failed.");

    public static CharacterDto ToDto(this CharacterEntity entity) =>
        _mapper.MappingEntityToDto(entity);

    public static CharacterEntity ToEntity(this CharacterDto dto) =>
        _mapper.MappingDtoToEntity(dto);

    public static IEnumerable<CharacterDto> ToDtoEnumerable(this IEnumerable<CharacterEntity> entities) => 
        _mapper.MappingEntityEnumerableToDtoEnumerable(entities);
}