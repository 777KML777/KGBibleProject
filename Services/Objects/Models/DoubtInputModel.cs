namespace Services.Objects.Models; 

public record class DoubtInputModel
(
    DoubtDto Dto,
    List<LivroDto> Livros  
);