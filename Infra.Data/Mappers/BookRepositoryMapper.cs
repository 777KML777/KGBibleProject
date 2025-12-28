using Domain.Entities;
using Infra.Data.Mappings;
using Infra.Data.Extension;

namespace Infra.Data.Mappers;

public class BookRepositoryMapper : IBookRepositoryMapper
{
    public IEnumerable<BookEntity> MappingEntityDataEnumerableToEntityEnumerable(IEnumerable<BookEntityData> datas)
    {
        ICollection<BookEntity> entities = [];
        datas.ToList().ForEach(item => entities.Add(item.ToEntity()));
        return entities;
    }

    public BookEntity MappingEntityDataToEntity(BookEntityData data)
    {
        BookEntity bookEntity = new(data.Nome, data.Testamento, data.AutorId, data.Descricao/* , data.Capitulos, data.Versiculos */);
        return bookEntity;
    }

    public BookEntityData MappingEntityToEntityData(BookEntity entity)
    {
        BookEntityData bookEntityData = new()
        {
            AutorId = entity.AutorId,
            Descricao = entity.Descricao,
            Id = entity.Id,
            Nome = entity.Nome,
            Testamento = entity.Testamento
        };

        // TODO: Pegar na branch essas novas propriedades. 

        // bookEntityData.Capitulos = entity.Capitulos;
        // bookEntityData.Versiculos = entity.Versiculos;

        return bookEntityData;
    }
}