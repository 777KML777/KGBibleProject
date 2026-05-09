using System.Text.Json.Serialization;

namespace Domain.Dtos;

public record class BookDto
(
    int Id,
    DateTime CreatedAt,
    DateTime? CompletedAt,
    DateTime? DeletedAt,
    List<DateTime> UpdateAt,
    string Nome,
    string Testamento,
    string Descricao 
    // List<CharacterDto>?  Character = null

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
};