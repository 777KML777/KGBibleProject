using Domain.Entities;
using Infra.Data.Base.Interfaces;
using Infra.Data.Mappings;

namespace Infra.Data.Mappers;

public class BookRepositoryMapper : IBookRepositoryMapper
{
    IEnumerable<BookEntity> IRepositoryMapper<BookEntity, BookEntityData>.MappingEntityDataEnumerableToEntityEnumerable(IEnumerable<BookEntityData> datas)
    {
        throw new NotImplementedException();
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