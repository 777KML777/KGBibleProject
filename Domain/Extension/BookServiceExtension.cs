using Domain.Base.Class;

namespace Domain.Extension;

public static class BookServiceExtension
{
    private readonly static IBookServiceMapper _mapper =
        GetterInjectionServiceExtensionMapper._bookServiceMapper ?? throw new("DI - ServiceBookMapper Failed.");

    public static BookDto ToDto(this BookEntity entity) =>
        _mapper.MappingEntityToDto(entity);

    public static BookEntity ToEntity(this BookDto dto) =>
        _mapper.MappingDtoToEntity(dto);

    public static IEnumerable<BookDto> ToDtoEnumerable(this IEnumerable<BookEntity> entities) => 
        _mapper.MappingEntityEnumerableToDtoEnumerable(entities);
}