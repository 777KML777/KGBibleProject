namespace Services.Objects.Dtos; 

public record class DoubtDto 
(
    string Pergunta, 
    List<string> Assuntos
    // List<RespostaDto> 
);