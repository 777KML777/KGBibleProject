using Domain.Exceptions;

namespace Application.Inputs;

public record class GetByIdInput
(
    int Id
) : ValidatorInputModel
{
    public override void Validate(string controller = "")
    {
        if(Id.Equals(0))
            throw new ApplicationInputModelException($"{controller.Replace("CONTROLLER", string.Empty)}-IM-1", $"Identificador deve ser maior que {Id}.");
    }
}