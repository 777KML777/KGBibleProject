namespace Domain.Mappers;

public class BookServiceMapper : IBookServiceMapper
{
    public BookEntity MappingDtoToEntity(BookDto dto)
    {
        BookEntity entity = new(dto.Nome, dto.Testamento, dto.Descricao);
        entity.SetId(dto.Id);
        return entity;
    }


    public IEnumerable<BookDto> MappingEntityEnumerableToDtoEnumerable(IEnumerable<BookEntity> entities)
    {
        ICollection<BookDto> dtos = [];
        entities.ToList().ForEach(item => dtos.Add(item.ToDto()));
        return dtos;
    }

    public BookDto MappingEntityToDto(BookEntity entity) => new(entity);

}