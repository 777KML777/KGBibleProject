namespace Domain.Dtos;

public record class BookDto
(
    DateTime CreatedAt,
    DateTime? CompletedAt,
    DateTime? DeletedAt,
    List<DateTime> UpdateAt,
    string Nome,
    string Testamento,
    string Descricao

)
: TrackerDto
(
    CreatedAt,
    CompletedAt,
    DeletedAt,
    UpdateAt
)
{
    public List<CharacterDto>? Character { get; set; } = null;
    public void SetCharacters(List<CharacterDto> character) => 
        Character = character;
};