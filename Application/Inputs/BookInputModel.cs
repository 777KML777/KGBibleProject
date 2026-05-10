namespace Application.Inputs;

public record class BookInputModel : ValidatorInputModel
{
    public BookDto Book { get; set; }

    public override void Validate(string controller = "")
    {
        // TODO: Para validar o Id seria interessante passar a operação no Validate. 
        if(Book.Nome.Equals(string.Empty) || Book.Nome is null)
            throw new ApplicationInputModelException($"{controller.Replace("CONTROLLER", string.Empty)}-IM-1", $"Nome do livro é obrigatório.");
    }
}