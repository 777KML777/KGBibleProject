namespace Domain.Mappers;

public class BookServiceMapper : IBookServiceMapper
{
    public BookEntity DtoToEntity(BookDto dto) => new(dto);


    public IEnumerable<BookDto> EntityToDto(IEnumerable<BookEntity> entities) => 
        entities.Select((item) => new BookDto(item));

    public BookDto EntityToDto(BookEntity entity) => new(entity);

}