namespace Domain.Dtos;

public record class BookDto
(
    DateTime CreatedAt,
    DateTime? CompletedAt,
    DateTime? DeletedAt,
    List<DateTime> UpdateAt,
    string Nome,
    string Testamento,
    string Descricao,
    CharacterDto Character
)
: TrackerDto 
(
    CreatedAt,
    CompletedAt,
    DeletedAt,
    UpdateAt
);