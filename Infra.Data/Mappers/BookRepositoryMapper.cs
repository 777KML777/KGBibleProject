namespace Infra.Data.Mappers;

public class BookRepositoryMapper : IBookRepositoryMapper
{
    public IEnumerable<BookEntity> EntityDataToEntity(IEnumerable<BookEntityData> datas)
    {
        ICollection<BookEntity> entities = [];
        datas.ToList().ForEach(item => entities.Add(item.ToEntity()));
        return entities;
    }

    public BookEntity EntityDataToEntity(BookEntityData data)
    {
        BookEntity entity = new(data.Nome, data.Testamento, data.Descricao);
        entity.SetAuthorId(data.AutorId);
        entity.SetId(data.Id);
        return entity;
    }

    public BookEntityData EntityToEntityData(BookEntity entity)
    {
        BookEntityData bookEntityData = new()
        {
            AutorId = entity.CharacterId,
            Descricao = entity.Description,
            Id = entity.Id,
            Nome = entity.Name,
            Testamento = entity.Testament
        };

        // TODO: Pegar na branch essas novas propriedades. 
        // bookEntityData.Capitulos = entity.Capitulos;
        // bookEntityData.Versiculos = entity.Versiculos;

        return bookEntityData;
    }
}