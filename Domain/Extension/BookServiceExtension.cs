namespace Domain.Extension;

public static class BookServiceExtension
{
    private readonly static IBookServiceMapper _mapper =
        GetterInjectionServiceExtensionMapper._bookServiceMapper ?? throw new("DI - ServiceBookMapper Failed.");

    public static BookDto ToDto(this BookEntity entity) =>
        _mapper.EntityToDto(entity);

    public static BookEntity ToEntity(this BookDto dto) =>
        _mapper.DtoToEntity(dto);

    public static IEnumerable<BookDto> ToDto(this IEnumerable<BookEntity> entities) => 
        _mapper.EntityToDto(entities);
}