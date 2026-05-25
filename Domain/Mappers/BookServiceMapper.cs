namespace Domain.Mappers;

public class BookServiceMapper : IBookServiceMapper
{
    public BookEntity DtoToEntity(BookDto dto)
    {
        BookEntity entity = new(dto.Nome, dto.Testamento, dto.Descricao);
        entity.SetId(dto.Id);
        return entity;
    }


    public IEnumerable<BookDto> EntityToDto(IEnumerable<BookEntity> entities)
    {
        ICollection<BookDto> dtos = [];
        entities.ToList().ForEach(item => dtos.Add(item.ToDto()));
        return dtos;
    }

    public BookDto EntityToDto(BookEntity entity) => new(entity);

}