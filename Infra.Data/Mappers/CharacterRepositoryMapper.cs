using Domain.Entities;
using Infra.Data.Mappings;
using Infra.Data.Extension;

namespace Infra.Data.Mappers;

public class CharacterRepositoryMapper : ICharacterRepositoryMapper
{
    public IEnumerable<CharacterEntity> MappingEntityDataEnumerableToEntityEnumerable(IEnumerable<CharacterEntityData> datas)
    {
        ICollection<CharacterEntity> entities = [];
        datas.ToList().ForEach(item => entities.Add(item.ToEntity()));
        return entities;
    }

    public CharacterEntity MappingEntityDataToEntity(CharacterEntityData data)
    {
        CharacterEntity CharacterEntity = new(data.Nome, data.Descricao, data.Sexo, data.Plano, data.Tipo);
        return CharacterEntity;
    }

    public CharacterEntityData MappingEntityToEntityData(CharacterEntity entity)
    {
        CharacterEntityData CharacterEntityData = new()
        {
            Nome = entity.Nome,
            Descricao = entity.Descricao,
            Sexo = entity.Sexo,
            Plano = entity.Plano,
            Tipo = entity.Tipo
        };

        // TODO: Pegar na branch essas novas propriedades. 

        // CharacterEntityData.Capitulos = entity.Capitulos;
        // CharacterEntityData.Versiculos = entity.Versiculos;

        return CharacterEntityData;
    }
}