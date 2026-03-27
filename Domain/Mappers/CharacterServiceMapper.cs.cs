using Domain.Extension;

namespace Domain.Mappers;

public class CharacterServiceMapper : ICharacterServiceMapper
{
    public CharacterEntity MappingDtoToEntity(CharacterDto dto) =>
        new(dto.Nome, dto.Descricao, dto.Sexo, dto.Plano, dto.Tipo); 

    public IEnumerable<CharacterDto> MappingEntityEnumerableToDtoEnumerable(IEnumerable<CharacterEntity> entities)
    {
        ICollection<CharacterDto> dtos = [];
        entities.ToList().ForEach(item => dtos.Add(item.ToDto()));
        return dtos;
    }

    public CharacterDto MappingEntityToDto(CharacterEntity entity) =>
        new(entity.Nome, entity.Descricao, entity.Sexo, entity.Plano, entity.Tipo); // TODO: Colocar o nome do autor.

}