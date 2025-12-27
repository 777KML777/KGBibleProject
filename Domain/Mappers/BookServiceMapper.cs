
namespace Domain.Mappers;

public class BookServiceMapper : IBookServiceMapper
{
    public BookEntity MappingDtoToEntity(BookDto dto) => 
        new(dto.Nome, dto.Testamento, dto.AutorId, dto.Descricao); // TODO: Não passar Id relacional por parâmetro. 

    public IEnumerable<BookDto> MappingEntityEnumerableToDtoEnumerable(IEnumerable<BookEntity> entities)
    {
        throw new NotImplementedException();
    }

    public BookDto MappingEntityToDto(BookEntity entity) => 
        new(entity.Nome, entity.Testamento, entity.AutorId, entity.Descricao, entity.Nome); // TODO: Colocar o nome do autor.

}