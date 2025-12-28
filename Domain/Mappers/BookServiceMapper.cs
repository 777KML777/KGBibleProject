using Domain.Extension;

namespace Domain.Mappers;

public class BookServiceMapper : IBookServiceMapper
{
    public BookEntity MappingDtoToEntity(BookDto dto) =>
        new(dto.Nome, dto.Testamento, dto.AutorId, dto.Descricao); // TODO: Não passar Id relacional por parâmetro. 

    public IEnumerable<BookDto> MappingEntityEnumerableToDtoEnumerable(IEnumerable<BookEntity> entities)
    {
        ICollection<BookDto> dtos = [];
        entities.ToList().ForEach(item => dtos.Add(item.ToDto()));
        return dtos;
    }

    public BookDto MappingEntityToDto(BookEntity entity) =>
        new(entity.Nome, entity.Testamento, entity.AutorId, entity.Descricao, entity.Nome); // TODO: Colocar o nome do autor.

}