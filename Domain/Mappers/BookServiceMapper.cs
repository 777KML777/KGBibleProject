using Domain.Extension;

namespace Domain.Mappers;

public class BookServiceMapper : IBookServiceMapper
{
    public BookEntity MappingDtoToEntity(BookDto dto) =>
        new(dto.Nome, dto.Testamento, dto.Descricao); 

    public IEnumerable<BookDto> MappingEntityEnumerableToDtoEnumerable(IEnumerable<BookEntity> entities)
    {
        ICollection<BookDto> dtos = [];
        entities.ToList().ForEach(item => dtos.Add(item.ToDto()));
        return dtos;
    }

    public BookDto MappingEntityToDto(BookEntity entity) =>
        new(entity.CreatedAt, entity.CompletedAt, entity.DeletedAt, entity.UpdateAt, entity.Name, entity.Testament, entity.Description); // TODO: Colocar o nome do autor.

}