namespace Domain.Dtos;

public record class BookDto(string Nome, string Testamento, string Descricao)
{
    CharacterDto Character {get; set;}
};