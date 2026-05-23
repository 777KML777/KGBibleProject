namespace Domain.Dtos;

public record class BookDto
(
    int Id,
    DateTime CreatedAt,
    DateTime? CompletedAt,
    DateTime? DeletedAt,
    List<DateTime>? UpdateAt,
    string Nome,
    string Testamento,
    string Descricao,
    int QuantidadeDeCapitulosEstimados
)
: TrackerDto
(
    CreatedAt,
    CompletedAt,
    DeletedAt,
    UpdateAt
)
{

    [JsonPropertyOrder(100)]
    public List<CharacterDto>? Character { get; set; } = null;
    public void SetCharacters(List<CharacterDto> character) =>
        Character = character;

    internal BookDto(BookEntity entity) : this
    (
        entity.Id,
        entity.CreatedAt,
        entity.CompletedAt,
        entity.DeletedAt,
        entity.UpdateAt,
        entity.Name,
        entity.Testament,
        entity.Description,
        0 /* entity.QuantidadeDeCapitulosEstimados */
    )
    {

    }
}